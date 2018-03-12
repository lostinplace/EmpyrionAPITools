 
using Eleon.Modding;
using System;
using System.Collections.Generic;
using System.Linq;

//this file was auto-generated

namespace EmpyrionAPITools
{
	public static partial class Broker {

			
    public static void Request_Playfield_List(Action<PlayfieldList> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Playfield_List;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((PlayfieldList)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Playfield_Stats(PString arg, Action<PlayfieldStats> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Playfield_Stats;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((PlayfieldStats)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Dedi_Stats(Action<DediStats> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Dedi_Stats;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((DediStats)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_GlobalStructure_List(Action<GlobalStructureList> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_GlobalStructure_List;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((GlobalStructureList)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
	