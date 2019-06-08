using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleon.Modding;
using EmpyrionAPIDefinitions;

namespace EmpyrionAPITools
{

  public enum LogLevel
  {
    Debug = 4,
    Message = 3,
    Warn = 2,
    Error = 1,
    Silent = 0,
  }

  public static class Logger
  {

    public static Action<String> logFunction { get; set; }

    

    public static void log(string message, LogLevel aLevel=LogLevel.Debug)
    {
      log(()=>message, aLevel);
    }

    public static void log(System.Func<string> message, LogLevel aLevel=LogLevel.Debug)
    {
      if (logLevel >= aLevel)
        logFunction(message());
    }

    public static  LogLevel logLevel { get; set; }

    static Logger()
    {
      Logger.logLevel = LogLevel.Error;
    }

  }
}
