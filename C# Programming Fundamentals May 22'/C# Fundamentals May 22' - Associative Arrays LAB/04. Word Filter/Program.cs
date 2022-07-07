using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read an array of strings and take only words, whose length is an even number. Print each word on a new line.
            Dictionary<string, int> countsByWord = new Dictionary<string, int>();


            //Create an array
            var words = Console.ReadLine()
                .Split()
                .Select(word => word.ToLower())
                .ToArray();

            foreach (var word in words)
            {
                if (!countsByWord.ContainsKey(word))
                {
                    countsByWord.Add(word, 0);
                }

                countsByWord[word]++;
            }

            //Ouput
            string[] oddCountWords = countsByWord.Where(w => w.Value % 2 != 0)
                .Select(w => w.Key)
                .ToArray();

            Console.WriteLine(string.Join(' ', oddCountWords));

        }
    }
}
