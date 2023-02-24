using System;
using System.Globalization;

namespace ConsoleAppProject.App01
{
    /// <summary>
    ///App01 Bucks New 
    ///This App will ask user to choose a distance converting unit
    ///Convert in one unit from chosen unit
    ///Output result</summary>
    /// <author>
    /// Marius Daniel Boncica Version 2
    /// </author>
    public class DistanceConverter
    {
        /// <summary>
        ///App01 Bucks New 
        /// </summary>
        /// <author>
        /// Marius Daniel Boncica Version 1
        /// </author>
        /// declare constant variables

        public const int FEET_IN_MILES = 5280;
        public const double METERS_IN_MILES = 1609.34;
        public const double FEET_IN_METERS = 3.28084;

        public const string FEET = "Feet";
        public const string METERS = "Meters";
        public const string MILES = "Miles";
        //use private string for input values
        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;

        }
        //convert distance method
        public void ConvertDistance()
        {
            OutputHeading();
            fromUnit = SelectUnit(" Select the from distance unit!"); ;
            toUnit = SelectUnit(" Select the to distance unit!");

            Console.WriteLine($"Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($" Enter the number of {fromUnit}");
            CalculateDistance();
            OutputDistance();
            ConvertDistance();
        }
        //method to input distance
        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);

        }
        //method to convert miles to feet and feet to miles
        public void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METERS)
            {
                toDistance = fromDistance / FEET_IN_METERS;
            }
            else if (fromUnit == METERS && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METERS;
            }
            else if (fromUnit == MILES && toUnit == METERS)
            {
                toDistance = fromDistance * METERS_IN_MILES;
            }
            else if (fromUnit == METERS && toUnit == MILES)
            {
                toDistance = fromDistance / METERS_IN_MILES;
            }
          
            else if (fromUnit == toUnit)
            {
                toDistance = fromDistance;
            }
        }
        //method to output a message output of distance
        public void OutputDistance()
        {
            Console.WriteLine($"{fromDistance} {fromUnit} " +
                $" is {toDistance} {toUnit}");
        }

       

        public string SelectUnit(string prompt)
        {
            string choice = DisplayChoice(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"You have chosen {unit}");
            return unit;
        }
        //method using switch to select choice
        private static string ExecuteChoice(string choice)
        {
            string unit = "Invalid Choice. Please enter a valid choice";
            if (choice == "1")
            {
                return FEET;

            }
            else if (choice == "2")
            {
                return METERS;
            }
            else if (choice == "3")
            {
                return MILES;
            }
            return unit;

        }
        private static string DisplayChoice(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METERS}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;

        }


        private void OutputHeading()
        { /// <summary>
          ///Create An Heading explaining the app

          /// </summary>
            Console.WriteLine("\n ----------------------------------");
            Console.WriteLine("          Convert Miles to Feet     ");
            Console.WriteLine("          by Marius Boncica         ");
            Console.WriteLine("------------------------------------\n");

        }
    }
}
    

       