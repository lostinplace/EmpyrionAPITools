using Eleon.Modding;
using EmpyrionAPIDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpyrionAPITools
{
  public static class Extensions
  {

    /// <summary>
    /// Quickly creates an Eleon Id from an Integer
    /// </summary>
    /// <param name="anId"></param>
    /// <returns></returns>
    public static Id ToId(this int anId)
    {
      return new Id(anId);
    }

    /// <summary>
    /// Creates an IdMsgPrio for a string with optional parameters
    /// </summary>
    /// <param name="msg">the message to be sent</param>
    /// <param name="id">the id of the player to send it to</param>
    /// <param name="prio">the urgency of the message</param>
    /// <param name="duration">how long the message should remain visible</param>
    /// <returns>The fully formed IdMsgPrio</returns>
    public static IdMsgPrio ToIdMsgPrio(this string msg, int id, MessagePriorityType prio = MessagePriorityType.Alarm, float duration = 3.0F)
    {
      return new IdMsgPrio()
      {
        id = id,
        msg = msg,
        prio = (byte)prio,
        time = duration
      };
    }
  }
}
