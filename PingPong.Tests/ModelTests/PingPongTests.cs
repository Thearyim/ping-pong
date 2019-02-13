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
      //Arrange
      PingPong testPingPong = new PingPong();

      //Act
      string[] expectedResult = new string[] {"1", "2", "ping"};
      string[] result = testPingPong.GetPingPongGame(3);
      
      //Assert
      CollectionAssert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void GetPingPongGame_NumberDivisibleByFive_True()
    {
      PingPong testPingPong = new PingPong();
      string[] expectedResult = new string[] {"1", "2", "ping", "4", "pong"};
      string[] result = testPingPong.GetPingPongGame(5);
      CollectionAssert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void GetPingPongGame_NumberDivisibleByThreeAndFive_True()
    {
      PingPong testPingPong = new PingPong();
      string[] expectedResult = new string[] {"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong"};
      string[] result = testPingPong.GetPingPongGame(15);
      CollectionAssert.AreEqual(expectedResult, result);
    }

  }
}