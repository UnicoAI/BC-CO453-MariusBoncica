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
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
            /// <summary>
            ///Prompt the user to enter distance in miles
            /// /// input miles as a double number
            /// </summary>
           
        }
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles> ");
            string value = Console.ReadLine();
            miles= Convert.ToDouble(value); 

        }
        private void CalculateFeet()
        {

        }
        private void OutputFeet()
        {

        }
    }
}
