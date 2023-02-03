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
        private double miles;
        private double feet;
        public const int FEET_IN_MILES = 5280;
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
            /// <summary>
            ///Prompt the user to enter distance in miles
            /// /// input miles as a double number
            /// </summary>
           
        }
        private void OutputHeading()
        {
            Console.WriteLine("\n ----------------------------------");
            Console.WriteLine("          Convert Miles to Feet     ");
            Console.WriteLine("          by Marius Boncica         ");
            Console.WriteLine("------------------------------------\n");
        }
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles: ");
            string value = Console.ReadLine();
            miles= Convert.ToDouble(value); 

        }
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + " feet!");
        }
    }
}
