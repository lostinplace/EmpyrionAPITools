using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eleon.Modding;

namespace EmpyrionAPITools
{
  public abstract partial class SimpleMod : ModInterface
  {
    public delegate void APIEventHandler(CmdId eventId, ushort seqNr, object data);

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event APIEventHandler API_Message_Received;

    public delegate void ExitEventHandler();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event ExitEventHandler API_Exit;

    public delegate void UpdateHandler(ulong tick);

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
    public event UpdateHandler Update_Received;

    public abstract void Initialize(ModGameAPI dediAPI);

    void ModInterface.Game_Event(CmdId eventId, ushort seqNr, object data)
    {
      Broker.HandleGameEvent(eventId, seqNr, data);
      API_Message_Received(eventId, seqNr, data);
    }

    void ModInterface.Game_Exit()
    {
      API_Exit();
    }

    void ModInterface.Game_Start(ModGameAPI dediAPI)
    {
      Broker.api = dediAPI;
      this.Initialize(dediAPI);
    }

    void ModInterface.Game_Update()
    {
      Update_Received(Broker.api.Game_GetTickTime());
    }
  }
}
