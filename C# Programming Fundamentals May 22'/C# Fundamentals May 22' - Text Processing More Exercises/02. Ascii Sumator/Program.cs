using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints a sum of all characters between two given characters (their ASCII code). In the first line, you will get a character. On the second line, you get another character. On the last line, you get a random string. Find all the characters between the two given and print their ASCII sum.

            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            int sum = 0;
            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                if (ch > startChar && ch < endChar) sum += ch;
            }

            Console.WriteLine(sum);
        }
    }
}
