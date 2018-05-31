 
using Eleon.Modding;
using System;
using System.Collections.Generic;
using System.Linq;

//this file was auto-generated

namespace EmpyrionAPITools
{
  public static partial class Broker {
      		
    public static void Request_Playfield_List(Action<PlayfieldList> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((PlayfieldList)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Playfield_List,
        null,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Playfield_Stats(PString arg, Action<PlayfieldStats> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((PlayfieldStats)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Playfield_Stats,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Dedi_Stats(Action<DediStats> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((DediStats)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Dedi_Stats,
        null,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_GlobalStructure_List(Action<GlobalStructureList> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((GlobalStructureList)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_GlobalStructure_List,
        null,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_GlobalStructure_Update(PString arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_GlobalStructure_Update,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Structure_Touch(Id arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Structure_Touch,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Structure_BlockStatistics(Id arg, Action<IdStructureBlockInfo> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((IdStructureBlockInfo)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Structure_BlockStatistics,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_Info(Id arg, Action<PlayerInfo> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((PlayerInfo)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_Info,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_List(Action<IdList> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((IdList)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_List,
        null,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_GetInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((Inventory)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_GetInventory,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_SetInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((Inventory)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_SetInventory,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_AddItem(IdItemStack arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_AddItem,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_Credits(Id arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((IdCredits)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_Credits,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_SetCredits(IdCredits arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((IdCredits)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_SetCredits,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_AddCredits(IdCredits arg, Action<IdCredits> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((IdCredits)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_AddCredits,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Blueprint_Finish(Id arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Blueprint_Finish,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Blueprint_Resources(BlueprintResources arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Blueprint_Resources,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_ChangePlayerfield,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_ItemExchange(ItemExchangeInfo arg, Action<ItemExchangeInfo> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((ItemExchangeInfo)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_ItemExchange,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_SetPlayerInfo(PlayerInfoSet arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_SetPlayerInfo,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Entity_Teleport(IdPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Entity_Teleport,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Entity_ChangePlayfield,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Entity_Destroy(Id arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Entity_Destroy,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Entity_PosAndRot(Id arg, Action<IdPositionRotation> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((IdPositionRotation)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Entity_PosAndRot,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Entity_Spawn(EntitySpawnInfo arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Entity_Spawn,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Get_Factions(Id arg, Action<FactionInfoList> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((FactionInfoList)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Get_Factions,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_NewEntityId(Action<Id> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((Id)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_NewEntityId,
        null,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_AlliancesAll(Action<AlliancesTable> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((AlliancesTable)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_AlliancesAll,
        null,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_AlliancesFaction(AlliancesFaction arg, Action<AlliancesFaction> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((AlliancesFaction)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_AlliancesFaction,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Load_Playfield(PlayfieldLoad arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Load_Playfield,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_ConsoleCommand(PString arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_ConsoleCommand,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_GetBannedPlayers(Action<IdList> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((IdList)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_GetBannedPlayers,
        null,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_InGameMessage_SinglePlayer(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_InGameMessage_SinglePlayer,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_InGameMessage_AllPlayers(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_InGameMessage_AllPlayers,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_InGameMessage_Faction(IdMsgPrio arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_InGameMessage_Faction,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_ShowDialog_SinglePlayer(DialogBoxData arg, Action<IdAndIntValue> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((IdAndIntValue)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_ShowDialog_SinglePlayer,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Player_GetAndRemoveInventory(Id arg, Action<Inventory> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((Inventory)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Player_GetAndRemoveInventory,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Playfield_Entity_List(PString arg, Action<PlayfieldEntityList> callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback((PlayfieldEntityList)val);
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Playfield_Entity_List,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Entity_Destroy2(IdPlayfield arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Entity_Destroy2,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Entity_Export(EntityExportInfo arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Entity_Export,
        arg,
        wiredCallback,
        onError ?? noOpErrorHandler
      );
      Broker.Execute(apiCmd);
    }
      		
    public static void Request_Entity_SetName(IdPlayfieldName arg, Action callback = null, Action<ErrorInfo> onError = null){     
      Action<CmdId, object> wiredCallback = null;
      if(callback != null) wiredCallback = (_, val) => callback();
      
      var apiCmd = new GenericAPICommand(
        CmdId.Request_Entity_SetName,
        arg,
        wiredCallback,
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
    
	  public void Request_ShowDialog_SinglePlayer(DialogBoxData arg, Action<IdAndIntValue> callback = null, Action<ErrorInfo> onError = null){
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

