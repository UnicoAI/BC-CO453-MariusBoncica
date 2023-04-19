using System;
using System.Linq;
namespace ConsoleAppProject
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class InputReader
    {
        SyntaxGenerator syntaxGen = new SyntaxGenerator();
        public string ReadInput(string consoleWrite)
        {
            Console.Write(syntaxGen.SyntaxFiller1(consoleWrite));
            string data = Console.ReadLine();
            return data;
        }
        public int IntInputChecker(string consoleWrite)
        {
            int data;
            while (true)
            {
                Console.Write(syntaxGen.SyntaxFiller1(consoleWrite));
                string value = Console.ReadLine();
                try
                {
                    data = (int)Convert.ToInt64(value);
                    break;
                }
                catch (System.FormatException)
                {
                    Console.Write(syntaxGen.SyntaxFiller1("Invalid input\n"));
                }
            }
            return data;
        }

        public string StringInputChecker(string consoleWrite)
        {
            string data = null;
            while (true)
            {
                Console.Write(syntaxGen.SyntaxFiller1(consoleWrite));
                data = Console.ReadLine();
                if (!data.Any(char.IsDigit))
                {
                    
                    break;
                }
                else
                {
                    Console.Write(syntaxGen.SyntaxFiller1("Invalid input\n"));
                }
            }
            return data;
        }

        public int RangeInputChecker(string consoleWrite, int minoption, int maxoption)
        {
            int data;
            while (true)
            {
                Console.Write(syntaxGen.SyntaxFiller1(consoleWrite));
                string value = Console.ReadLine();
                try
                {
                    data = (int)Convert.ToInt64(value);
                    if (data <= maxoption && data >= minoption)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(syntaxGen.SyntaxFiller1("Invalid input\n"));
                    }
                }
                catch (System.FormatException)
                {
                    Console.Write(syntaxGen.SyntaxFiller1("Invalid input\n"));
                }
            }
            return data;
        }

        public double DoubleInputChecker(string consoleWrite)
        {
            double data = 0;
            while (true)
            {
                Console.Write(syntaxGen.SyntaxFiller1(consoleWrite));
                string value = Console.ReadLine();
                try
                {
                    data = Convert.ToDouble(value);
                    break;
                }
                catch (System.FormatException)
                {
                    Console.Write(syntaxGen.SyntaxFiller1("Invalid input\n"));
                }
            }
            return data;
        }

        public bool NullChecker(object sampleData)
        {
            if(sampleData == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}