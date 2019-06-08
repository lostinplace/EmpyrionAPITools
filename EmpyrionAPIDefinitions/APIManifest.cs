using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eleon.Modding;

namespace EmpyrionAPIDefinitions
{
  public class APIEvent
  {
    public CmdId CmdId { get; set; }
    public Type ParamType { get; set; }

    public APIFeatureState FeatureState { get; set; } = APIFeatureState.Untested;

    public APIEvent(CmdId cmdId, Type paramType, APIFeatureState featureState = APIFeatureState.Untested)
    {
      this.CmdId = cmdId;
      this.ParamType = paramType;
      this.FeatureState = featureState;
    }
  }

  public enum APIFeatureState
  {
    Untested,
    TestedWorking,
    TestedNotWorking,
    Deprecated
  }

  public class TypeMatchValidator
  {
    public Type ParamType { get; private set; }
    public Type DataType { get; private set; }

    public Func<object, object, bool> validate { get; private set; }

    public TypeMatchValidator(Type ParamType, Type DataType, Func<object, object, bool> validator)
    {
      this.ParamType = ParamType;
      this.DataType = DataType;
      this.validate = validator;
    }
  }

  public class TypeMatchValidator<ParamType, DataType>
  {

    public Func<ParamType, DataType, bool> validate { get; private set; }

    public TypeMatchValidator(Func<ParamType, DataType, bool> validator) {
      this.validate = validator;
    }

    public TypeMatchValidator ToGeneric(){
      Func<object, object, bool> newValidator = (a, b) => validate((ParamType)a, (DataType)b);
      return new TypeMatchValidator(typeof(ParamType), typeof(DataType), newValidator);
    }
  }

  public class RequestMethodSignature
  {
    public string Name { get; set; }
    public Type ParamType { get; set; }
    public Type ResponseType { get; set; }

    public APIFeatureState FeatureState { get; set; }

    private static string getTypeName(Type aType) => aType == null ? "object" : aType.Name;

    public string ResponseTypeName { get => getTypeName(ResponseType); }
    public string RequestTypeName { get => getTypeName(ParamType); }

    public string ObsoleteSignature {
      get
      {
        var returnType = ResponseType == null ? "Task<object>" : $"Task<{ResponseTypeName}>";
        var argPart = ParamType == null ? "" : $"{RequestTypeName} param,";
        var callBackPart = ResponseType == null ? "Action callback," : $"Action<{ResponseTypeName}> callback,";
        return $"{returnType} {Name}({argPart} {callBackPart} Action<ErrorInfo> onError = null)";
      }
    }

    public string Signature
    {
      get
      {
        var returnType = ResponseType == null ? "Task<object>" : $"Task<{ResponseTypeName}>";
        var argPart = ParamType == null ? "" : $"{RequestTypeName} param";
        return $"{returnType} {Name}({argPart})";
      }
    }

    public string BrokerCall
    {
      get
      {
        var argPart = ParamType == null ? "null" : "param";
        return $"return Broker.CreateCommandWithArgAndReturn<{RequestTypeName},{ResponseTypeName}>(CmdId.{Name}, {argPart});";
      }
    }

    public string ObsoleteBrokerCall
    {
      get
      {
        var argPart = ParamType == null ? "null" : "param";
        return $"return Broker.CreateCommandWithArgAndReturn<{RequestTypeName},{ResponseTypeName}>(CmdId.{Name}, {argPart}, callback, onError);";
      }
    }
  }

  public class APIRequest
  {
    public CmdId CmdId { get; set; }
    public Type ParamType { get; set; }
    public CmdId ResponseCmdId { get; set; }

    public APIFeatureState FeatureState { get; set; } = APIFeatureState.Untested;

    public APIRequest(CmdId cmdId, Type paramType, CmdId responseCmdId, APIFeatureState featureState = APIFeatureState.Untested)
    {
      CmdId = cmdId;
      ParamType = paramType;
      ResponseCmdId = responseCmdId;
      FeatureState = featureState;
    }
  }

