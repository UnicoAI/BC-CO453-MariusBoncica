using Microsoft.AspNetCore.Mvc;
using System;
//<author>Marius Boncica
//</author>
//<summary>
//version 1.0
//</summary>
namespace WebApps.Controllers
{
    public class RPSController : Controller
    {
        [HttpGet]
        public ActionResult RPS()
        {
            return View();//return view index
        }

        [HttpPost]
        //post string of choices and use random for computer choice
        public ActionResult RPS(string userChoice, string username)
        {
            string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
            Random rnd = new Random();
            int n = rnd.Next(0, 3);
            string computerChoice = choices[n];
            string result = "";

            int userScore = 0;
            int computerScore = 0;
            int counts = 1;
            //calculate winner base on matching choices possibilities using if 
            if (ViewData["UserScore"] != null && ViewData["UserScore"] is string userScoreString && int.TryParse(userScoreString, out int parsedUserScore))
            {
                userScore = parsedUserScore;
            }

            if (ViewData["ComputerScore"] != null && ViewData["ComputerScore"] is string computerScoreString && int.TryParse(computerScoreString, out int parsedComputerScore))
            {
                computerScore = parsedComputerScore;
            }

            if (userChoice == "ROCK" && computerChoice == "SCISSOR")
            {
                result = "You Win";
                userScore += 1;
                counts -= 1;
            }
            else if (userChoice == "ROCK" && computerChoice == "PAPER")
            {
                result = "Bad Luck Computer Wins";
                computerScore += 1;
                counts -= 1;
            }
            else if (userChoice == "PAPER" && computerChoice == "ROCK")
            {
                result = "You Win";
                userScore += 1;
                counts -= 1;
            }
            else if (userChoice == "PAPER" && computerChoice == "SCISSOR")
            {
                result = "Bad Luck Computer Wins";
                computerScore += 1;
                counts -= 1;
            }
            else if (userChoice == "SCISSOR" && computerChoice == "ROCK")
            {
                result = "Bad Luck Computer Wins";
                computerScore += 1;
                counts -= 1;
            }
            else if (userChoice == "SCISSOR" && computerChoice == "PAPER")
            {
                result = "You Win";
                userScore += 1;
                counts -= 1;
            }
         
            else if (counts == 0 && userScore > computerScore)
            {
                result = "You Win";
            }
            else if (counts == 0 && userScore < computerScore)
            {
                result = "You Lost This Time";
            }
            else
            {
                result = "It is a tie. Try Again";
            }
            //display data in cshtml
            ViewData["UserChoice"] = userChoice;
            ViewData["ComputerChoice"] = computerChoice;
            ViewData["Result"] = result;
            ViewData["UserScore"] = userScore.ToString();
            ViewData["ComputerScore"] = computerScore.ToString();
            ViewData["Counts"] = counts.ToString();
            ViewData["Username"] = username;

            return View();
        }
    }
}
