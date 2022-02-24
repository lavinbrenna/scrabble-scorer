using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("word");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void WordScore_ReturnsPoints_Int()
    {
      string uWord = "Teddy";
      Game newGame = new Game(uWord);
      int expectedPoints = 10;
      int wordScore = Game.WordScore(uWord);
      Assert.AreEqual(wordScore, expectedPoints);
    }
  }
}