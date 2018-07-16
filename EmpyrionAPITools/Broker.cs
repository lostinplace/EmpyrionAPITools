using Eleon.Modding;
using System.Collections.Generic;
using System.Linq;
using System;

namespace EmpyrionAPITools
{

  public static partial class Broker
  {

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

    public static Dictionary<ushort, List<GenericAPICommand>> commandTracker = new Dictionary<ushort, List<GenericAPICommand>>();

    public static GenericAPICommand Execute(GenericAPICommand command)
    {
      List<GenericAPICommand> tmp;
      var commandList = commandTracker.TryGetValue(command.SequenceNumber, out tmp) ? tmp : new List<GenericAPICommand>();
      log(() => $"adding: {command.responseHandler}");
      commandList.Add(command);
      commandTracker[command.SequenceNumber] = commandList;
      api.Game_Request(command.call.CmdId, command.SequenceNumber, command.argument);
      return command;
    }


    public static void HandleGameEvent(CmdId eventId, ushort seqNr, object data)
    {            
      var apiEvent = new apiEvent(eventId, seqNr, data);
      log(() => $"receiving event {eventId.ToString()}:{seqNr}");

      if (!commandTracker.ContainsKey(seqNr)) return;

      Delegate handler;
      
      if (eventTable.TryGetValue(eventId, out handler))
        handler.DynamicInvoke(new object[] { data });
      
      var outstandingRequestList = commandTracker[seqNr];
      
      var firstApplicableRequest = outstandingRequestList.FirstOrDefault(x => x.call.ResponseCmdId == eventId || eventId == CmdId.Event_Error);
      
      if (firstApplicableRequest == null) return;
      
      outstandingRequestList.Remove(firstApplicableRequest);
      
      if (outstandingRequestList.Count > 0) commandTracker[seqNr] = outstandingRequestList;
      else commandTracker.Remove(seqNr);
      
      if (eventId == CmdId.Event_Error && firstApplicableRequest.errorHandler != null)
      {
          firstApplicableRequest.errorHandler((ErrorInfo)data);
          return;
      }
      
      firstApplicableRequest.responseHandler(eventId, data);
    }

    public static void log(string message)
    {
      if(verbose)
          api.Console_Write(message);
    }

    public static void log(System.Func<string> message)
    {
      if(verbose)
          api.Console_Write(message());
    }

    public static void noOpErrorHandler(ErrorInfo info) { }
  }      
}
