 
using Eleon.Modding;
using System;
using System.Collections.Generic;
using System.Linq;

//this file was auto-generated

namespace EmpyrionAPITools
{
	public static partial class Broker {

			
    public static void Request_Playfield_List(Action<PlayfieldList> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Playfield_List;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((PlayfieldList)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Playfield_Stats(PString arg, Action<PlayfieldStats> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Playfield_Stats;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((PlayfieldStats)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Dedi_Stats(Action<DediStats> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Dedi_Stats;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((DediStats)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_GlobalStructure_List(Action<GlobalStructureList> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_GlobalStructure_List;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((GlobalStructureList)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_GlobalStructure_Update(PString arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_GlobalStructure_Update;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Structure_Touch(Id arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Structure_Touch;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Structure_BlockStatistics(Id arg, Action<IdStructureBlockInfo> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Structure_BlockStatistics;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((IdStructureBlockInfo)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_Info(Id arg, Action<PlayerInfo> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_Info;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((PlayerInfo)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_List(Action<IdList> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_List;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((IdList)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_GetInventory(Id arg, Action<Inventory> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_GetInventory;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((Inventory)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_SetInventory(Id arg, Action<Inventory> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_SetInventory;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((Inventory)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_AddItem(IdItemStack arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_AddItem;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_Credits(Id arg, Action<IdCredits> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_Credits;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((IdCredits)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_SetCredits(IdCredits arg, Action<IdCredits> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_SetCredits;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((IdCredits)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_AddCredits(IdCredits arg, Action<IdCredits> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_AddCredits;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((IdCredits)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Blueprint_Finish(Id arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Blueprint_Finish;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Blueprint_Resources(BlueprintResources arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Blueprint_Resources;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_ChangePlayerfield;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_ItemExchange(ItemExchangeInfo arg, Action<ItemExchangeInfo> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_ItemExchange;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((ItemExchangeInfo)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_SetPlayerInfo(PlayerInfoSet arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_SetPlayerInfo;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Entity_Teleport(IdPositionRotation arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Teleport;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_ChangePlayfield;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Entity_Destroy(Id arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Destroy;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Entity_PosAndRot(Id arg, Action<IdPositionRotation> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_PosAndRot;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((IdPositionRotation)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Entity_Spawn(EntitySpawnInfo arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Spawn;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Get_Factions(Id arg, Action<FactionInfoList> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Get_Factions;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((FactionInfoList)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_NewEntityId(Action<Id> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_NewEntityId;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((Id)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_AlliancesAll(Action<AlliancesTable> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_AlliancesAll;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((AlliancesTable)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_AlliancesFaction(AlliancesFaction arg, Action<AlliancesFaction> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_AlliancesFaction;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((AlliancesFaction)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Load_Playfield(PlayfieldLoad arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Load_Playfield;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_ConsoleCommand(PString arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_ConsoleCommand;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_GetBannedPlayers(Action<IdList> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_GetBannedPlayers;
      var apiCmd = new GenericAPICommand(cmdid, null, (_, val) => callback((IdList)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_InGameMessage_SinglePlayer(IdMsgPrio arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_InGameMessage_SinglePlayer;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_InGameMessage_AllPlayers(IdMsgPrio arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_InGameMessage_AllPlayers;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_InGameMessage_Faction(IdMsgPrio arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_InGameMessage_Faction;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_ShowDialog_SinglePlayer(IdMsgPrio arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_ShowDialog_SinglePlayer;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Player_GetAndRemoveInventory(Id arg, Action<Inventory> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Player_GetAndRemoveInventory;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((Inventory)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Playfield_Entity_List(PString arg, Action<PlayfieldEntityList> callback, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Playfield_Entity_List;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_, val) => callback((PlayfieldEntityList)val), onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Entity_Destroy2(IdPlayfield arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Destroy2;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Entity_Export(EntityExportInfo arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_Export;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
			
    public static void Request_Entity_SetName(IdPlayfieldName arg, Action<ErrorInfo> onError = null){
      var cmdid = CmdId.Request_Entity_SetName;
      var apiCmd = new GenericAPICommand(cmdid, arg, (_,__) => {}, onError ?? noOpErrorHandler);
      Broker.Execute(apiCmd);
    }
		}

  public abstract partial class SimpleMod {
		  public void Request_Playfield_List(Action<PlayfieldList> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Playfield_List(callback, onError);
    }
		  public void Request_Playfield_Stats(PString arg, Action<PlayfieldStats> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Playfield_Stats(arg, callback, onError);
    }
		  public void Request_Dedi_Stats(Action<DediStats> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Dedi_Stats(callback, onError);
    }
		  public void Request_GlobalStructure_List(Action<GlobalStructureList> callback, Action<ErrorInfo> onError = null){
      Broker.Request_GlobalStructure_List(callback, onError);
    }
		  public void Request_GlobalStructure_Update(PString arg, Action<ErrorInfo> onError = null){
      Broker.Request_GlobalStructure_Update(arg, onError);
    }
		  public void Request_Structure_Touch(Id arg, Action<ErrorInfo> onError = null){
      Broker.Request_Structure_Touch(arg, onError);
    }
		  public void Request_Structure_BlockStatistics(Id arg, Action<IdStructureBlockInfo> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Structure_BlockStatistics(arg, callback, onError);
    }
		  public void Request_Player_Info(Id arg, Action<PlayerInfo> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_Info(arg, callback, onError);
    }
		  public void Request_Player_List(Action<IdList> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_List(callback, onError);
    }
		  public void Request_Player_GetInventory(Id arg, Action<Inventory> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_GetInventory(arg, callback, onError);
    }
		  public void Request_Player_SetInventory(Id arg, Action<Inventory> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_SetInventory(arg, callback, onError);
    }
		  public void Request_Player_AddItem(IdItemStack arg, Action<ErrorInfo> onError = null){
      Broker.Request_Player_AddItem(arg, onError);
    }
		  public void Request_Player_Credits(Id arg, Action<IdCredits> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_Credits(arg, callback, onError);
    }
		  public void Request_Player_SetCredits(IdCredits arg, Action<IdCredits> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_SetCredits(arg, callback, onError);
    }
		  public void Request_Player_AddCredits(IdCredits arg, Action<IdCredits> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_AddCredits(arg, callback, onError);
    }
		  public void Request_Blueprint_Finish(Id arg, Action<ErrorInfo> onError = null){
      Broker.Request_Blueprint_Finish(arg, onError);
    }
		  public void Request_Blueprint_Resources(BlueprintResources arg, Action<ErrorInfo> onError = null){
      Broker.Request_Blueprint_Resources(arg, onError);
    }
		  public void Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg, Action<ErrorInfo> onError = null){
      Broker.Request_Player_ChangePlayerfield(arg, onError);
    }
		  public void Request_Player_ItemExchange(ItemExchangeInfo arg, Action<ItemExchangeInfo> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_ItemExchange(arg, callback, onError);
    }
		  public void Request_Player_SetPlayerInfo(PlayerInfoSet arg, Action<ErrorInfo> onError = null){
      Broker.Request_Player_SetPlayerInfo(arg, onError);
    }
		  public void Request_Entity_Teleport(IdPositionRotation arg, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Teleport(arg, onError);
    }
		  public void Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_ChangePlayfield(arg, onError);
    }
		  public void Request_Entity_Destroy(Id arg, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Destroy(arg, onError);
    }
		  public void Request_Entity_PosAndRot(Id arg, Action<IdPositionRotation> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_PosAndRot(arg, callback, onError);
    }
		  public void Request_Entity_Spawn(EntitySpawnInfo arg, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Spawn(arg, onError);
    }
		  public void Request_Get_Factions(Id arg, Action<FactionInfoList> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Get_Factions(arg, callback, onError);
    }
		  public void Request_NewEntityId(Action<Id> callback, Action<ErrorInfo> onError = null){
      Broker.Request_NewEntityId(callback, onError);
    }
		  public void Request_AlliancesAll(Action<AlliancesTable> callback, Action<ErrorInfo> onError = null){
      Broker.Request_AlliancesAll(callback, onError);
    }
		  public void Request_AlliancesFaction(AlliancesFaction arg, Action<AlliancesFaction> callback, Action<ErrorInfo> onError = null){
      Broker.Request_AlliancesFaction(arg, callback, onError);
    }
		  public void Request_Load_Playfield(PlayfieldLoad arg, Action<ErrorInfo> onError = null){
      Broker.Request_Load_Playfield(arg, onError);
    }
		  public void Request_ConsoleCommand(PString arg, Action<ErrorInfo> onError = null){
      Broker.Request_ConsoleCommand(arg, onError);
    }
		  public void Request_GetBannedPlayers(Action<IdList> callback, Action<ErrorInfo> onError = null){
      Broker.Request_GetBannedPlayers(callback, onError);
    }
		  public void Request_InGameMessage_SinglePlayer(IdMsgPrio arg, Action<ErrorInfo> onError = null){
      Broker.Request_InGameMessage_SinglePlayer(arg, onError);
    }
		  public void Request_InGameMessage_AllPlayers(IdMsgPrio arg, Action<ErrorInfo> onError = null){
      Broker.Request_InGameMessage_AllPlayers(arg, onError);
    }
		  public void Request_InGameMessage_Faction(IdMsgPrio arg, Action<ErrorInfo> onError = null){
      Broker.Request_InGameMessage_Faction(arg, onError);
    }
		  public void Request_ShowDialog_SinglePlayer(IdMsgPrio arg, Action<ErrorInfo> onError = null){
      Broker.Request_ShowDialog_SinglePlayer(arg, onError);
    }
		  public void Request_Player_GetAndRemoveInventory(Id arg, Action<Inventory> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Player_GetAndRemoveInventory(arg, callback, onError);
    }
		  public void Request_Playfield_Entity_List(PString arg, Action<PlayfieldEntityList> callback, Action<ErrorInfo> onError = null){
      Broker.Request_Playfield_Entity_List(arg, callback, onError);
    }
		  public void Request_Entity_Destroy2(IdPlayfield arg, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Destroy2(arg, onError);
    }
		  public void Request_Entity_Export(EntityExportInfo arg, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_Export(arg, onError);
    }
		  public void Request_Entity_SetName(IdPlayfieldName arg, Action<ErrorInfo> onError = null){
      Broker.Request_Entity_SetName(arg, onError);
    }
	    
  }
}

