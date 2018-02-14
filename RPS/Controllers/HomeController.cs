using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using RPS.Models;

namespace RPS.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/Result")]
    public ActionResult Result()
    {
        string player1 = Request.Form["player1Guess"];
        string player2 = Request.Form["player2Guess"];

        Game newGame = new Game(player1, player2);
        newGame.GameWinner(player1, player2);
        string winner = newGame.GetWinner();
        return View("Index", winner);
    }


  }
}
