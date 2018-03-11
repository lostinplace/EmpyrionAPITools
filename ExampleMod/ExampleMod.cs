﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eleon.Modding;
using EmpyrionAPITools;
using EmpyrionAPIDefinitions;

namespace ExampleMod
{
  public class ExampleMod : SimpleMod
  {

    Random rnd = new Random();

    public override void Initialize(ModGameAPI dediAPI)
    {
      this.Update_Received += ExampleMod_Update_Received;
      this.Event_ChatMessage += ExampleMod_Event_HandleLottoChatMessage;
      this.Event_GameEvent += ExampleMod_Event_GameEvent;
      this.Event_Statistics += PlayerDied_Event_Statistics;
    }

    private void PlayerDied_Event_Statistics(StatisticsParam obj)
    {
      log("***************event statistics!!!");
      var container = StatisticsContainer.FromStatisticsParam(obj);

      switch (container)
      {
        case PlayerDiedStatistics deathStats:
          var msg = new IdMsgPrio
          {
            msg = $"Player {deathStats.PlayerId.id} was killed by {deathStats.KillerId.id}"
          };
          log(msg.msg);
          this.Request_InGameMessage_AllPlayers(msg);
          break;
        default:
          break;
      }
    }

    private void ExampleMod_Event_GameEvent(GameEventData obj)
    {
      log("*****************OMG it's a game event!!!");
      var eventMessage = new IdMsgPrio
      {
        msg = $@"A game event occured, name:{obj.Name}, type:{obj.Type}, eventType:{obj.EventType}"
      };

      this.Request_InGameMessage_AllPlayers(eventMessage);
    }

    private void ExampleMod_Event_HandleLottoChatMessage(ChatInfo obj)
    {
      log("lotto check");
      if (obj.msg != "lottery") return;

      this.Request_Player_List(list =>
      {
        var index = rnd.Next() % list.list.Count;
        var selectedId = list.list[index];

        var msgParam = new IdMsgPrio()
        {
          id = selectedId,
          msg = $"Congratulations!, You Won!"
        };

        this.Request_InGameMessage_SinglePlayer(msgParam, x=>log($"message 1 error: {x.errorType.ToString()}"));

        var rewardParam = new ItemExchangeInfo()
        {
          id = selectedId,
          buttonText = "ok",
          title = "test",
          desc = "testdesc",
          items = new ItemStack[] {
            new ItemStack()
            {
              id = 256,
              count = 1
            }
          }
        };

        this.Request_Player_ItemExchange(rewardParam, result =>
        {
          log($"itemechange result");
          if (result.items.Count() == 0) return;
          var tyParam = new IdMsgPrio()
          {
            id = selectedId,
            msg = $"Thanks for the gift!"
          };
          this.Request_InGameMessage_SinglePlayer(tyParam, x => log($"message 2 error: {x.errorType.ToString()}"));

        }, x => log($"itemexchange error: {x.errorType.ToString()}"));

      });
      
    }

    private void ExampleMod_Update_Received(ulong tick)
    {
      if ( tick % 10000 == 0)
      {
        var param = new IdMsgPrio()
        {
          msg = $"game tick is now {tick}, an auspicious number"
        };

        this.Request_InGameMessage_AllPlayers(param);
      }
    }
  }
}