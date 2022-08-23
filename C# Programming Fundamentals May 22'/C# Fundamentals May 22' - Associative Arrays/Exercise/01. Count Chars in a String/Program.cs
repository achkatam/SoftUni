using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            //Create new dictionary of char, int
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if(letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters[letter] = 0;
                    }
                    //increace the occurrence
                    letters[letter]++;
                }
            }

            //Output
            foreach (var kvpLetter in letters)
            {
                Console.WriteLine($"{kvpLetter.Key} -> {kvpLetter.Value}");
            }
        }
    }
}
