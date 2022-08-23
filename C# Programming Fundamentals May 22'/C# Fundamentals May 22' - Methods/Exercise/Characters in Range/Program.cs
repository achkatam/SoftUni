using System;
using System.Linq;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharsInRange(firstChar, secondChar);
            
        }

        private static void CharsInRange(char firstChar, char secondChar)
        {
            //returns the smaller 
            int startChar = Math.Min(firstChar, secondChar);
            //returns the larger one
            int endChar = Math.Max(firstChar, secondChar);

            //For loop. We want to start from the next char of the inputed one
            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
