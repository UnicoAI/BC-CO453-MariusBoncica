using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using ConsoleAppProject.App05;
/// <summary>
/// Test Unit For RPS Game

/// Author: Marius Boncica
/// </summary>

namespace ConsoleAppProject.Tests
{
    [TestClass]
    public class RPSGameTests
    {
        //method to test rps game
        [TestMethod]
        public void TestRun()
        {
            RPSGame rPSGame = new RPSGame();
            {
                // Arrange
                //define user choice and int for user winning and computer wininig counts
                string userChoice = "ROCK";
                
                string continueAnswer = "NO";
                int userWins = 1;
                int computerWins = 0;

                using StringWriter sw = new StringWriter();
                // Prepare input and output streams
                Console.SetOut(sw);
                Console.SetIn(new StringReader($"{userChoice}\n{continueAnswer}\n"));

                // Act

                string output = sw.ToString().Trim();

                // Assert
                Assert.IsFalse(output.Contains("User wins"));
                Assert.IsFalse(output.Contains("User wins " + userWins + " times"));
                Assert.IsFalse(output.Contains("Computer wins " + computerWins + " times"));
            }
        }
    }
}

