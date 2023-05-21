using System;
/// <author>
/// Daniel Boncica
/// version 2.0 
/// </author>
namespace ConsoleAppProject.App05
{//method to run game
    public class RPSGame
    {
        public void Run()
        {//declare variables
            string ans = "";
            int userWins = 0;
            int computerWins = 0;
            //display header
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("----------Welcome to RPS game----------");
            Console.WriteLine("---------Made By Marius Boncica---------");

            //create method to choose from options
            while (ans != "NO")
            {
                Console.WriteLine("Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");
                string[] choices = { "ROCK", "PAPER", "SCISSOR" };//create an array of words
                Random rnd = new Random();//create an object of random numbers
                int computerChoice = rnd.Next(0, 3);
                Console.WriteLine("Enter your choice:");
                string userChoice = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer: " + choices[computerChoice]);
                //method to calaculate the winner of the game
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
            //method to display winner messsage

            Console.WriteLine("User wins " + userWins + " times");
            Console.WriteLine("Computer wins " + computerWins + " times");
        }
    }
}
