using Eleon.Modding;
using EmpyrionAPITools;

namespace ExampleMod
{
  class Example : SimpleMod
  {
    public override void Initialize(ModGameAPI dediAPI)
    {
      this.Event_Player_Connected += Example_Event_Player_Connected;
    }

    private void Example_Event_Player_Connected(Id obj)
    {
      var msg = new IdMsgPrio()
      {
        msg = $"player: {obj.id} has connected. Welcome!"
      };

      this.Request_InGameMessage_AllPlayers(msg);
    }
  }
}
