using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads some text from the console and counts the occurrences of each character in it. Print the results in alphabetical (lexicographical) order(SorrtedSictionary). 

            //new SortedDictionary<char, count of appearances>
            var elements = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!elements.ContainsKey(input[i]))
                {
                    elements.Add(input[i], 1);
                }
                else
                {
                    elements[input[i]]++;
                }
            }

            Console.WriteLine(string.Join("\n",
                elements.Select(x => $"{x.Key}: {x.Value} time/s")));
        }
    }
}
