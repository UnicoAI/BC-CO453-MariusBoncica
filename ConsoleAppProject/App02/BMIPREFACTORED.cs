using System;
using System.Text;
using ConsoleAppProject.Helpers;


namespace ConsoleAppProject.App02
{
    /// <summary>
    /// The BMI class has methods to calculate the 
    /// Body Mass Index (BMI) using a choice of
    /// Imperial or Metric Units
    /// </summary>
    /// <author>
    ///  Marius Boncica Version 1
    /// </author>
    public class BMI
    {
        //Constants for how many pounds in a stone
        //and how many inches in a foot.
        public const int PoundsInStones = 14;
        public const int InchesInFeet = 12;

        //Constants to define upper limit values
        //defined in the WHO Weight Status table
        public const double Underweight = 18.5;
        public const double Normal = 24.9;
        public const double Overweight = 29.9;
        public const double ObeseClassI = 34.9;
        public const double ObeseClassII = 39.9;
        public const double ObeseClassIII = 40.0;

        //Imperial and Metric variables
        public double Pound { get; set; }
        public int Inch { get; set; }
        public double Kilogram { get; set; }

        public int Centimetre { get; set; }
        public int Stone { get; set; }
        public int Feet { get; set; }

        public double metre;

        //BMI Index
        public double IndexBMI;

        /// <summary>
        /// Ask user to select units of measurment
        /// to work with, either Imperial or Metric.
        /// Get the height and weight of the user
        /// to calculate the BMI.  Dipaly the weight category
        /// according to set categories in the program
        /// </summary>
        public void CalculateIndex()
        {
            //call library class consolehelper with custom heading
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            //Select units method called to make the unit choice
            UnitSystems unitSystem = (UnitSystems)SelectUnits();

            //Decision made of choice - imperial or metric
            if (unitSystem == UnitSystems.Imperial)
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }
            else
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }

            //Output the required messages for BMI calculations
            //and if you are BAME and therefore at higher risk
            Console.WriteLine(OutputHealthMessage());
            Console.WriteLine(OutputBameMessage());
        }

        /// <summary>
        /// Get the Users choice of unit, either
        /// Imperial or Metric from a basic menu.
        /// </summary>
        private UnitsList SelectUnits()
        {
            string[] choices =
           {
                UnitSystems.Metric.ToString(),
                UnitSystems.Imperial.ToString(),
            };

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            //Works but might be a neater way to 
            //convert choice to enum value.
            if (choiceNo == 1)
            {
                return (UnitsList)UnitSystems.Metric;
            }
            else
            {
                return (UnitsList)UnitSystems.Imperial;
            }
        }

        /// <summary>
        /// Input metric values for 
        /// height in metres and 
        /// weight in kilograms.
        /// </summary>
        private void InputMetricDetails()
        {
            Centimetre = (int)ConsoleHelper.InputNumber("Input height in centimetres > ");
            metre = (double)Centimetre / 100;
            Kilogram = ConsoleHelper.InputNumber("Input weight in kilograms > ");
        }

        /// <summary>
        /// Input imperial details and convert 
        /// height into inches  and weight
        /// into pounds. 
        /// </summary>
        private void InputImperialDetails()
        {
            Console.Write("Input your weight (stones & pounds)\n");
            Stone = (int)ConsoleHelper.InputNumber("Input weight in Stones > ");
            Pound = (int)ConsoleHelper.InputNumber("Input weight in Pounds > ");

            Console.WriteLine("Input your height (feet & inches)\n");
            Feet = (int)ConsoleHelper.InputNumber("Input height in Feet > ");
            Inch = (int)ConsoleHelper.InputNumber("Input height in Inches > ");
        }

        /// <summary>
        /// Calculate the BMI from Metric 
        /// Details - Weight = Kilos and 
        /// Height = Metres 
        /// </summary>
        public void CalculateMetricBMI()
        {
            IndexBMI = Kilogram / (metre * metre);
        }

        /// <summary>
        /// Calculate the BMI from Imperial
        /// Details - Weight = Pounds and 
        /// Height is Inches
        /// </summary>
        public void CalculateImperialBMI()
        {
            Inch += Feet * InchesInFeet;
            Pound += Stone * PoundsInStones;

            IndexBMI = (double)Pound * 703 / (Inch * Inch);
        }

        /// <summary>
        /// Output of BAME message 
        /// for higher risk people
        /// </summary>
        public string OutputBameMessage()
        {
            StringBuilder message = new StringBuilder("\n");


            message.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            message.Append("There are higher risks for ");
            message.Append("Black, Asian or other minority people");
            message.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            message.Append("Write a suitable message here!!");
            message.Append("explaining increased risk for BAME");
            message.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            return message.ToString();
        }

        public string OutputHealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            if (IndexBMI < Underweight)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore " +
                    $"you are classed as Underweight.");
            }
            else if (IndexBMI <= Normal)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore " +
                    $"you are classed as Normal weight.");
            }
            else if (IndexBMI <= Overweight)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore " +
                    $"you are classed as Overweight.");
            }
            else if (IndexBMI <= ObeseClassI)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore " +
                    $"you are classed as Obese Class I.");
            }
            else if (IndexBMI <= ObeseClassII)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore " +
                    $"you are classed as Obese Class II.");
            }
            else if (IndexBMI >= ObeseClassIII)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class III.");
            }

            return message.ToString();
        }

        //code created by making association in class designer
        public UnitSystems UnitSystems
        { get => default; set { } }
    }
}