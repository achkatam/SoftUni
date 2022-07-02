using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a string that will contain words separated by a single space. Randomize their order and print each word on a new line.

            //Create string array
            string[] input = Console.ReadLine().Split();

            //Random method
            Random random = new Random();

            //For loop to iterate thru the array
            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0, input.Length);

                string currWord = input[i];

                input[i] = input[randomIndex];
                input[randomIndex] = currWord;
            }

            //Foreach to check each word
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }

        }
    }
}
