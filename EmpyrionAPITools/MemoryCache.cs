using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EmpyrionAPITools
{
  class MemoryCache : Dictionary<String, object>
  {
    public MemoryCache(string Name) : base()
    {

    }

    internal void Add(string seqNrString, GenericAPICommand command, DateTime dateTime)
    {
      this[seqNrString] = command;
      var timeinMS = (dateTime - DateTime.Now).TotalMilliseconds;
      var expirationTimer = new Timer(timeinMS)
      {
        AutoReset = false
      };
      expirationTimer.Elapsed += (a, b) =>
      {
        object tmp;
        lock (this)
        {
          if (this.TryGetValue(seqNrString, out tmp) && tmp == command) this.Remove(seqNrString);
        }
        expirationTimer.Close();
      };
      expirationTimer.Start();
    }

    

    internal object Get(string seqNrString)
    {
      object tmp;
      lock (this)
      {
        if (this.TryGetValue(seqNrString, out tmp)) return tmp;
        else return null;
      }
    }

    internal bool Contains(string seqNrString) => this.ContainsKey(seqNrString);
  }
}
