
    using System;
    using System.Collections.Generic;

namespace WebApps.Models
{
    using System;


    public class RPSGame
    {
        public int UserWins { get; private set; }
        public int ComputerWins { get; private set; }
        public int Ties { get; private set; }
        public bool GameOver { get; private set; }
       public string userName { get; set; }
        public RPSGame()
        {
            GameOver = false;
            UserWins = 0;
            ComputerWins = 0;
            Ties = 0;
        }
        
        public void Play(string userChoice)
        {
           
            Console.ReadLine();
            string[] choices = new string[3] { "rock", "paper", "scissors" };
            Random rnd = new Random();
            int computerIndex = rnd.Next(0, 3);
            string computerChoice = choices[computerIndex];

            switch (userChoice)
            {
                case "rock":
                    if (computerChoice == "scissors")
                    {
                        UserWins++;
                    }
                    else if (computerChoice == "paper")
                    {
                        ComputerWins++;
                    }
                    else
                    {
                        Ties++;
                    }
                    break;
                case "paper":
                    if (computerChoice == "rock")
                    {
                        UserWins++;
                    }
                    else if (computerChoice == "scissors")
                    {
                        ComputerWins++;
                    }
                    else
                    {
                        Ties++;
                    }
                    break;
                case "scissors":
                    if (computerChoice == "paper")
                    {
                        UserWins++;
                    }
                    else if (computerChoice == "rock")
                    {
                        ComputerWins++;
                    }
                    else
                    {
                        Ties++;
                    }
                    break;
            }

            if (UserWins == 3 || ComputerWins == 3)
            {
                GameOver = true;
            }
        }
    }
}