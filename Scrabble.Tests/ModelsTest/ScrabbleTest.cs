using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Models.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void GetTest_ReturnWord()
    {
      ScrabbleScore score = new ScrabbleScore("hello");

      Assert.AreEqual("hello", score.GetWord());
    }

    [TestMethod]
    public void SplitWord_ReturnWord()
    {
      ScrabbleScore score = new ScrabbleScore("hello");

      Assert.AreEqual('h', score.SplitWord()[0]);
    }

    [TestMethod]
    public void AddScore_ReturnWord()
    {
      ScrabbleScore score = new ScrabbleScore("heLloWorld");

      Assert.AreEqual(17, score.AddScore());
    }

  }
}
