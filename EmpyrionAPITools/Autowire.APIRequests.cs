 
using Eleon.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//this file was auto-generated

namespace EmpyrionAPITools
{
  public static partial class Broker {
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<PlayfieldList> Request_Playfield_List( Action<PlayfieldList> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<object,PlayfieldList>(CmdId.Request_Playfield_List, null, callback, onError);
    }

    public static Task<PlayfieldList> Request_Playfield_List(){     
      return Broker.CreateCommandWithArgAndReturn<object,PlayfieldList>(CmdId.Request_Playfield_List, null);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<PlayfieldStats> Request_Playfield_Stats(PString param, Action<PlayfieldStats> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<PString,PlayfieldStats>(CmdId.Request_Playfield_Stats, param, callback, onError);
    }

    public static Task<PlayfieldStats> Request_Playfield_Stats(PString param){     
      return Broker.CreateCommandWithArgAndReturn<PString,PlayfieldStats>(CmdId.Request_Playfield_Stats, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<DediStats> Request_Dedi_Stats( Action<DediStats> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<object,DediStats>(CmdId.Request_Dedi_Stats, null, callback, onError);
    }

    public static Task<DediStats> Request_Dedi_Stats(){     
      return Broker.CreateCommandWithArgAndReturn<object,DediStats>(CmdId.Request_Dedi_Stats, null);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<GlobalStructureList> Request_GlobalStructure_List( Action<GlobalStructureList> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<object,GlobalStructureList>(CmdId.Request_GlobalStructure_List, null, callback, onError);
    }

    public static Task<GlobalStructureList> Request_GlobalStructure_List(){     
      return Broker.CreateCommandWithArgAndReturn<object,GlobalStructureList>(CmdId.Request_GlobalStructure_List, null);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_GlobalStructure_Update(PString param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<PString,object>(CmdId.Request_GlobalStructure_Update, param, callback, onError);
    }

    public static Task<object> Request_GlobalStructure_Update(PString param){     
      return Broker.CreateCommandWithArgAndReturn<PString,object>(CmdId.Request_GlobalStructure_Update, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Structure_Touch(Id param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Structure_Touch, param, callback, onError);
    }

    public static Task<object> Request_Structure_Touch(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Structure_Touch, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id param, Action<IdStructureBlockInfo> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, param, callback, onError);
    }

    public static Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<PlayerInfo> Request_Player_Info(Id param, Action<PlayerInfo> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,PlayerInfo>(CmdId.Request_Player_Info, param, callback, onError);
    }

    public static Task<PlayerInfo> Request_Player_Info(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,PlayerInfo>(CmdId.Request_Player_Info, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<IdList> Request_Player_List( Action<IdList> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<object,IdList>(CmdId.Request_Player_List, null, callback, onError);
    }

    public static Task<IdList> Request_Player_List(){     
      return Broker.CreateCommandWithArgAndReturn<object,IdList>(CmdId.Request_Player_List, null);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<Inventory> Request_Player_GetInventory(Id param, Action<Inventory> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_GetInventory, param, callback, onError);
    }

    public static Task<Inventory> Request_Player_GetInventory(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_GetInventory, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<Inventory> Request_Player_SetInventory(Id param, Action<Inventory> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_SetInventory, param, callback, onError);
    }

    public static Task<Inventory> Request_Player_SetInventory(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_SetInventory, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Player_AddItem(IdItemStack param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdItemStack,object>(CmdId.Request_Player_AddItem, param, callback, onError);
    }

    public static Task<object> Request_Player_AddItem(IdItemStack param){     
      return Broker.CreateCommandWithArgAndReturn<IdItemStack,object>(CmdId.Request_Player_AddItem, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<IdCredits> Request_Player_Credits(Id param, Action<IdCredits> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,IdCredits>(CmdId.Request_Player_Credits, param, callback, onError);
    }

    public static Task<IdCredits> Request_Player_Credits(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,IdCredits>(CmdId.Request_Player_Credits, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<IdCredits> Request_Player_SetCredits(IdCredits param, Action<IdCredits> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdCredits,IdCredits>(CmdId.Request_Player_SetCredits, param, callback, onError);
    }

    public static Task<IdCredits> Request_Player_SetCredits(IdCredits param){     
      return Broker.CreateCommandWithArgAndReturn<IdCredits,IdCredits>(CmdId.Request_Player_SetCredits, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<IdCredits> Request_Player_AddCredits(IdCredits param, Action<IdCredits> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdCredits,IdCredits>(CmdId.Request_Player_AddCredits, param, callback, onError);
    }

    public static Task<IdCredits> Request_Player_AddCredits(IdCredits param){     
      return Broker.CreateCommandWithArgAndReturn<IdCredits,IdCredits>(CmdId.Request_Player_AddCredits, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Blueprint_Finish(Id param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Blueprint_Finish, param, callback, onError);
    }

    public static Task<object> Request_Blueprint_Finish(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Blueprint_Finish, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Blueprint_Resources(BlueprintResources param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<BlueprintResources,object>(CmdId.Request_Blueprint_Resources, param, callback, onError);
    }

    public static Task<object> Request_Blueprint_Resources(BlueprintResources param){     
      return Broker.CreateCommandWithArgAndReturn<BlueprintResources,object>(CmdId.Request_Blueprint_Resources, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdPlayfieldPositionRotation,object>(CmdId.Request_Player_ChangePlayerfield, param, callback, onError);
    }

    public static Task<object> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation param){     
      return Broker.CreateCommandWithArgAndReturn<IdPlayfieldPositionRotation,object>(CmdId.Request_Player_ChangePlayerfield, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo param, Action<ItemExchangeInfo> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<ItemExchangeInfo,ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, param, callback, onError);
    }

    public static Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo param){     
      return Broker.CreateCommandWithArgAndReturn<ItemExchangeInfo,ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Player_SetPlayerInfo(PlayerInfoSet param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<PlayerInfoSet,object>(CmdId.Request_Player_SetPlayerInfo, param, callback, onError);
    }

    public static Task<object> Request_Player_SetPlayerInfo(PlayerInfoSet param){     
      return Broker.CreateCommandWithArgAndReturn<PlayerInfoSet,object>(CmdId.Request_Player_SetPlayerInfo, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Entity_Teleport(IdPositionRotation param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdPositionRotation,object>(CmdId.Request_Entity_Teleport, param, callback, onError);
    }

    public static Task<object> Request_Entity_Teleport(IdPositionRotation param){     
      return Broker.CreateCommandWithArgAndReturn<IdPositionRotation,object>(CmdId.Request_Entity_Teleport, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdPlayfieldPositionRotation,object>(CmdId.Request_Entity_ChangePlayfield, param, callback, onError);
    }

    public static Task<object> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation param){     
      return Broker.CreateCommandWithArgAndReturn<IdPlayfieldPositionRotation,object>(CmdId.Request_Entity_ChangePlayfield, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Entity_Destroy(Id param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Entity_Destroy, param, callback, onError);
    }

    public static Task<object> Request_Entity_Destroy(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Entity_Destroy, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<IdPositionRotation> Request_Entity_PosAndRot(Id param, Action<IdPositionRotation> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,IdPositionRotation>(CmdId.Request_Entity_PosAndRot, param, callback, onError);
    }

    public static Task<IdPositionRotation> Request_Entity_PosAndRot(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,IdPositionRotation>(CmdId.Request_Entity_PosAndRot, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Entity_Spawn(EntitySpawnInfo param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<EntitySpawnInfo,object>(CmdId.Request_Entity_Spawn, param, callback, onError);
    }

    public static Task<object> Request_Entity_Spawn(EntitySpawnInfo param){     
      return Broker.CreateCommandWithArgAndReturn<EntitySpawnInfo,object>(CmdId.Request_Entity_Spawn, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<FactionInfoList> Request_Get_Factions(Id param, Action<FactionInfoList> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,FactionInfoList>(CmdId.Request_Get_Factions, param, callback, onError);
    }

    public static Task<FactionInfoList> Request_Get_Factions(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,FactionInfoList>(CmdId.Request_Get_Factions, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<Id> Request_NewEntityId( Action<Id> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<object,Id>(CmdId.Request_NewEntityId, null, callback, onError);
    }

    public static Task<Id> Request_NewEntityId(){     
      return Broker.CreateCommandWithArgAndReturn<object,Id>(CmdId.Request_NewEntityId, null);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<AlliancesTable> Request_AlliancesAll( Action<AlliancesTable> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<object,AlliancesTable>(CmdId.Request_AlliancesAll, null, callback, onError);
    }

    public static Task<AlliancesTable> Request_AlliancesAll(){     
      return Broker.CreateCommandWithArgAndReturn<object,AlliancesTable>(CmdId.Request_AlliancesAll, null);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction param, Action<AlliancesFaction> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<AlliancesFaction,AlliancesFaction>(CmdId.Request_AlliancesFaction, param, callback, onError);
    }

    public static Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction param){     
      return Broker.CreateCommandWithArgAndReturn<AlliancesFaction,AlliancesFaction>(CmdId.Request_AlliancesFaction, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Load_Playfield(PlayfieldLoad param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<PlayfieldLoad,object>(CmdId.Request_Load_Playfield, param, callback, onError);
    }

    public static Task<object> Request_Load_Playfield(PlayfieldLoad param){     
      return Broker.CreateCommandWithArgAndReturn<PlayfieldLoad,object>(CmdId.Request_Load_Playfield, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_ConsoleCommand(PString param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<PString,object>(CmdId.Request_ConsoleCommand, param, callback, onError);
    }

    public static Task<object> Request_ConsoleCommand(PString param){     
      return Broker.CreateCommandWithArgAndReturn<PString,object>(CmdId.Request_ConsoleCommand, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<IdList> Request_GetBannedPlayers( Action<IdList> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<object,IdList>(CmdId.Request_GetBannedPlayers, null, callback, onError);
    }

    public static Task<IdList> Request_GetBannedPlayers(){     
      return Broker.CreateCommandWithArgAndReturn<object,IdList>(CmdId.Request_GetBannedPlayers, null);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_InGameMessage_SinglePlayer(IdMsgPrio param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_SinglePlayer, param, callback, onError);
    }

    public static Task<object> Request_InGameMessage_SinglePlayer(IdMsgPrio param){     
      return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_SinglePlayer, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_InGameMessage_AllPlayers(IdMsgPrio param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_AllPlayers, param, callback, onError);
    }

    public static Task<object> Request_InGameMessage_AllPlayers(IdMsgPrio param){     
      return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_AllPlayers, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_InGameMessage_Faction(IdMsgPrio param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_Faction, param, callback, onError);
    }

    public static Task<object> Request_InGameMessage_Faction(IdMsgPrio param){     
      return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_Faction, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData param, Action<IdAndIntValue> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<DialogBoxData,IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, param, callback, onError);
    }

    public static Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData param){     
      return Broker.CreateCommandWithArgAndReturn<DialogBoxData,IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<Inventory> Request_Player_GetAndRemoveInventory(Id param, Action<Inventory> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_GetAndRemoveInventory, param, callback, onError);
    }

    public static Task<Inventory> Request_Player_GetAndRemoveInventory(Id param){     
      return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_GetAndRemoveInventory, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString param, Action<PlayfieldEntityList> callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<PString,PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, param, callback, onError);
    }

    public static Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString param){     
      return Broker.CreateCommandWithArgAndReturn<PString,PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Entity_Destroy2(IdPlayfield param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdPlayfield,object>(CmdId.Request_Entity_Destroy2, param, callback, onError);
    }

    public static Task<object> Request_Entity_Destroy2(IdPlayfield param){     
      return Broker.CreateCommandWithArgAndReturn<IdPlayfield,object>(CmdId.Request_Entity_Destroy2, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Entity_Export(EntityExportInfo param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<EntityExportInfo,object>(CmdId.Request_Entity_Export, param, callback, onError);
    }

    public static Task<object> Request_Entity_Export(EntityExportInfo param){     
      return Broker.CreateCommandWithArgAndReturn<EntityExportInfo,object>(CmdId.Request_Entity_Export, param);
    }
    [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
    public static Task<object> Request_Entity_SetName(IdPlayfieldName param, Action callback, Action<ErrorInfo> onError = null){     
      return Broker.CreateCommandWithArgAndReturn<IdPlayfieldName,object>(CmdId.Request_Entity_SetName, param, callback, onError);
    }

    public static Task<object> Request_Entity_SetName(IdPlayfieldName param){     
      return Broker.CreateCommandWithArgAndReturn<IdPlayfieldName,object>(CmdId.Request_Entity_SetName, param);
    }
    }

  public abstract partial class SimpleMod {
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<PlayfieldList> Request_Playfield_List( Action<PlayfieldList> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<object,PlayfieldList>(CmdId.Request_Playfield_List, null, callback, onError);
      }

      public Task<PlayfieldList> Request_Playfield_List(){     
        return Broker.CreateCommandWithArgAndReturn<object,PlayfieldList>(CmdId.Request_Playfield_List, null);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<PlayfieldStats> Request_Playfield_Stats(PString param, Action<PlayfieldStats> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<PString,PlayfieldStats>(CmdId.Request_Playfield_Stats, param, callback, onError);
      }

      public Task<PlayfieldStats> Request_Playfield_Stats(PString param){     
        return Broker.CreateCommandWithArgAndReturn<PString,PlayfieldStats>(CmdId.Request_Playfield_Stats, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<DediStats> Request_Dedi_Stats( Action<DediStats> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<object,DediStats>(CmdId.Request_Dedi_Stats, null, callback, onError);
      }

      public Task<DediStats> Request_Dedi_Stats(){     
        return Broker.CreateCommandWithArgAndReturn<object,DediStats>(CmdId.Request_Dedi_Stats, null);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<GlobalStructureList> Request_GlobalStructure_List( Action<GlobalStructureList> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<object,GlobalStructureList>(CmdId.Request_GlobalStructure_List, null, callback, onError);
      }

      public Task<GlobalStructureList> Request_GlobalStructure_List(){     
        return Broker.CreateCommandWithArgAndReturn<object,GlobalStructureList>(CmdId.Request_GlobalStructure_List, null);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_GlobalStructure_Update(PString param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<PString,object>(CmdId.Request_GlobalStructure_Update, param, callback, onError);
      }

      public Task<object> Request_GlobalStructure_Update(PString param){     
        return Broker.CreateCommandWithArgAndReturn<PString,object>(CmdId.Request_GlobalStructure_Update, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Structure_Touch(Id param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Structure_Touch, param, callback, onError);
      }

      public Task<object> Request_Structure_Touch(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Structure_Touch, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id param, Action<IdStructureBlockInfo> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, param, callback, onError);
      }

      public Task<IdStructureBlockInfo> Request_Structure_BlockStatistics(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,IdStructureBlockInfo>(CmdId.Request_Structure_BlockStatistics, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<PlayerInfo> Request_Player_Info(Id param, Action<PlayerInfo> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,PlayerInfo>(CmdId.Request_Player_Info, param, callback, onError);
      }

      public Task<PlayerInfo> Request_Player_Info(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,PlayerInfo>(CmdId.Request_Player_Info, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<IdList> Request_Player_List( Action<IdList> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<object,IdList>(CmdId.Request_Player_List, null, callback, onError);
      }

      public Task<IdList> Request_Player_List(){     
        return Broker.CreateCommandWithArgAndReturn<object,IdList>(CmdId.Request_Player_List, null);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<Inventory> Request_Player_GetInventory(Id param, Action<Inventory> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_GetInventory, param, callback, onError);
      }

      public Task<Inventory> Request_Player_GetInventory(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_GetInventory, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<Inventory> Request_Player_SetInventory(Id param, Action<Inventory> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_SetInventory, param, callback, onError);
      }

      public Task<Inventory> Request_Player_SetInventory(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_SetInventory, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Player_AddItem(IdItemStack param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdItemStack,object>(CmdId.Request_Player_AddItem, param, callback, onError);
      }

      public Task<object> Request_Player_AddItem(IdItemStack param){     
        return Broker.CreateCommandWithArgAndReturn<IdItemStack,object>(CmdId.Request_Player_AddItem, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<IdCredits> Request_Player_Credits(Id param, Action<IdCredits> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,IdCredits>(CmdId.Request_Player_Credits, param, callback, onError);
      }

      public Task<IdCredits> Request_Player_Credits(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,IdCredits>(CmdId.Request_Player_Credits, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<IdCredits> Request_Player_SetCredits(IdCredits param, Action<IdCredits> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdCredits,IdCredits>(CmdId.Request_Player_SetCredits, param, callback, onError);
      }

      public Task<IdCredits> Request_Player_SetCredits(IdCredits param){     
        return Broker.CreateCommandWithArgAndReturn<IdCredits,IdCredits>(CmdId.Request_Player_SetCredits, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<IdCredits> Request_Player_AddCredits(IdCredits param, Action<IdCredits> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdCredits,IdCredits>(CmdId.Request_Player_AddCredits, param, callback, onError);
      }

      public Task<IdCredits> Request_Player_AddCredits(IdCredits param){     
        return Broker.CreateCommandWithArgAndReturn<IdCredits,IdCredits>(CmdId.Request_Player_AddCredits, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Blueprint_Finish(Id param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Blueprint_Finish, param, callback, onError);
      }

      public Task<object> Request_Blueprint_Finish(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Blueprint_Finish, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Blueprint_Resources(BlueprintResources param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<BlueprintResources,object>(CmdId.Request_Blueprint_Resources, param, callback, onError);
      }

      public Task<object> Request_Blueprint_Resources(BlueprintResources param){     
        return Broker.CreateCommandWithArgAndReturn<BlueprintResources,object>(CmdId.Request_Blueprint_Resources, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdPlayfieldPositionRotation,object>(CmdId.Request_Player_ChangePlayerfield, param, callback, onError);
      }

      public Task<object> Request_Player_ChangePlayerfield(IdPlayfieldPositionRotation param){     
        return Broker.CreateCommandWithArgAndReturn<IdPlayfieldPositionRotation,object>(CmdId.Request_Player_ChangePlayerfield, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo param, Action<ItemExchangeInfo> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<ItemExchangeInfo,ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, param, callback, onError);
      }

      public Task<ItemExchangeInfo> Request_Player_ItemExchange(ItemExchangeInfo param){     
        return Broker.CreateCommandWithArgAndReturn<ItemExchangeInfo,ItemExchangeInfo>(CmdId.Request_Player_ItemExchange, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Player_SetPlayerInfo(PlayerInfoSet param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<PlayerInfoSet,object>(CmdId.Request_Player_SetPlayerInfo, param, callback, onError);
      }

      public Task<object> Request_Player_SetPlayerInfo(PlayerInfoSet param){     
        return Broker.CreateCommandWithArgAndReturn<PlayerInfoSet,object>(CmdId.Request_Player_SetPlayerInfo, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Entity_Teleport(IdPositionRotation param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdPositionRotation,object>(CmdId.Request_Entity_Teleport, param, callback, onError);
      }

      public Task<object> Request_Entity_Teleport(IdPositionRotation param){     
        return Broker.CreateCommandWithArgAndReturn<IdPositionRotation,object>(CmdId.Request_Entity_Teleport, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdPlayfieldPositionRotation,object>(CmdId.Request_Entity_ChangePlayfield, param, callback, onError);
      }

      public Task<object> Request_Entity_ChangePlayfield(IdPlayfieldPositionRotation param){     
        return Broker.CreateCommandWithArgAndReturn<IdPlayfieldPositionRotation,object>(CmdId.Request_Entity_ChangePlayfield, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Entity_Destroy(Id param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Entity_Destroy, param, callback, onError);
      }

      public Task<object> Request_Entity_Destroy(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,object>(CmdId.Request_Entity_Destroy, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<IdPositionRotation> Request_Entity_PosAndRot(Id param, Action<IdPositionRotation> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,IdPositionRotation>(CmdId.Request_Entity_PosAndRot, param, callback, onError);
      }

      public Task<IdPositionRotation> Request_Entity_PosAndRot(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,IdPositionRotation>(CmdId.Request_Entity_PosAndRot, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Entity_Spawn(EntitySpawnInfo param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<EntitySpawnInfo,object>(CmdId.Request_Entity_Spawn, param, callback, onError);
      }

      public Task<object> Request_Entity_Spawn(EntitySpawnInfo param){     
        return Broker.CreateCommandWithArgAndReturn<EntitySpawnInfo,object>(CmdId.Request_Entity_Spawn, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<FactionInfoList> Request_Get_Factions(Id param, Action<FactionInfoList> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,FactionInfoList>(CmdId.Request_Get_Factions, param, callback, onError);
      }

      public Task<FactionInfoList> Request_Get_Factions(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,FactionInfoList>(CmdId.Request_Get_Factions, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<Id> Request_NewEntityId( Action<Id> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<object,Id>(CmdId.Request_NewEntityId, null, callback, onError);
      }

      public Task<Id> Request_NewEntityId(){     
        return Broker.CreateCommandWithArgAndReturn<object,Id>(CmdId.Request_NewEntityId, null);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<AlliancesTable> Request_AlliancesAll( Action<AlliancesTable> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<object,AlliancesTable>(CmdId.Request_AlliancesAll, null, callback, onError);
      }

      public Task<AlliancesTable> Request_AlliancesAll(){     
        return Broker.CreateCommandWithArgAndReturn<object,AlliancesTable>(CmdId.Request_AlliancesAll, null);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction param, Action<AlliancesFaction> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<AlliancesFaction,AlliancesFaction>(CmdId.Request_AlliancesFaction, param, callback, onError);
      }

      public Task<AlliancesFaction> Request_AlliancesFaction(AlliancesFaction param){     
        return Broker.CreateCommandWithArgAndReturn<AlliancesFaction,AlliancesFaction>(CmdId.Request_AlliancesFaction, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Load_Playfield(PlayfieldLoad param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<PlayfieldLoad,object>(CmdId.Request_Load_Playfield, param, callback, onError);
      }

      public Task<object> Request_Load_Playfield(PlayfieldLoad param){     
        return Broker.CreateCommandWithArgAndReturn<PlayfieldLoad,object>(CmdId.Request_Load_Playfield, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_ConsoleCommand(PString param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<PString,object>(CmdId.Request_ConsoleCommand, param, callback, onError);
      }

      public Task<object> Request_ConsoleCommand(PString param){     
        return Broker.CreateCommandWithArgAndReturn<PString,object>(CmdId.Request_ConsoleCommand, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<IdList> Request_GetBannedPlayers( Action<IdList> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<object,IdList>(CmdId.Request_GetBannedPlayers, null, callback, onError);
      }

      public Task<IdList> Request_GetBannedPlayers(){     
        return Broker.CreateCommandWithArgAndReturn<object,IdList>(CmdId.Request_GetBannedPlayers, null);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_InGameMessage_SinglePlayer(IdMsgPrio param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_SinglePlayer, param, callback, onError);
      }

      public Task<object> Request_InGameMessage_SinglePlayer(IdMsgPrio param){     
        return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_SinglePlayer, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_InGameMessage_AllPlayers(IdMsgPrio param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_AllPlayers, param, callback, onError);
      }

      public Task<object> Request_InGameMessage_AllPlayers(IdMsgPrio param){     
        return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_AllPlayers, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_InGameMessage_Faction(IdMsgPrio param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_Faction, param, callback, onError);
      }

      public Task<object> Request_InGameMessage_Faction(IdMsgPrio param){     
        return Broker.CreateCommandWithArgAndReturn<IdMsgPrio,object>(CmdId.Request_InGameMessage_Faction, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData param, Action<IdAndIntValue> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<DialogBoxData,IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, param, callback, onError);
      }

      public Task<IdAndIntValue> Request_ShowDialog_SinglePlayer(DialogBoxData param){     
        return Broker.CreateCommandWithArgAndReturn<DialogBoxData,IdAndIntValue>(CmdId.Request_ShowDialog_SinglePlayer, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<Inventory> Request_Player_GetAndRemoveInventory(Id param, Action<Inventory> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_GetAndRemoveInventory, param, callback, onError);
      }

      public Task<Inventory> Request_Player_GetAndRemoveInventory(Id param){     
        return Broker.CreateCommandWithArgAndReturn<Id,Inventory>(CmdId.Request_Player_GetAndRemoveInventory, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString param, Action<PlayfieldEntityList> callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<PString,PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, param, callback, onError);
      }

      public Task<PlayfieldEntityList> Request_Playfield_Entity_List(PString param){     
        return Broker.CreateCommandWithArgAndReturn<PString,PlayfieldEntityList>(CmdId.Request_Playfield_Entity_List, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Entity_Destroy2(IdPlayfield param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdPlayfield,object>(CmdId.Request_Entity_Destroy2, param, callback, onError);
      }

      public Task<object> Request_Entity_Destroy2(IdPlayfield param){     
        return Broker.CreateCommandWithArgAndReturn<IdPlayfield,object>(CmdId.Request_Entity_Destroy2, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Entity_Export(EntityExportInfo param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<EntityExportInfo,object>(CmdId.Request_Entity_Export, param, callback, onError);
      }

      public Task<object> Request_Entity_Export(EntityExportInfo param){     
        return Broker.CreateCommandWithArgAndReturn<EntityExportInfo,object>(CmdId.Request_Entity_Export, param);
      }
        [ObsoleteAttribute("This method will soon be deprecated. Use the method without success callbacks instead")]
      public Task<object> Request_Entity_SetName(IdPlayfieldName param, Action callback, Action<ErrorInfo> onError = null){     
        return Broker.CreateCommandWithArgAndReturn<IdPlayfieldName,object>(CmdId.Request_Entity_SetName, param, callback, onError);
      }

      public Task<object> Request_Entity_SetName(IdPlayfieldName param){     
        return Broker.CreateCommandWithArgAndReturn<IdPlayfieldName,object>(CmdId.Request_Entity_SetName, param);
      }
        
  }
}

