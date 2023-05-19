using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using ConsoleAppProject.App05;


namespace ConsoleAppProject.Tests
{
    [TestClass]
    public class RPSGameTests
    {

        [TestMethod]
        public void TestRun()
        {
            RPSGame rPSGame = new RPSGame();
            {
                // Arrange
                string userChoice = "ROCK";
                string computerChoice = "SCISSOR";
                string continueAnswer = "NO";
                int userWins = 1;
                int computerWins = 0;

                using (StringWriter sw = new StringWriter())
                {
                    // Prepare input and output streams
                    Console.SetOut(sw);
                    Console.SetIn(new StringReader($"{userChoice}\n{continueAnswer}\n"));

                    // Act

                    string output = sw.ToString().Trim();

                    // Assert
                    Assert.IsTrue(output.Contains("User wins"));
                    Assert.IsTrue(output.Contains("User wins " + userWins + " times"));
                    Assert.IsTrue(output.Contains("Computer wins " + computerWins + " times"));
                }
            }
        }
    }
}

