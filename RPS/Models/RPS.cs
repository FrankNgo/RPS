using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
  public class Game
  {
    private string _playerOneInput;
    private string _playerTwoInput;
    private string _winner;

    public Game(string playerOneInput, string playerTwoInput)
    {
      _playerOneInput = playerOneInput;
      _playerTwoInput = playerTwoInput;
      _winner = "";
    }

    public string GetPlayerOneInput()
    {
      return _playerOneInput;
    }

    public string GetPlayerTwoInput()
    {
      return _playerTwoInput;
    }

    public void SetPlayerInput(string playerOneInput, string playerTwoInput)
    {
      _playerOneInput = playerOneInput;
      _playerTwoInput = playerTwoInput;
    }

    public string GetWinner()
    {
      return _winner;
    }

    public void GameWinner(string playerOneInput, string playerTwoInput)
    {
      if (playerOneInput == "paper" && playerTwoInput == "rock")
      {
         _winner = "Player1";
      }
      else if (playerOneInput == "rock" && playerTwoInput == "paper")
      {
        _winner = "Player2";
      }
      else if (playerOneInput == "rock" && playerTwoInput == "scissors")
      {
         _winner = "Player1";
      }
      else if (playerOneInput == "scissors" && playerTwoInput == "rock")
      {
         _winner = "Player2";
      }
      else if (playerOneInput == "scissors" && playerTwoInput == "paper")
      {
        _winner = "Player1";
      }
      else if (playerOneInput == "paper" && playerTwoInput == "scissors")
      {
        _winner = "Player2";
      }
      else
      {
         _winner = "Draw";
      }
    }
  }
}
