 
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
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        null,
        (_, val) => finalCallback((PlayfieldList)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Playfield_Stats(PString arg, Action<PlayfieldStats> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Playfield_Stats;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((PlayfieldStats)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Dedi_Stats(Action<DediStats> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Dedi_Stats;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        null,
        (_, val) => finalCallback((DediStats)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_GlobalStructure_List(Action<GlobalStructureList> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_GlobalStructure_List;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        null,
        (_, val) => finalCallback((GlobalStructureList)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_GlobalStructure_Update(PString arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_GlobalStructure_Update;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Structure_Touch(Id arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Structure_Touch;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Structure_BlockStatistics(Id arg, Action<IdStructureBlockInfo> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Structure_BlockStatistics;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((IdStructureBlockInfo)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_Info(Id arg, Action<PlayerInfo> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_Info;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((PlayerInfo)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_List(Action<IdList> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_List;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        null,
        (_, val) => finalCallback((IdList)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_GetInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_GetInventory;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((Inventory)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_SetInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_SetInventory;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((Inventory)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_AddItem(IdItemStack arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_AddItem;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_Credits(Id arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_Credits;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((IdCredits)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_SetCredits(IdCredits arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_SetCredits;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((IdCredits)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_AddCredits(IdCredits arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_AddCredits;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((IdCredits)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Blueprint_Finish(Id arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Blueprint_Finish;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Blueprint_Resources(BlueprintResources arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Blueprint_Resources;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_ChangePlayerfield;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_ItemExchange(ItemExchangeInfo arg, Action<ItemExchangeInfo> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_ItemExchange;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((ItemExchangeInfo)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_SetPlayerInfo(PlayerInfoSet arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_SetPlayerInfo;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Entity_Teleport(IdPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Teleport;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_ChangePlayfield;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Entity_Destroy(Id arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Destroy;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Entity_PosAndRot(Id arg, Action<IdPositionRotation> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_PosAndRot;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((IdPositionRotation)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Entity_Spawn(EntitySpawnInfo arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Spawn;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Get_Factions(Id arg, Action<FactionInfoList> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Get_Factions;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((FactionInfoList)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_NewEntityId(Action<Id> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_NewEntityId;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        null,
        (_, val) => finalCallback((Id)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_AlliancesAll(Action<AlliancesTable> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_AlliancesAll;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        null,
        (_, val) => finalCallback((AlliancesTable)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_AlliancesFaction(AlliancesFaction arg, Action<AlliancesFaction> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_AlliancesFaction;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((AlliancesFaction)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Load_Playfield(PlayfieldLoad arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Load_Playfield;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_ConsoleCommand(PString arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_ConsoleCommand;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_GetBannedPlayers(Action<IdList> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_GetBannedPlayers;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        null,
        (_, val) => finalCallback((IdList)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_InGameMessage_SinglePlayer(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_InGameMessage_SinglePlayer;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_InGameMessage_AllPlayers(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_InGameMessage_AllPlayers;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_InGameMessage_Faction(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_InGameMessage_Faction;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_ShowDialog_SinglePlayer(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_ShowDialog_SinglePlayer;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Player_GetAndRemoveInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_GetAndRemoveInventory;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((Inventory)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Playfield_Entity_List(PString arg, Action<PlayfieldEntityList> callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Playfield_Entity_List;
      var finalCallback = callback ?? ((_) => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback((PlayfieldEntityList)val),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Entity_Destroy2(IdPlayfield arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Destroy2;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Entity_Export(EntityExportInfo arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Export;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
	
		
    public static void Request_Entity_SetName(IdPlayfieldName arg, Action callback = null, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_SetName;
      var finalCallback = callback ?? (() => {});
      var apiCmd = new GenericAPICommand(
        cmdid,
        arg,
        (_, val) => finalCallback(),
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
		}

  public abstract partial class SimpleMod {
	
	  public void Request_Playfield_List(Action<PlayfieldList> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Playfield_List(callback, onError);
    }
	
	  public void Request_Playfield_Stats(PString arg, Action<PlayfieldStats> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Playfield_Stats(arg, callback, onError);
    }
	
	  public void Request_Dedi_Stats(Action<DediStats> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Dedi_Stats(callback, onError);
    }
	
	  public void Request_GlobalStructure_List(Action<GlobalStructureList> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_GlobalStructure_List(callback, onError);
    }
	
	  public void Request_GlobalStructure_Update(PString arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_GlobalStructure_Update(arg, callback, onError);
    }
	
	  public void Request_Structure_Touch(Id arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Structure_Touch(arg, callback, onError);
    }
	
	  public void Request_Structure_BlockStatistics(Id arg, Action<IdStructureBlockInfo> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Structure_BlockStatistics(arg, callback, onError);
    }
	
	  public void Request_Player_Info(Id arg, Action<PlayerInfo> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_Info(arg, callback, onError);
    }
	
	  public void Request_Player_List(Action<IdList> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_List(callback, onError);
    }
	
	  public void Request_Player_GetInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_GetInventory(arg, callback, onError);
    }
	
	  public void Request_Player_SetInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_SetInventory(arg, callback, onError);
    }
	
	  public void Request_Player_AddItem(IdItemStack arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_AddItem(arg, callback, onError);
    }
	
	  public void Request_Player_Credits(Id arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_Credits(arg, callback, onError);
    }
	
	  public void Request_Player_SetCredits(IdCredits arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_SetCredits(arg, callback, onError);
    }
	
	  public void Request_Player_AddCredits(IdCredits arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_AddCredits(arg, callback, onError);
    }
	
	  public void Request_Blueprint_Finish(Id arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Blueprint_Finish(arg, callback, onError);
    }
	
	  public void Request_Blueprint_Resources(BlueprintResources arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Blueprint_Resources(arg, callback, onError);
    }
	
	  public void Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_ChangePlayerfield(arg, callback, onError);
    }
	
	  public void Request_Player_ItemExchange(ItemExchangeInfo arg, Action<ItemExchangeInfo> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_ItemExchange(arg, callback, onError);
    }
	
	  public void Request_Player_SetPlayerInfo(PlayerInfoSet arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_SetPlayerInfo(arg, callback, onError);
    }
	
	  public void Request_Entity_Teleport(IdPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Teleport(arg, callback, onError);
    }
	
	  public void Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_ChangePlayfield(arg, callback, onError);
    }
	
	  public void Request_Entity_Destroy(Id arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Destroy(arg, callback, onError);
    }
	
	  public void Request_Entity_PosAndRot(Id arg, Action<IdPositionRotation> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_PosAndRot(arg, callback, onError);
    }
	
	  public void Request_Entity_Spawn(EntitySpawnInfo arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Spawn(arg, callback, onError);
    }
	
	  public void Request_Get_Factions(Id arg, Action<FactionInfoList> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Get_Factions(arg, callback, onError);
    }
	
	  public void Request_NewEntityId(Action<Id> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_NewEntityId(callback, onError);
    }
	
	  public void Request_AlliancesAll(Action<AlliancesTable> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_AlliancesAll(callback, onError);
    }
	
	  public void Request_AlliancesFaction(AlliancesFaction arg, Action<AlliancesFaction> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_AlliancesFaction(arg, callback, onError);
    }
	
	  public void Request_Load_Playfield(PlayfieldLoad arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Load_Playfield(arg, callback, onError);
    }
	
	  public void Request_ConsoleCommand(PString arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_ConsoleCommand(arg, callback, onError);
    }
	
	  public void Request_GetBannedPlayers(Action<IdList> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_GetBannedPlayers(callback, onError);
    }
	
	  public void Request_InGameMessage_SinglePlayer(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_InGameMessage_SinglePlayer(arg, callback, onError);
    }
	
	  public void Request_InGameMessage_AllPlayers(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_InGameMessage_AllPlayers(arg, callback, onError);
    }
	
	  public void Request_InGameMessage_Faction(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_InGameMessage_Faction(arg, callback, onError);
    }
	
	  public void Request_ShowDialog_SinglePlayer(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_ShowDialog_SinglePlayer(arg, callback, onError);
    }
	
	  public void Request_Player_GetAndRemoveInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Player_GetAndRemoveInventory(arg, callback, onError);
    }
	
	  public void Request_Playfield_Entity_List(PString arg, Action<PlayfieldEntityList> callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Playfield_Entity_List(arg, callback, onError);
    }
	
	  public void Request_Entity_Destroy2(IdPlayfield arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Destroy2(arg, callback, onError);
    }
	
	  public void Request_Entity_Export(EntityExportInfo arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Export(arg, callback, onError);
    }
	
	  public void Request_Entity_SetName(IdPlayfieldName arg, Action callback = null, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_SetName(arg, callback, onError);
    }
	    
  }
}

