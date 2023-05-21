
using System;
namespace ConsoleAppProject
{
    /// <summary>
    /// Sintax Generator
    /// </summary>
    /// <author>
    /// Marius Boncica version 1.0
    /// </author>
    public class SyntaxGenerator
    {
        public string LineFiller(string text, int space)
        {
            int c = 0;
            string fill = "";
            while(c <= (space - text.Length))
            {
                fill += " ";
                c++;
            }
            return text + fill;

        }
        //method to generate header
        public void HeaderGen(string heading)
        {
            Console.WriteLine(" ╔──────────────────────────────────────────────────────╗");
            Console.WriteLine(" │                                                      │");
            Console.WriteLine(" │ " + LineFiller(heading, 52) + "│");
            Console.WriteLine(" │ By Marius Boncica                                    │");
            Console.WriteLine(" │                                                      │");
            Console.WriteLine(" ╚──────────────────────────────────────────────────────╝");
            Console.ResetColor();

        }
       //method to generate subheading
        public void SubheaderGen(string subheading)
        {
            Console.WriteLine("  ├────────────────────────────────────────────────────┐");
            Console.WriteLine("  │ " + LineFiller(subheading, 50) + "│");
            Console.WriteLine("  │ By Marius Boncica                                     │");
            Console.WriteLine("  ├────────────────────────────────────────────────────┘");

        }
        public string SyntaxFiller1(string option)
        {
            return "  │ " + option;

        }
        public void SyntaxFiller2()
        {
            Console.WriteLine("  └────────────────────────────────────────────────────■");
        }
    }
}