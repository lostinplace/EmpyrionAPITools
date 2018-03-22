using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmpyrionAPITools;
using System.Collections.Generic;
using System.Linq;
using Eleon.Modding;

namespace APIToolsTests
{
  [TestClass]
  public class ChatCommandManagerTests
  {

    ChatCommandManager ccm;
    List<ChatCommand> commandList;
    ChatCommand t1, t2;

    [TestInitialize]
    public void InitTest() {
      t1 = new ChatCommand("test", null);
      t2 = new ChatCommand("test2", null);
      commandList = commandList = new List<ChatCommand>()
      {
        t1,
        t2
      };
      ccm = new ChatCommandManager(commandList);
    }

    [TestMethod]
    public void TestSuperPatternCompilation()
    {    
      Assert.IsTrue(ccm.superPattern.pattern.IsMatch("test"));
      Assert.IsTrue(ccm.superPattern.pattern.IsMatch("test2"));
      Assert.IsFalse(ccm.superPattern.pattern.IsMatch("blah"));
    }

    [TestMethod]
    public void TestCommandMatching()
    {
      var cmd = ccm.MatchCommand("test2");
      Assert.AreSame(cmd.command, t2);
      var cmd2 = ccm.MatchCommand("bleh");
      Assert.IsNull(cmd2);
    }

    [TestMethod]
    public void testCommandWithArg()
    {
      var pattern = @"test (?<name>\S*) is (?<disposition>\S*)";
      var cc = new ChatCommand(pattern, (x, y) => { });
      commandList.Add(cc);
      ccm = new ChatCommandManager(commandList);

      var result = ccm.MatchCommand("test chris is good");
      Assert.AreSame(cc, result.command);

    }


  }
}
