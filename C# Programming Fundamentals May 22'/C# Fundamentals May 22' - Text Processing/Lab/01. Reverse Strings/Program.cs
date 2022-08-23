using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a series of strings, until you receive an "end" command. Write a program that reverses strings and prints each pair on a separate line in the format "{word} = {reversed word}".

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end") break;

                string reversed = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }

                Console.WriteLine($"{input} = {reversed}");
            }
        }
    }
}
