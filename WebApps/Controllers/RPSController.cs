using Microsoft.AspNetCore.Mvc;
using System;


namespace WebApps.Controllers

{
    public class RPSController : Controller
    {
        [HttpGet]
        public ActionResult RPS()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RPS(string userChoice)
        {
            string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
            Random rnd = new Random();
            int n = rnd.Next(0, 3);
            string computerChoice = choices[n];
            string result = "";

            int userScore = int.Parse(ViewData["UserScore"] as string);
            int computerScore = int.Parse(ViewData["ComputerScore"] as string);

            if (userChoice == "ROCK" && computerChoice == "SCISSOR")
            {
                result = "You Win";
                userScore += 1;
            }
            else if (userChoice == "ROCK" && computerChoice == "PAPER")
            {
                result = "Computer Wins";
                computerScore += 1;
            }
            else if (userChoice == "PAPER" && computerChoice == "ROCK")
            {
                result = "You Win";
                userScore += 1;
            }
            else if (userChoice == "PAPER" && computerChoice == "SCISSOR")
            {
                result = "Computer Wins";
                computerScore += 1;
            }
            else if (userChoice == "SCISSOR" && computerChoice == "ROCK")
            {
                result = "Computer Wins";
                computerScore += 1;
            }
            else if (userChoice == "SCISSOR" && computerChoice == "PAPER")
            {
                result = "You Win";
                userScore += 1;
            }
            else
            {
                result = "Please enter a valid number";
            }

            ViewData["UserChoice"] = userChoice;
            ViewData["ComputerChoice"] = computerChoice;
            ViewData["Result"] = result;
            ViewData["UserScore"] = userScore.ToString();
            ViewData["ComputerScore"] = computerScore.ToString();

            return View();
        }
    }
}

