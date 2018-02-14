using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;
using System.Collections.Generic;

namespace RPS.Tests
{
  [TestClass]
  public class RPSTest
  {
    [TestMethod]
    public void PlayerOneInput_OutputTest_True()
    {
      string _playerOneInput = "rock";
      Assert.AreEqual(_playerOneInput, "rock");
    }

    [TestMethod]
    public void PlayerOneInput_OutputTest_False()
    {
      string _playerOneInput = "rock";
      Assert.AreNotEqual(_playerOneInput, "paper");
    }

    [TestMethod]
    public void PlayerTwoInput_OutputTest_True()
    {
      string _playerTwoInput = "rock";
      Assert.AreEqual(_playerTwoInput, "rock");
    }

    [TestMethod]
    public void PlayerTwoInput_OutputTest_False()
    {
      string _playerTwoInput = "rock";
      Assert.AreNotEqual(_playerTwoInput, "paper");
    }

    [TestMethod]
    public void GameWinner_GetWinner_True()
    {
      //Arrange
      Game newGame = new Game("rock","paper");
      string testWinner = "";
      //Act
      string winner = newGame.GetWinner();
      //Assert
      Assert.AreEqual(winner,testWinner);
    }

    [TestMethod]
    public void GameWinner_RockAndPaper_Player1Win()
    {
      //Arrange
      Game newGame = new Game("paper","rock");
      string winner = "Player1";
      //Act
      newGame.GameWinner("paper","rock");
      //Assert
      Assert.AreEqual(winner, newGame.GetWinner());
    }

    [TestMethod]
    public void GameWinner_RockAndPaper_Player2Win()
    {
      //Arrange
      Game newGame = new Game("rock","paper");
      string winner = "Player2";
      //Act
      newGame.GameWinner("rock","paper");
      //Assert
      Assert.AreEqual(winner, newGame.GetWinner());
    }

    [TestMethod]
    public void GameWinner_ScissorsAndRock_Player1Win()
    {
      //Arrange
      Game newGame = new Game("rock","scissors");
      string winner = "Player1";
      //Act
      newGame.GameWinner("rock","scissors");
      //Assert
      Assert.AreEqual(winner,newGame.GetWinner());
    }

    [TestMethod]
    public void GameWinner_ScissorsAndRock_Player2Win()
    {
      //Arrange
      Game newGame = new Game("rock","scissors");
      string winner = "Player2";
      //Act
      newGame.GameWinner("scissors","rock");
      //Assert
      Assert.AreEqual(winner,newGame.GetWinner());
    }

    [TestMethod]
    public void GameWinner_ScissorsAndPaper_Player1Win()
    {
      //Arrange
      Game newGame = new Game("scissors","paper");
      string winner = "Player1";
      //Act
      newGame.GameWinner("scissors","paper");
      //Assert
      Assert.AreEqual(winner,newGame.GetWinner());
    }

    [TestMethod]
    public void GameWinner_ScissorsAndPaper_Player2Win()
    {
      //Arrange
      Game newGame = new Game("paper","scissors");
      string winner = "Player2";
      //Act
      newGame.GameWinner("paper","scissors");
      //Assert
      Assert.AreEqual(winner,newGame.GetWinner());
    }
  }
}
