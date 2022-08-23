using System;
using System.Linq;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            SearchForVowels(input);
        }

        //Create a method that returns vowels count
        private static void SearchForVowels(string text)
        {
            Console.WriteLine(text.Count(vowels => "aouei".Contains(vowels)));

            int count = 0;
            //Using foreach loop
            //foreach (char vowel in text)
            //{
            //    if ("auioe".Contains(text))
            //    count++;
            //}
        }
    }
}
