
using System;
namespace ConsoleAppProject
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Marius Boncica version 0.1
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