  public static class APIManifest
  {
    public static List<APIRequest> RequestManifest { get; private set; } = new List<APIRequest>()
    {
      new APIRequest(CmdId.Request_Playfield_List, null, CmdId.Event_Playfield_List),
      new APIRequest(CmdId.Request_Playfield_Stats, typeof(PString), CmdId.Event_Playfield_Stats),
      new APIRequest(CmdId.Request_Dedi_Stats, null, CmdId.Event_Dedi_Stats),
      new APIRequest(CmdId.Request_GlobalStructure_List, null, CmdId.Event_GlobalStructure_List),
      new APIRequest(CmdId.Request_GlobalStructure_Update, typeof(PString), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Structure_Touch, typeof(Id), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Structure_BlockStatistics, typeof(Id), CmdId.Event_Structure_BlockStatistics),
      new APIRequest(CmdId.Request_Player_Info, typeof(Id), CmdId.Event_Player_Info),
      new APIRequest(CmdId.Request_Player_List, null, CmdId.Event_Player_List),
      new APIRequest(CmdId.Request_Player_GetInventory, typeof(Id), CmdId.Event_Player_Inventory),
      new APIRequest(CmdId.Request_Player_SetInventory, typeof(Id), CmdId.Event_Player_Inventory),
      new APIRequest(CmdId.Request_Player_AddItem, typeof(IdItemStack), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Player_Credits, typeof(Id), CmdId.Event_Player_Credits),
      new APIRequest(CmdId.Request_Player_SetCredits, typeof(IdCredits), CmdId.Event_Player_Credits),
      new APIRequest(CmdId.Request_Player_AddCredits, typeof(IdCredits), CmdId.Event_Player_Credits),
      new APIRequest(CmdId.Request_Blueprint_Finish, typeof(Id), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Blueprint_Resources, typeof(BlueprintResources), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Player_ChangePlayerfield, typeof(IdPlayfieldPositionRotation), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Player_ItemExchange, typeof(ItemExchangeInfo), CmdId.Event_Player_ItemExchange),
      new APIRequest(CmdId.Request_Player_SetPlayerInfo, typeof(PlayerInfoSet), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_Teleport, typeof(IdPositionRotation), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_ChangePlayfield, typeof(IdPlayfieldPositionRotation), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_Destroy, typeof(Id), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_PosAndRot, typeof(Id), CmdId.Event_Entity_PosAndRot),
      new APIRequest(CmdId.Request_Entity_Spawn, typeof(EntitySpawnInfo), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Get_Factions, typeof(Id), CmdId.Event_Get_Factions),
      new APIRequest(CmdId.Request_NewEntityId, null, CmdId.Event_NewEntityId),
      new APIRequest(CmdId.Request_AlliancesAll, null, CmdId.Event_AlliancesAll),
      new APIRequest(CmdId.Request_AlliancesFaction, typeof(AlliancesFaction), CmdId.Event_AlliancesFaction),
      new APIRequest(CmdId.Request_Load_Playfield, typeof(PlayfieldLoad), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_ConsoleCommand, typeof(PString), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_GetBannedPlayers, null, CmdId.Event_BannedPlayers),
      new APIRequest(CmdId.Request_InGameMessage_SinglePlayer, typeof(IdMsgPrio), CmdId.Event_Ok, APIFeatureState.Deprecated),
      new APIRequest(CmdId.Request_InGameMessage_AllPlayers, typeof(IdMsgPrio), CmdId.Event_Ok, APIFeatureState.Deprecated),
      new APIRequest(CmdId.Request_InGameMessage_Faction, typeof(IdMsgPrio), CmdId.Event_Ok, APIFeatureState.Deprecated),
      new APIRequest(CmdId.Request_ShowDialog_SinglePlayer, typeof(DialogBoxData), CmdId.Event_DialogButtonIndex),
      new APIRequest(CmdId.Request_Player_GetAndRemoveInventory, typeof(Id), CmdId.Event_Player_GetAndRemoveInventory),
      new APIRequest(CmdId.Request_Playfield_Entity_List, typeof(PString), CmdId.Event_Playfield_Entity_List),
      new APIRequest(CmdId.Request_Entity_Destroy2, typeof(IdPlayfield), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_Export, typeof(EntityExportInfo), CmdId.Event_Ok),
      new APIRequest(CmdId.Request_Entity_SetName, typeof(IdPlayfieldName), CmdId.Event_Ok),
    };

