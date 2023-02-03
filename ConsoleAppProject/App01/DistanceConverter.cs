using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    ///App01 Bucks New 
    /// </summary>
    /// <author>
    /// Marius Daniel Boncica Version 1
    /// </author>
    public class DistanceConverter
    {
        /// <summary>
        ///App01 Bucks New 
        /// </summary>
        /// <author>
        /// Marius Daniel Boncica Version 1
        /// </author>
        /// declare variables
        
        private double miles;
        private double feet;
        public const int FEET_IN_MILES = 5280;
        public const double METERS_IN_MILES = 1609.34;
        private double meters;
        public void Run()
        {
            MilesToFeet();
            FeetToMiles();
            MilestoMeters();
        }

        //miles to feet methods
        public void MilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        //feet to miles method
        public void FeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        //miles to meters
        public void MilestoMeters()
        {
            OutputHeading();
            InputMiles();
            CalculateMeters();
            OutputMeters();
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
        private void InputMiles()
        {
            /// <summary>
         ///Prompt the user to enter distance in miles
         /// /// input miles as a double number
         /// </summary>
            Console.Write("Please enter the number of miles you wish to convert! ");
            string value = Console.ReadLine();
            miles= Convert.ToDouble(value); 

        }
        private void InputFeet()
        {
            Console.Write("Please enter the number of feet you wish to convert! ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        private void CalculateFeet()
        {/// <summary>
         ///Used the declared constant value for feet to convert miles to feet
         
         /// </summary>
            feet = miles * FEET_IN_MILES;
        }
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }
        private void CalculateMeters()
        {
            meters = miles* METERS_IN_MILES;
        }
        private void OutputFeet()
        {
            /// <summary>

            /// Output the Result 
            /// </summary>
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(miles + " miles you requested to be converted  is " +   feet +" feet!");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("----------------------Thank you------------------------------");
        }
        private void OutputMiles()
        {
            /// <summary>

            /// Output the Result 
            /// </summary>
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(feet + " feet you requested to be converted  is " + miles + " miles!");
            Console.WriteLine("-------------------------------------------------------------");

        }
        private void OutputMeters()
        {
            /// <summary>

            /// Output the Result 
            /// </summary>
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(miles + " miles you requested to be converted  is " + meters + " meters!");
            Console.WriteLine("-------------------------------------------------------------");


        }
    }
}
