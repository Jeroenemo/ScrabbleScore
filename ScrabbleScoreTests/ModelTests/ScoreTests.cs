using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests : IDisposable
  {

    public void Dispose()
    {
      Score.ClearAll();
    }

    [TestMethod]

    public void ScoreConstuctor_CreatesInstanceOfScore_Score()
    {
      Score newScore = new Score();
      Assert.AreEqual(typeof(Score), newScore.GetType());
    }
    
  }
}