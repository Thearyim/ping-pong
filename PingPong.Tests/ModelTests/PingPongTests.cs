using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void GetPingPongGame_NumberDivisibleByThree_True()
    {
      PingPong testPingPong = new PingPong();
      string[] expectedResult = new string[] {"1", "2", "ping"};
      string[] result = testPingPong.GetPingPongGame(3);
      CollectionAssert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void GetPingPong_NumberNotDivisibleByThree_False()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.GetPingPongGame(4));
    }

    [TestMethod]
    public void GetPingPongGame_NumberDivisibleByFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.GetPingPongGame(5));
    }

    [TestMethod]
    public void GetPingPong_NumberNotDivisibleByFive_False()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.GetPingPongGame(7));
    }

    [TestMethod]
    public void GetPingPongGame_NumberDivisibleByThreeAndFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.GetPingPongGame(15));
    }

    [TestMethod]
    public void GetPingPong_NumberNotDivisibleByThreeAndFive_False()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.GetPingPongGame(16));
    }
  }
}