    public static List<APIEvent> EventManifest { get; private set; } = new List<APIEvent>()
    {
      new APIEvent(CmdId.Event_Playfield_Loaded, typeof(PlayfieldLoad)),
      new APIEvent(CmdId.Event_Playfield_Unloaded, typeof(PlayfieldLoad)),
      new APIEvent(CmdId.Event_Player_Connected, typeof(Id)),
      new APIEvent(CmdId.Event_Player_Disconnected, typeof(Id)),
      new APIEvent(CmdId.Event_Player_ChangedPlayfield, typeof(IdPlayfield)),
      new APIEvent(CmdId.Event_Player_DisconnectedWaiting, typeof(Id)),
      new APIEvent(CmdId.Event_Faction_Changed, typeof(FactionChangeInfo)),
      new APIEvent(CmdId.Event_Statistics, typeof(StatisticsParam)),
      new APIEvent(CmdId.Event_ChatMessage, typeof(ChatInfo), APIFeatureState.Deprecated),
      new APIEvent(CmdId.Event_TraderNPCItemSold, typeof(TraderNPCItemSoldInfo)),
      new APIEvent(CmdId.Event_ConsoleCommand, typeof(ConsoleCommandInfo)),
      new APIEvent(CmdId.Event_PdaStateChange, typeof(PdaStateInfo)),
      new APIEvent(CmdId.Event_GameEvent, typeof(GameEventData), APIFeatureState.Deprecated),
      new APIEvent(CmdId.Event_AlliancesAll, typeof(AlliancesTable)),
      new APIEvent(CmdId.Event_AlliancesFaction, typeof(AlliancesFaction)),
      new APIEvent(CmdId.Event_BannedPlayers, typeof(IdList)),
      new APIEvent(CmdId.Event_Dedi_Stats, typeof(DediStats)),
      new APIEvent(CmdId.Event_Entity_PosAndRot, typeof(IdPositionRotation)),
      new APIEvent(CmdId.Event_Get_Factions, typeof(FactionInfoList)),
      new APIEvent(CmdId.Event_GlobalStructure_List, typeof(GlobalStructureList)),
      new APIEvent(CmdId.Event_NewEntityId, typeof(Id)),
      new APIEvent(CmdId.Event_Ok, null),
      new APIEvent(CmdId.Event_Player_Credits, typeof(IdCredits)),
      new APIEvent(CmdId.Event_Player_GetAndRemoveInventory, typeof(Inventory)),
      new APIEvent(CmdId.Event_Player_Info, typeof(PlayerInfo)),
      new APIEvent(CmdId.Event_Player_Inventory, typeof(Inventory)),
      new APIEvent(CmdId.Event_Player_ItemExchange, typeof(ItemExchangeInfo)),
      new APIEvent(CmdId.Event_Player_List, typeof(IdList)),
      new APIEvent(CmdId.Event_Playfield_Entity_List, typeof(PlayfieldEntityList)),
      new APIEvent(CmdId.Event_Playfield_List, typeof(PlayfieldList)),
      new APIEvent(CmdId.Event_Playfield_Stats, typeof(PlayfieldStats)),
      new APIEvent(CmdId.Event_Structure_BlockStatistics, typeof(IdStructureBlockInfo)),
      new APIEvent(CmdId.Event_DialogButtonIndex, typeof(IdAndIntValue)),
      new APIEvent(CmdId.Event_ChatMessageEx, typeof(ChatMsgData), APIFeatureState.Deprecated),
    };

    public static List<TypeMatchValidator> validators { get; private set; } = new List<EmpyrionAPIDefinitions.TypeMatchValidator>()
    {
      new TypeMatchValidator<PString, PlayfieldStats>((a,b)=>a.pstr == b.playfield).ToGeneric(),
      new TypeMatchValidator<Id, IdStructureBlockInfo>((a,b)=>a.id == b.id).ToGeneric(),
      new TypeMatchValidator<Id, PlayerInfo>((a,b)=>a.id == b.entityId).ToGeneric(),
      new TypeMatchValidator<Id, Inventory>((a,b)=>a.id == b.playerId).ToGeneric(),
      new TypeMatchValidator<Id, IdCredits>((a,b)=>a.id == b.id).ToGeneric(),
      new TypeMatchValidator<IdCredits, IdCredits>((a,b)=>a.id == b.id).ToGeneric(),
      new TypeMatchValidator<ItemExchangeInfo, ItemExchangeInfo>((a,b)=>a.id == b.id).ToGeneric(),
      new TypeMatchValidator<Id, IdPositionRotation>((a,b)=>a.id == b.id).ToGeneric(),
      new TypeMatchValidator<AlliancesFaction, AlliancesFaction>((a,b)=>a.faction1Id == b.faction1Id && a.faction2Id == b.faction2Id).ToGeneric(),
      new TypeMatchValidator<DialogBoxData, IdAndIntValue>((a,b)=>a.Id == b.Id).ToGeneric(),
      new TypeMatchValidator<PString, PlayfieldEntityList>((a,b)=>a.pstr == b.playfield).ToGeneric(),
    };

    public static TypeMatchValidator getResponseValidatorForRequest(CmdId requestId)
    {
      var request = APIRequestTable[requestId];
      var response = APIRequestResponseTable[requestId];
      var validator = validators.FirstOrDefault(x => x.ParamType == request.ParamType && x.DataType == response.ParamType);
      return validator;
    }
    
    public static Dictionary<CmdId, APIEvent> APIEventTable { get; private set; } = EventManifest.ToDictionary(x => x.CmdId);
    public static Dictionary<CmdId, APIRequest> APIRequestTable { get; private set; } = RequestManifest.ToDictionary(x => x.CmdId);
    
    public static Dictionary<CmdId, APIEvent> APIRequestResponseTable { get; private set; } = RequestManifest
      .Select(x => new KeyValuePair<CmdId, APIEvent>(x.CmdId, APIEventTable[x.ResponseCmdId]))
      .ToDictionary(x=>x.Key, x=>x.Value);

    public static Dictionary<CmdId, TypeMatchValidator> RequestResponseValidators { get; private set; } = RequestManifest.Select(x => (x.CmdId, getResponseValidatorForRequest(x.CmdId))).ToDictionary(x => x.Item1, x => x.Item2);

    public static List<RequestMethodSignature> RequestMethodSignatures { get; private set; } = RequestManifest.Select(request =>
    {
      var response = APIRequestResponseTable[request.CmdId];
      return new RequestMethodSignature()
      {
        Name = request.CmdId.ToString(),
        ParamType = request.ParamType,
        ResponseType = response.ParamType,
        FeatureState = request.FeatureState
      };
    }).ToList();


  }
}
