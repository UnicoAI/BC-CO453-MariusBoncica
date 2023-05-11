using System.Collections;
using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This App calulates BMI based on height and weight, allowing both metric and imperical values.
    /// </summary>
    /// <author>
    /// Marius Boncica Version 2 refactored
    /// </author>
    public class BMICalculatorWeb
    {
        SyntaxGenerator syntaxGen = new SyntaxGenerator();
        ArrayList data = new ArrayList();
        // BAME Messages for results output
        public static string bameMessage1 = "If you are Black, Asian or other minority ethnic groups you have a higher risk";
        public static string bameMessage2 = "Adults 23.0 or more are at increased risk Adults 27.5 or more are at high risk";
        // For this program I added colour variables for the online version of the App
        public string Colour { get; set; }
        // Used to determine if data is imperical or metric
        public bool UnitVal { get; set; }
        // Used for metres
        public double Height { get; set; }
        // Used for Pounds and KG
        public double Weight { get; set; }
        // Used for Feet
        public int Feet { get; set; }
        // Used for Inches
        public double Inches { get; set; }
        // Used to store the final result of the BMI score
        public double Bmi { get; set; }
        // Used to store the description linking to the final result of the BMI score
        public string Description { get; set; }
        // Used to distinguish BMI categories
        public double BmiRange { get; set; }

        public BMIenum BMIenum
        {
            get => default;
            set
            {
            }
        }
        // Used for console use to work out BMI
        public void Run()
        {
            InputReader reader = new InputReader();
            syntaxGen.SubheaderGen("BMI Calculator");
            Console.WriteLine(syntaxGen.SyntaxFiller1("Choose metric:"));
            Console.WriteLine(syntaxGen.SyntaxFiller1(" 1. Metric"));
            Console.WriteLine(syntaxGen.SyntaxFiller1(" 2. Imperical"));
            int option = reader.RangeInputChecker("Enter Option:", 1, 2);
            UnitVal = false;
            Height = 0;
            Weight = 0;
            if (option == 1)
            {
                Console.WriteLine(syntaxGen.SyntaxFiller1("Enter Height:"));
                Height = reader.DoubleInputChecker(" Metres:");
                Console.WriteLine(syntaxGen.SyntaxFiller1("Enter Weight:"));
                Weight = reader.DoubleInputChecker(" KG:");
                UnitVal = false;
            }
            else if (option == 2)
            {
                Console.WriteLine(syntaxGen.SyntaxFiller1("Enter Height:"));
                Feet = reader.IntInputChecker(" Feet:");
                Inches = reader.DoubleInputChecker(" Inches:");
                Console.WriteLine(syntaxGen.SyntaxFiller1("Enter Weight:"));
                Weight = reader.DoubleInputChecker(" Pounds:");
                UnitVal = true;
            }
            BMIOutput(UnitVal);

        }
        // Calculates BMI in an efficient fashion
        public string BMIcalc(bool imperical)
        {
            BMIdata();
            if (imperical)
            {
                Height = (Feet * 12) + Inches;
                Weight *= 703;
            }
            Bmi = Weight / (Height * Height);
            return Bmi.ToString("0.#");
        }
        // Fetches the description or colour linking to the BMI score using the data stored in the dictionary
        public string BMIdescription(int selectData)
        {
            foreach (string arrayData in data)
            {
                if (Bmi <= BmiRange)
                {
                    break;
                }
                else
                {
                    string[] splitter = arrayData.Split(",");
                    BmiRange = Convert.ToDouble(splitter[0]);
                    Description = splitter[1];
                    Colour = splitter[2];
                }
            }
            if (selectData == 0)
            {
                return Description;
            }
            else
            {
                return Colour;
            }
        }
        // Stores necessary data in a dictionary
        public void BMIdata()
        {
            data.Remove(data);
            data.Add("18.5,Underweight,#b52f2f");
            data.Add("24.9,Normal,#2fb52f");
            data.Add("29.9,Overweight,#acb52f");
            data.Add("34.9,Obese Class I,#d49b22");
            data.Add("39.9,Obese Class II,#d45a22");
            data.Add("40,Obese Class III,#b52f2f");

        }
        // Outputs results into the console
        public void BMIOutput(bool imperical)
        {
            Console.WriteLine(syntaxGen.SyntaxFiller1("Your BMI is: " + BMIcalc(imperical) + " this is " + BMIdescription(0)));
            Console.WriteLine(syntaxGen.SyntaxFiller1(bameMessage1));
            Console.WriteLine(syntaxGen.SyntaxFiller1(bameMessage2));
            syntaxGen.SyntaxFiller2();

        }
    }
}
