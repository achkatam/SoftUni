using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads some text from the console and counts the occurrences of each character in it. Print the results in alphabetical (lexicographical) order. 

            var dict = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i])) dict.Add(input[i], 0);

                dict[input[i]]++;
            }

            Console.WriteLine(String.Join("\n", dict
                .OrderBy(x => x.Key)
                .Select(x => $"{x.Key}: {x.Value} time/s")));
        }
    }
}
