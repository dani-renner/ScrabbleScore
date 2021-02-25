using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void ScrabbleConstructor_CreatesInstanceofScrabble_Scrabble()
    {
      Scrabble newScrabble = new Scrabble("ok");
      Assert.AreEqual(typeof(Scrabble),newScrabble.GetType());
    }
    
    [TestMethod]
    public void Points_ReturnsPoints_Int()
    {
      Scrabble newScrabble = new Scrabble("code");
      int points = newScrabble.Points();
      Assert.AreEqual(points,7);
    }
  }
}