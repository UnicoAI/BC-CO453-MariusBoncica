using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.App05;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// 
    /// Marius Boncica
    /// </summary>
    public static class Program
    {
        public static StudentGrades StudentGrades
        {
            get => default;
            set
            {
            }
        }

        public static RPSGame RPSGame
        {
            get => default;
            set
            {
            }
        }
        //Method to rn program
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("BNU CO453 Application Programming 2022-2023");
            Console.WriteLine("Created by Marius Boncica");
            Console.WriteLine();
            Menu();
        }
        //method to display choices
        public static void Menu() // Menu Navigation
        {
            Console.WriteLine("Please select a Program to Run:"); // User Prompt
            Console.WriteLine();
            Console.WriteLine("1. App01: Distance Converter"); // Distance Converter
            Console.WriteLine("2. App02: BMI Calculator"); // BMI Calculator
            Console.WriteLine("3. App03: Student Marks"); // Student Marks
            Console.WriteLine("4. App04: Social Network"); // Social Network
            Console.WriteLine("5. App05: RPS Game"); // RPS Game
            Console.WriteLine();
            Console.Write("Enter Program Number > ");
            string SelectedApp = Console.ReadLine(); // Read the User Input from the Console

            switch (SelectedApp) // Switch and Case Method for Option Selection
            {
                case "1": // App01: Distance Converter
                    Console.WriteLine("Loading App01: Distance Converter");
                    DistanceConverter converter = new DistanceConverter();
                    converter.Run();
                    break;
                case "2": // App02: BMI Calculator
                    Console.WriteLine("Loading App02: BMI Calculator");
                    BMICalculatorWeb calculator = new BMICalculatorWeb();
                    calculator.Run();
                    break;
                case "3": // App03: Student Marks
                    Console.WriteLine("Loading App03: Student Marks");
                    StudentGrades grades = new StudentGrades();
                    grades.Run();
                    break;
                case "4": // App04: Social Network
                    Console.WriteLine("Loading App04: Social Network");
                    NetworkApp network = new NetworkApp();
                    network.Run();
                    break;
                case "5": // App05: RPS Game
                    Console.WriteLine("Loading App05: RPS Game");
                    RPSGame rps = new RPSGame();
                    rps.Run();
                    // Run Function
                    break;
                default: // Invalid Input
                    Console.WriteLine("Invalid Input: Please specify an option from the list above");
                    // Run Function
                    break;
            }
        }
    }
}
