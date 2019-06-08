using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Eleon;
using Eleon.Modding;
using EmpyrionAPIDefinitions;
using MsgChannel = Eleon.Modding.MsgChannel;
using SenderType = Eleon.Modding.SenderType;

namespace EmpyrionAPITools
{
  public abstract partial class SimpleMod : ModInterface, IMod
  {

    protected List<ChatCommand> ChatCommands { get; set; } = new List<ChatCommand>();

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

    public abstract void Initialize(IModApi api, ModGameAPI legacyApi );

   
    /// <summary>
    /// Simple way to send a message to the specified player
    /// </summary>
    /// <param name="playerId"></param>
    /// <param name="message"></param>
    protected void MessagePlayer(int playerId, string message)
    {

      MessageData chatMsgData = new MessageData();
      chatMsgData.Channel = Eleon.MsgChannel.SinglePlayer;
      chatMsgData.Text = message;
      chatMsgData.RecipientEntityId = playerId;
      chatMsgData.SenderNameOverride = "Server";
      chatMsgData.SenderType = Eleon.SenderType.System;

      this.GameAPI.Application.SendChatMessage(chatMsgData);
    }

    protected void MessageAllPlayers(string message)
    {
      MessageData chatMsgData = new MessageData();
      chatMsgData.Channel = Eleon.MsgChannel.Global;
      chatMsgData.Text = message;
      chatMsgData.SenderNameOverride = "Server";
      chatMsgData.SenderType = Eleon.SenderType.System;

      this.GameAPI.Application.SendChatMessage(chatMsgData);
    }


    void ModInterface.Game_Event(CmdId eventId, ushort seqNr, object data)
    {
      Broker.HandleGameEvent(eventId, seqNr, data);
      API_Message_Received?.Invoke(eventId, seqNr, data);
    }

    void ModInterface.Game_Exit()
    {
      API_Exit?.Invoke();
    }

    void ModInterface.Game_Start(ModGameAPI dediAPI)
    {
      this.LegacyInitialized = true;
      if(dediAPI == null) return;
      this.LegacyAPI = dediAPI;
      Broker.api = this.LegacyAPI;
      
      
      RunInitialize();
    }

    private bool LegacyInitialized { get; set; } = false;
    private bool APIInitialized { get; set; } = false;

    private void RunInitialize()
    {
      if(LegacyInitialized && APIInitialized) this.Initialize(GameAPI, LegacyAPI);
    }

    private async void SimpleMod_ProcessChatCommands(MessageData data)
    {
      var match = ChatCommandManager.MatchCommand(data.Text);
      if (match == null) return;
      if (match.command.minimumPermissionLevel > EmpyrionAPIDefinitions.PermissionType.Player)
      {
        var player = await Broker.Request_Player_Info(data.SenderEntityId.ToId());
        if(player.permission < (int)match.command.minimumPermissionLevel) return;
        match.command.handler(data, match.parameters);
     
        return;
      }
      match.command.handler(data, match.parameters);
    }

    void ModInterface.Game_Update()
    {
      Update_Received?.Invoke(GameAPI.Application.GameTicks);
    }

    protected IModApi GameAPI { get; set; }
    protected ModGameAPI LegacyAPI { get; set; }

    void IMod.Init(IModApi modAPI)
    {
      this.APIInitialized = true;
      this.GameAPI = modAPI;

      Logger.logFunction = modAPI.Log;
      this.ChatCommandManager = new ChatCommandManager(this.ChatCommands);
      modAPI.Application.ChatMessageSent += SimpleMod_ProcessChatCommands;
      RunInitialize();
    }


    void IMod.Shutdown()
    {
      Logger.log("shutting down");
    }
  }
}
