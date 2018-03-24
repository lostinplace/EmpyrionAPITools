using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Eleon.Modding;
using EmpyrionAPIDefinitions;

namespace EmpyrionAPITools
{
  public abstract partial class SimpleMod : ModInterface
  {

    protected List<ChatCommand> ChatCommands { get; set; } = new List<ChatCommand>();

    protected bool verbose
    {
      set
      {
        Broker.verbose = value;
      }
      get
      {
        return Broker.verbose;
      }
    }

    private ChatCommandManager ChatCommandManager;

    public delegate void APIEventHandler(CmdId eventId, ushort seqNr, object data);

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event APIEventHandler API_Message_Received;

    public delegate void ExitEventHandler();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event ExitEventHandler API_Exit;

    public delegate void UpdateHandler(ulong tick);

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event UpdateHandler Update_Received;


    protected List<ChatCommand> GetChatCommandsForPermissionLevel(PermissionType permission)
    {
      return this.ChatCommands.Where(x => x.minimumPermissionLevel <= permission).ToList();
    }

    public abstract void Initialize(ModGameAPI dediAPI);

    void ModInterface.Game_Event(CmdId eventId, ushort seqNr, object data)
    {
      Broker.HandleGameEvent(eventId, seqNr, data);
      if (eventId == CmdId.Event_ChatMessage) SimpleMod_ProcessChatCommands((ChatInfo)data);

      API_Message_Received?.Invoke(eventId, seqNr, data);
    }

    void ModInterface.Game_Exit()
    {
      API_Exit?.Invoke();
    }

    void ModInterface.Game_Start(ModGameAPI dediAPI)
    {
      Broker.api = dediAPI;
      this.Initialize(dediAPI);     
      
      this.ChatCommandManager = new ChatCommandManager(this.ChatCommands);
    }

    private void SimpleMod_ProcessChatCommands(ChatInfo obj)
    {
      var match = ChatCommandManager.MatchCommand(obj.msg);
      if (match == null) return;
      if (match.command.minimumPermissionLevel > EmpyrionAPIDefinitions.PermissionType.Player)
      {
        this.Request_Player_Info(obj.playerId.ToId(), (info) => {
          if (info.permission < (int)match.command.minimumPermissionLevel) return;
          match.command.handler(obj, match.parameters);
        });
        return;
      }
      match.command.handler(obj, match.parameters);
    }

    void ModInterface.Game_Update()
    {
      Update_Received?.Invoke(Broker.api.Game_GetTickTime());
    }

    public void log(string msg)
    {
      Broker.log(msg);
    }

    public void log(Func<string> msg)
    {
      Broker.log(msg);
    }
  }
}
