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

            //Create list with the words
            var words = Console.ReadLine().Split().ToList();

            Random rnd = new Random();

            //Create for loop to iterate thru the list
            for (int i = 0; i < words.Count; i++)
            {
                //randomize
                int randomIndex = rnd.Next(0, words.Count);

                //variable for current words
                string currWord = words[i];

                words[i] = words[randomIndex];
                words[randomIndex] = currWord;

            }
            //Foreach to check each word in words
            foreach (var word in words)
            {
                Console.WriteLine(word) ;
            }

        }
    }
}
