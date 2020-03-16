using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using Eleon;
using Eleon.Modding;
using EmpyrionAPITools;
using EmpyrionAPIDefinitions;
using MsgChannel = Eleon.MsgChannel;
using SenderType = Eleon.SenderType;

namespace ExampleMod
{
  public class ExampleMod : SimpleMod
  {
    private Random RNG { get; } = new Random();

    
    public override void Initialize(IModApi modAPI, ModGameAPI legacyAPI)
    {
      Logger.logLevel = LogLevel.Debug;

      this.Update_Received += ExampleMod_Update_Received;
      modAPI.Application.ChatMessageSent += ExampleMod_Event_HandleLottoChatMessage;

      Broker.Event_GameEvent += ExampleMod_Event_GameEvent;

      modAPI.GameEvent += ModAPI_GameEvent;
      Broker.Event_Statistics += PlayerDied_Event_Statistics;

      this.ChatCommands.Add(new ChatCommand(@"!repeat (?<repeat>\S+)", ChatCommand_TestMessage));
      this.ChatCommands.Add(new ChatCommand(@"!loudly (?<yellthis>.+)", (data, args) => {

        var msg = new MessageData()
        {
          Channel = MsgChannel.Global,
          Text = $"{args["yellthis"].ToUpper()}!!!!!",
          SenderType = SenderType.System
          

        };
        this.GameAPI.Application.SendChatMessage(msg);
      }));

      this.ChatCommands.Add(new ChatCommand(@"!explosion", async (data, __) => {
        var dialogData = new DialogBoxData()
        {
          Id = data.SenderEntityId,
          MsgText = "BOOM!",
          PosButtonText = "yes",
          NegButtonText = "No"
        };
        var result = await Broker.Request_ShowDialog_SinglePlayer(dialogData);
        
        var resultInterpreted = result.Value == 0 ? "YES": "NO";
        MessagePlayer(data.SenderEntityId, resultInterpreted);

      }, "blows it up", PermissionType.Moderator));
      
      var t = new System.Timers.Timer(15000);
      
      t.Elapsed += T_Elapsed;
      Debugger.Break();
      
      t.Start();

      this.ChatCommands.Add(new ChatCommand(@"!help", async (data, __) =>
      {
        var info = await Broker.Request_Player_Info(data.SenderEntityId.ToId());

        var playerPermissionLevel = (PermissionType)info.permission;
        var header = $"Commands available to {info.playerName}; permission level {playerPermissionLevel}\n";

        var lines = this.GetChatCommandsForPermissionLevel(playerPermissionLevel)
          .Select(x => x.ToString())
          .OrderBy(x => x.Length).ToList();

        lines.Insert(0, header);

        var dialogData = new DialogBoxData()
        {
          Id = data.SenderEntityId,
          MsgText = String.Join("\n", lines.ToArray())
        };

        Broker.Request_ShowDialog_SinglePlayer(dialogData);

      }));

      Logger.log("example mod init complete");
    }

    private void ModAPI_GameEvent(GameEventType type, object arg1 = null, object arg2 = null, object arg3 = null, object arg4 = null, object arg5 = null)
    {
      
      Logger.log("***game_event***");
    }

    private int entityId { get; set; } = 0;

    private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
      if(this.GameAPI.ClientPlayfield == null) return;
      var player = this.GameAPI.ClientPlayfield.Players.Values.FirstOrDefault(x => true);
      if(player == null) return;

      this.GameAPI.ClientPlayfield.Entities.Values.GroupBy(x=>x.Type.ToString()).Select(x=>new
      {
        group = x.Key,
        count = x.Count(),
        pos = x.OrderBy(y=>(player.Position - y.Position ).magnitude).First().Position
      }).ToList().ForEach(x=>MessageAllPlayers($"{x.group}: {x.count}, pos: {x.pos.x}, {x.pos.y}, {x.pos.z}"));
    }

    private void ChatCommand_TestMessage(MessageData data, Dictionary<string, string> args)
    {
      var repeating = args["repeat"];
      MessagePlayer(data.SenderEntityId, $"{repeating} {repeating} {repeating}!");
    }

    private void PlayerDied_Event_Statistics(StatisticsParam obj)
    {
      Logger.log("***************event statistics!!!");
      var container = StatisticsContainer.FromStatisticsParam(obj);
      
      switch (container)
      {
        case PlayerDiedStatistics deathStats:
          var msg = $"Player {deathStats.PlayerId.id} was killed by {deathStats.KillerId.id}";
          
          Logger.log(msg, LogLevel.Message);
          MessageAllPlayers(msg);
          break;
        default:
          break;
      }
    }

    private void ExampleMod_Event_GameEvent(GameEventData obj)
    {
      Logger.log("*****************OMG it's a game event!!!");
      var eventMessage = $@"A game event occured, name:{obj.Name}, type:{obj.Type}, eventType:{obj.EventType}";
      
      MessageAllPlayers(eventMessage);
    }

    private async void ExampleMod_Event_HandleLottoChatMessage(MessageData obj)
    {
      Logger.log("lotto check");
      if (obj.Text != "lottery") return;

      var list = await Broker.Request_Player_List();
      var index = RNG.Next() % list.list.Count;
      var selectedId = list.list[index];

      var msgParam = new IdMsgPrio()
      {
        id = selectedId,
        msg = $"Congratulations!, You Won!"
      };

      var rewardParam = new ItemExchangeInfo()
      {
        id = selectedId,
        buttonText = "ok",
        title = "test",
        desc = "testdesc",
        items = new ItemStack[]
        {
          new ItemStack()
          {
            id = 256,
            count = 1
          }
        }
      };

      try
      {
        var result = await Broker.Request_Player_ItemExchange(rewardParam);
        if (result.items.Any()) return;

        MessagePlayer(selectedId, $"Thanks for the gift!");
        
      } catch(EmpyrionAPIException ex)
      {
        Logger.log($"itemexchange error: {ex.info.ToString()}");
      }
    }

    private void ExampleMod_Update_Received(ulong tick)
    {
      if ( tick % 10000 == 0)
      {
        var msg = $"game tick is now {tick}, an auspicious number";
        MessageAllPlayers(msg);
      }
    }
  }
}
