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
      Scrabble newScrabble = new Scrabble();
      Assert.AreEqual(typeof(Scrabble),newScrabble.GetType());
    }
  }
}