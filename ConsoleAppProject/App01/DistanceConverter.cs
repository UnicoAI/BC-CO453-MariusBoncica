
using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App converts converts one distance to another with a range of values
    /// </summary>
    /// <author>
    /// Marius Boncica
    /// </author>
    /// Version 2.0
    public class DistanceConverter
    {
        // Create a new dictionary of strings, with string keys.
        public Dictionary<string, string> unitConversion = new Dictionary<string, string>();
        public Dictionary<double, double> methodReverse = new Dictionary<double, double>();
        InputReader reader = new InputReader();
        SyntaxGenerator syntaxGen = new SyntaxGenerator();

        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }
        // Starting value name, declare constructors
        public string Unit1 { get; set; }
        // Target value name
        public string Unit2 { get; set; }
        // Starting value
        public double Unit1Value { get; set; }
        // Used to split statements
        public string[] Splitter { get; set; }
        // The result
        public double Result { get; set; }
        // Sends conversion data
        public string UnitData { get; set; }
        // Used to store the middle-stage converison
        public double ConversionValue { get; set; }
        // Distinguishes if the program needs to divide or multiply
        public double Method { get; set; }
        // Program reacts different depending on the enviroment
        public bool WebVersion { get; set; }

        public DistanceUnits DistanceUnit
        {
            get => default;
            set
            {
            }
        }

        public DistanceUnits DistanceUnits1
        {
            get => default;
            set
            {
            }
        }

        //Method to start program and write Header
        public void Run()
        {
            syntaxGen.SubheaderGen("Distance Converter");
            UserInput();

        }
        //Conversion method
        public void UnitConversionData()
        {
            unitConversion.Add("metres", "m,1");
            unitConversion.Add("lightyears", "m,9.461E+15");
            unitConversion.Add("kilometres", "m,1000");
            unitConversion.Add("miles", "m,1609.344");
            unitConversion.Add("yards", "d,1.094");
            unitConversion.Add("feet", "d,3.281");
            unitConversion.Add("inches", "d,39.37");
            unitConversion.Add("centimetres", "d,100");
            unitConversion.Add("millimetres", "d,1000");
            unitConversion.Add("micrometres", "d,1E+6");
            unitConversion.Add("nanometres", "d,1E+9");
            methodReverse.Add(0, 1);
            methodReverse.Add(1, 0);
        }
        // method  input checker to check the distance values using the enum class
        public string DistanceChecker(string consoleWrite)
        {
            string data = "";
            while (true)
            {
                Console.Write(syntaxGen.SyntaxFiller1(consoleWrite));
                data = Console.ReadLine().ToLower();
                if (System.Enum.IsDefined(typeof(DistanceUnits), data))
                {
                    break;
                }
                else
                {
                    Console.Write(syntaxGen.SyntaxFiller1("Invalid unit\n"));
                }
            }
            return data;
        }
        /// Prompt the user to enter 2 distance units in console format and the initial value
        public void UserInput()
        {
            PrintUnits();
            Unit1 = DistanceChecker("Convert:");
            Unit2 = DistanceChecker("To:");
            Unit1Value = reader.DoubleInputChecker("Please enter the number of " + Unit1 + " > ");
            double res = ConverterResult(false);
            Console.WriteLine(syntaxGen.SyntaxFiller1(Unit1Value + " " + Unit1 + " ---> " + res + " " + Unit2));
            syntaxGen.SyntaxFiller2();
        }
        // Boolean method to enable result
        public double ConverterResult(bool version)
        {
            WebVersion = version;
            UnitConversionData();
            if (Unit1 == null || Unit2 == null)
            {
                Unit1 = "metres";
                Unit2 = "metres";
            }
            if (Unit1.Equals(Unit2))
            {
                return Unit1Value;
            }
            else
            {
                return Converter(Unit2, Converter(Unit1, Unit1Value, false), true);
            }
        }
        // Prints Units for the console using the enum class in a for loop scanning for all display names
        public void PrintUnits()
        {
            Console.WriteLine(syntaxGen.SyntaxFiller1("Available Units:"));
            foreach (string i in Enum.GetNames(typeof(DistanceUnits)))
            {
                Console.WriteLine(syntaxGen.SyntaxFiller1($" {i}"));
            }
        }
        // The converter converts values to and from metres to allow mix-matching conversions, this is a 2 stage process
        public double Converter(string unitName, double unitValue, bool reverse)
        {
            Result = 0;
            int e = 0;
            if (WebVersion)
            {
                if (Int32.TryParse(unitName, out e))
                {
                    unitName = Enum.GetName(typeof(DistanceUnits), Int32.Parse(unitName));
                }
                else
                {
                    unitName = "metres";
                }
            }

            if (unitName != null)
            {
                UnitData = unitConversion[unitName];
            }
            else
            {
                UnitData = unitConversion["metres"];
            }
            ConversionValue = UnitConversionParser(UnitData, 1);
            Method = UnitConversionParser(UnitData, 0);
            if (reverse) { Method = methodReverse[Method]; }

            if (Method == 0)
            {
                Result = unitValue * ConversionValue;

            }
            else if (Method == 1)
            {
                Result = unitValue / ConversionValue;
            }
            return Result;
        }
        //This method translates the disctionary values giving the required infomation for a successful converison
        public double UnitConversionParser(string data, int dataType)
        {
            Splitter = data.Split(",");

            if (dataType == 0)
            {
                if (Splitter[0] == "m") { return 0; }
                else if (Splitter[0] == "d") { return 1; }
                else { return 3; }
            }
            else if (dataType == 1)
            {
                return Convert.ToDouble(Splitter[1]);
            }
            else
            {
                return 0;
            }
        }
    }
}
