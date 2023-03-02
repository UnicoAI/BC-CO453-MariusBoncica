using ConsoleAppProject.Helpers;
using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This program calculates a user's BMI (Body Mass Index) from their Weight and Height, it then assigns a Weight Status Category derived from the World Health Organisation.
    /// </summary>
    /// <author>
    /// Marius Boncica Version 1.0
    /// </author>
    public class BMICalculator
    {
        // Variables
        public double Bmi { get; set; }

        // Metric
        public double Kilograms { get; set; }
        public int Centimetres { get; set; }
        private double metres;

        // Imperial
        public int Pounds { get; set; }
        public int Inches { get; set; }

        // Constants
        public const double Underweight = 0.00;
        public const double Normal = 18.50;
        public const double Overweight = 25.00;
        public const double ObeseClass1 = 30.00;
        public const double ObeseClass2 = 35.00;
        public const double ObeseClass3 = 40.00;


        // Enumerations
        public MeasurementSystems Unit { get; set; } // Measurement System to use (Metric or Imperial)

        /// <summary>
        /// Runs the required functions in the correct order, allowing for the program to operate correctly.
        /// </summary>
        public void Run()
        {
            SelectUnit();
        }

        public MeasurementSystems SelectUnit(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine();

            Console.WriteLine($" 1. {MeasurementSystems.Metric}");
            Console.WriteLine($" 2. {MeasurementSystems.Imperial}");
            Console.WriteLine();

            Console.Write(prompt);

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Console.WriteLine($"Using: {MeasurementSystems.Metric}");
                return MeasurementSystems.Metric;
            }

            else if (choice == "2")
            {
                Console.WriteLine($"Using: {MeasurementSystems.Imperial}");
                return MeasurementSystems.Imperial;
            }
            else
            {
                Console.WriteLine("ERROR: Input Invalid");
                return MeasurementSystems.NoUnit;
            }
        }
        /// <summary>
        /// Determines which Measurement System to use based on the User Selection
        /// </summary>
        public void SelectUnit()
        {
            Unit = SelectUnit("Enter Measurement System to use > ");

            if (Unit == MeasurementSystems.Metric)
            {
                CalculateMetric();
            }
            else if (Unit == MeasurementSystems.Imperial)
            {
                CalculateImperial();
            }
            else
            {
                Console.WriteLine("ERROR: Please select a valid unit");
            }
        }
        /// <summary>
        /// Calculates the Weight Status using Metric System from user inputted Weight and Height measurements
        /// </summary>
        public void CalculateMetric()
        {
            Centimetres = (int)ConsoleHelper.InputNumber("Enter Height in Centimetres > ");
            Kilograms = ConsoleHelper.InputNumber("Enter Weight in Kg > ");
            metres = (double)Centimetres / 100;
            Bmi = Kilograms / (metres * metres);
            GetHealthMessage();
        }

        /// <summary>
        /// Calculates the Weight Status using Imperial System from user inputted Weight and Height measurements
        /// </summary>
        public void CalculateImperial()
        {
            Console.WriteLine("Enter your Height in Feet and Inches");
            Inches = (int)ConsoleHelper.InputNumber("Enter Height in Inches > ");
            Pounds = (int)ConsoleHelper.InputNumber("Enter Weight in Pounds > ");
            Bmi = (double)Pounds * 703 / (Inches * Inches);
            GetHealthMessage();
        }

        /// <summary>
        /// Outputs the Health Message based on the Users BMI.
        /// </summary>
        public void GetHealthMessage()
        {
            OutputHeading();
            if (Bmi < Underweight) // Underweight Range
            {
                Console.WriteLine($"Your BMI is {Bmi:0.00}, " + $"You are in the Underweight BMI Range.");
            }

            else if (Bmi <= Normal) // Normal Range
            {
                Console.WriteLine($"Your BMI is {Bmi:0.00}, " + $"You are in the Normal BMI Range.");
            }

            else if (Bmi <= Overweight) // Overweight Range
            {
                Console.WriteLine($"Your BMI is {Bmi:0.00}, " + $"You are in the Overweight BMI Range.");
            }

            else if (Bmi <= ObeseClass1) // Obese (Class I) Range
            {
                Console.WriteLine($"Your BMI is {Bmi:0.00}, " + $"You are in the Obese (Class I) BMI Range.");
            }

            else if (Bmi <= ObeseClass2) // Obese (Class II) Range
            {
                Console.WriteLine($"Your BMI is {Bmi:0.00}, " + $"You are in the Obese (Class II) BMI Range.");
            }

            else if (Bmi <= ObeseClass3) // Obese (Class III) Range
            {
                Console.WriteLine($"Your BMI is {Bmi:0.00}, " + $"You are in the Obese Class (III) BMI Range.");
            }
            OutputBameDisclosure();
        }

        /// <summary>
        /// Outputs a Disclosure for BAME Groups.
        /// </summary>
        public void OutputBameDisclosure()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("        BAME Notice        ");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("Notice:");
            Console.WriteLine();
            Console.WriteLine("If you belong to a BAME Ethnicity Group, the BMI Calculator could\nunderestimate or overestimate weight-related health risks.\nYou should contact your GP if you have any concerns.");
            Console.WriteLine();
        }

        /// <summary>
        /// Outputs a Heading showing the Program Name and the Author.
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("  App02: BMI Calculator   ");
            Console.WriteLine("   by Marius Daniel  ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("What is BMI?");
            Console.WriteLine();
            Console.WriteLine("BMI (Body Mass Index) is a measure of your weight compared to your height,\nwhich allows us to work out which WHO Weight Status Category you fit into,\ngiving you an idea of how healthy you are. ");
            Console.WriteLine();
        }
    }
}