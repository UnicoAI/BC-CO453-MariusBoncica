using System;

namespace ConsoleAppProject.App05
{
    public class RPSGame
    {
        public void Run()
        {
            string ans = "";
            int userWins = 0;
            int computerWins = 0;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("----------Welcome to RPS game----------");
            Console.WriteLine("---------Made By Marius Boncica---------");

            while (ans != "NO")
            {
                Console.WriteLine("Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");
                string[] choices = { "ROCK", "PAPER", "SCISSOR" };
                Random rnd = new Random();
                int computerChoice = rnd.Next(0, 3);
                Console.WriteLine("Enter your choice:");
                string userChoice = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer: " + choices[computerChoice]);

                if (userChoice == "ROCK" && choices[computerChoice] == "SCISSOR" ||
                    userChoice == "PAPER" && choices[computerChoice] == "ROCK" ||
                    userChoice == "SCISSOR" && choices[computerChoice] == "PAPER")
                {
                    Console.WriteLine("User wins");
                    userWins++;
                }
                else if (userChoice == choices[computerChoice])
                {
                    Console.WriteLine("It's a tie!");
                }
                else
                {
                    Console.WriteLine("Computer wins");
                    computerWins++;
                }

                Console.WriteLine("Do you want to continue (YES/NO):");
                ans = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("User wins " + userWins + " times");
            Console.WriteLine("Computer wins " + computerWins + " times");
        }
    }
}
