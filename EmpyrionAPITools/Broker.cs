using Eleon.Modding;
using System.Collections.Generic;
using System.Linq;
using System;
using EmpyrionAPIDefinitions;
using System.Runtime.Caching;
using System.Threading.Tasks;
using System.Timers;

namespace EmpyrionAPITools
{

  public class EmpyrionAPIException : Exception
  {
    public ErrorInfo info { get; private set; }

    public EmpyrionAPIException(string message, ErrorInfo info):base(message)
    {
      this.info = info;
    }

  }

  public class EmpyrionAPITimeoutException : TimeoutException
  {
    public GenericAPICommand command { get; private set; }

    public EmpyrionAPITimeoutException(string message, GenericAPICommand command) : base(message)
    {
      this.command = command;
    }

  }

  public static partial class Broker
  {

    public static int cacheTimeInMilliseconds = 5000;

    private static ModGameAPI _api;
    public static ModGameAPI api {
      get {
        return Broker._api;
      }

      set
      {
        _api = value;
      }
    }

    public static bool verbose { get; set; }
    public static LogLevel LogLevel { get; set; }

    private static MemoryCache commandTracker = new MemoryCache("APICommands");

    public static GenericAPICommand Execute(GenericAPICommand command)
    {
      var seqNrString = command.SequenceNumber.ToString();

      log(() => $"adding: {command.responseHandler}");
      lock (commandTracker)
      {
        command.assignSequenceNumber();
        commandTracker.Add(seqNrString, command, DateTime.Now.AddMilliseconds(cacheTimeInMilliseconds));
      }

      api.Game_Request(command.call.CmdId, command.SequenceNumber, command.argument);
      return command;
    }

    public static bool SequenceNumberInUse(ushort seqnr) => commandTracker.Contains(seqnr.ToString());


    private static Action<CmdId, object> generateSuccessCallback(TaskCompletionSource<object> completionSource, Action secondaryCallback, Timer timeoutTimer){
      Action<CmdId, object> wiredCallback = null;
      wiredCallback = (_, result) =>
      {
        timeoutTimer.Close();
        if (secondaryCallback != null) secondaryCallback();
        else completionSource.SetResult(result);
      };
      return wiredCallback;
    }

    private static Action<CmdId, object> generateSuccessCallback<T>(TaskCompletionSource<T> completionSource, Action<T> secondaryCallback, Timer timeoutTimer)
    {
      Action<CmdId, object> wiredCallback = null;
      wiredCallback = (_, result) =>
      {
        timeoutTimer.Close();
        if (secondaryCallback != null) secondaryCallback((T)result);
        else completionSource.SetResult((T)result);
      };
      return wiredCallback;
    }

    private static Action<ErrorInfo> generateErrorCallback(Action<ErrorInfo> onError, Timer timeoutTimer)
    {
      Action<ErrorInfo> errorCallback = (err) =>
      {
        timeoutTimer.Close();
        if (onError != null) onError(err);
        else noOpErrorHandler(err);
      };

      return errorCallback;
    }

    private static void setupTimer<T>(Timer timeoutTimer, GenericAPICommand command, TaskCompletionSource<T> completionSource)
    {
      timeoutTimer.Elapsed += (_, __) =>
      {
        if (!completionSource.Task.IsCompleted)
        {
          timeoutTimer.Close();
          lock (commandTracker)
          {
            commandTracker.Remove(command.SequenceNumber.ToString());
          }
          throw new EmpyrionAPITimeoutException("Encountered timeout while waiting for response to command", command);
        }
      };
      timeoutTimer.Start();
    }

    public static Task<R> CreateCommandWithArgAndReturn<A, R>(CmdId cmdId, A arg, Action successCallback, Action<ErrorInfo> onError = null)
    {
      return CreateCommandWithArgAndReturn<A, R>(cmdId, arg, (_) => successCallback(), onError);
    }

    public static Task<R> CreateCommandWithArgAndReturn<A,R>(CmdId cmdId, A arg, Action<R> successCallback = null, Action<ErrorInfo> onError = null)
    {

      var completionSource = new TaskCompletionSource<R>();
      var timeoutTimer = new System.Timers.Timer(cacheTimeInMilliseconds);
      timeoutTimer.AutoReset = false;

      var successfulCallback = generateSuccessCallback<R>(completionSource, successCallback, timeoutTimer);
      var errorCallback = generateErrorCallback(onError, timeoutTimer);

      var apiCmd = new GenericAPICommand(
        cmdId,
        arg,
        successfulCallback,
        errorCallback
      );

      Broker.Execute(apiCmd);
      setupTimer<R>(timeoutTimer, apiCmd, completionSource);
      return completionSource.Task;
    }

    public static void HandleGameEvent(CmdId eventId, ushort seqNr, object data)
    {            
      var apiEvent = new apiEvent(eventId, seqNr, data);
      log(() => $"receiving event {eventId.ToString()}:{seqNr}");

      Delegate handler;
      
      if (eventTable.TryGetValue(eventId, out handler))
        handler.DynamicInvoke(new object[] { data });

      var seqNrString = seqNr.ToString();

      if (!commandTracker.Contains(seqNrString)) return;

      GenericAPICommand outstandingCommand = default(GenericAPICommand);

      lock (commandTracker)
      {
        outstandingCommand = (GenericAPICommand)commandTracker.Get(seqNrString);

        if (eventId == CmdId.Event_Error || outstandingCommand.validateResponse(eventId, seqNr, data))
          commandTracker.Remove(seqNrString);
        else return;
      }

      if (eventId == CmdId.Event_Error && outstandingCommand.errorHandler != null)
        outstandingCommand.errorHandler((ErrorInfo)data);
      else outstandingCommand.responseHandler(eventId, data);
    }

    public static void log(string message)
    {
      log(message, LogLevel.Debug);
    }

    public static void log(string message, LogLevel aLevel)
    {
      if(verbose && LogLevel <= aLevel)
        api.Console_Write(message);
    }

    public static void log(System.Func<string> message)
    {
      log(message, LogLevel.Debug);
    }

    public static void log(System.Func<string> message, LogLevel aLevel)
    {
      if(verbose && LogLevel <= aLevel)
        api.Console_Write(message());
    }
    public static void noOpErrorHandler(ErrorInfo info) {
      throw new EmpyrionAPIException("Error returned by API", info);
    }
  }      
}
