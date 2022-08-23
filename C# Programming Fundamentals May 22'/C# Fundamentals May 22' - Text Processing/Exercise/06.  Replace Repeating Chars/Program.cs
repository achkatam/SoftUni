using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _06.__Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a string from the console and replaces any sequence of the same letters with a single corresponding letter.
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1]) sb.Append(input[i]);
            }

            sb.Append(input[input.Length - 1]);

            Console.WriteLine(sb);
        }
    }
}
