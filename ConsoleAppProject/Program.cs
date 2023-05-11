﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Marius Boncica 01/2023
    /// </summary>
    public static class Program
    {
        public static DistanceConverter DistanceConverter
        {
            get => default;
            set
            {
            }
        }
        private static DistanceConverter converter = new DistanceConverter();
        private static BMICalculatorWeb calculator = new BMICalculatorWeb();
        private static StudentGrades student = new StudentGrades();
        private static NetworkApp posts = new NetworkApp();




        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2023! ");
            Console.WriteLine("        by Marius Daniel Boncica                                ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            string[] choices = { "Distance Converter", "BMI Calculator", "Student Marks", "Social Posts" };
            ConsoleHelper.SelectChoice(choices);
            Console.WriteLine("Please enter Application Choice!");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                converter.Run();
            }
            else if (choice == "2")
            {
                calculator.Run();
            }
            else if (choice == "3")
            {
                student.Run();
            }
            else if (choice == "4")
            {
                posts.DisplayMenu();
            }
            else
                Console.WriteLine("Invalid Choice");

        }
    }
}
