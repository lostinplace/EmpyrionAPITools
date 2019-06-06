using Eleon.Modding;
using System;
using EmpyrionAPIDefinitions;
using System.Threading;
using RingResources;

namespace EmpyrionAPITools
{
  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
  public class UnhandledGameAPIError : Exception {
    public UnhandledGameAPIError(string message) : base(message) { }
  }


  public class GenericAPICommand
  {
    private static Random rnd = new Random();
    private static RingResourceManager<ushort> argLessSequenceNumberManager = RingResourceManager.FromUShortBoundaries(1000, 2500);
    private static RingResourceManager<ushort> argumentIdentifiableSequenceNumberManager = RingResourceManager.FromUShortBoundaries(10, 250);

    public APIRequest call { get; set; }
    public object argument { get; set; }
    public Action<CmdId, object> responseHandler;
    public Action<ErrorInfo> errorHandler;
    public bool validated { get; set; }

    private static ushort getArgPart(object argument) => (ushort)((argument.GetHashCode() % 255) << 8);

    public ushort SequenceNumber {
      get;
      private set;
    }

    private void defaultResponseHandler(CmdId evt, object data)
    {
      Broker.log(() => $"unhandled response to {evt} event with {data}");
    }

    private void defaultErrorHandler(ErrorInfo err)
    {
      throw new UnhandledGameAPIError($"{err.errorType} : {err.ToString()}");
    }

    private static ushort getNewArglessSequenceNumber()
    {
      ushort candidate;
      lock (argLessSequenceNumberManager)
      {
        do
        {
          candidate = argLessSequenceNumberManager.CheckOutResource();
        } while (Broker.SequenceNumberInUse(candidate));
      }
      return candidate;
    }

    private static ushort getNewArgumentIdentifiableSequenceNumber(object argument)
    {
      ushort candidate;
      var argpart = getArgPart(argument);
      lock (argumentIdentifiableSequenceNumberManager)
      {
        do
        {
          var seqPart = argumentIdentifiableSequenceNumberManager.CheckOutResource();
          candidate = (ushort)(argpart | seqPart);
        } while (Broker.SequenceNumberInUse(candidate));
      }
      return candidate;
    }

    private static ushort getNewSequenceNumber(bool hasParam, object argument) => hasParam ? getNewArgumentIdentifiableSequenceNumber(argument) : getNewArglessSequenceNumber();

    public GenericAPICommand(CmdId cmdId, object argument, Action<CmdId, object> responseHandler = null, Action<ErrorInfo> errorHandler = null, bool validate = false)
    {
      this.call = APIManifest.APIRequestTable[cmdId];
      this.argument = argument;
      this.responseHandler = responseHandler ?? defaultResponseHandler;
      this.errorHandler = errorHandler ?? defaultErrorHandler;
      this.validated = validate && validateArguments(this.call, this.argument, this.responseHandler);
    }

    public void assignSequenceNumber()
    {
      this.SequenceNumber = getNewSequenceNumber(call.ParamType != null, argument);
    }

    public bool validateResponse(CmdId eventId, ushort seqNr, object data) {

      if (APIManifest.APIRequestResponseTable[call.CmdId].CmdId != eventId) return false;
      try
      {
        var validator = APIManifest.RequestResponseValidators[call.CmdId];
        if (validator == null) return true;
        return validator.validate(this.argument, data);
      }
      catch (Exception ex)
      {
        Broker.log(() => $"error attempting to validate message\n{ex.ToString()}", LogLevel.Error);
        return false;
      }
    }

    private static bool validateArguments(APIRequest call, object argument, Action<CmdId, object> responseHandler)
    {
      var argType = argument != null ? argument.GetType() : null;
      string message = null;
      if (argType != call.ParamType)
      {
        message = $"{argType.ToString()} is not a valid argument type for API call {call.CmdId}; expected: {call.ParamType.Name} ";
      }
      if (message != null)
      {
        throw new ArgumentException(message);
      }
      return true;
    }
    
  }
}
