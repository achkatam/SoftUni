using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _2._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Every gamer knows what rage-quitting means. It’s basically when you’re just not good enough and you blame everybody else for losing a game. You press the CAPS LOCK key on the keyboard and flood the chat with gibberish to show your frustration.
            //Chochko is a gamer and a bad one at that.He asks for your help; he wants to be the most annoying kid on his team, so when he rage - quits he wants something truly spectacular.He’ll give you a series of strings followed by non - negative numbers, e.g. "a3"; you need to print on the console each string repeated N times; convert the letters to uppercase beforehand. In the example, you need to write back "AAA".
            //On the output, print first a statistic of the number of unique symbols used(the casing of letters is irrelevant, meaning that 'a' and 'A' are the same); the format should be "Unique symbols used {0}".Then, print the rage message itself.
            //The strings and numbers will not be separated by anything. The input will always start with a string and for each string, there will be a corresponding number.The entire input will be given on a single line; Chochko is too lazy to make your job easier.

            string pattern = @"([\D]+)([0-9]+)";

            string input = Console.ReadLine();

            MatchCollection inputMatch = Regex.Matches(input, pattern);

            var word = new StringBuilder();

            foreach (Match match in inputMatch)
            {
                var letters = match.Groups[1].Value;
                int digits = int.Parse(match.Groups[2].Value);


                for (int i = 0; i < digits; i++)
                {
                    word.Append(letters.ToString().ToUpper());
                }

            }

            var symbols = new List<char>();

            foreach (var ch in word.ToString())
            {
                if (!char.IsDigit(ch))
                {
                    if (!symbols.Contains(ch))
                    {
                        symbols.Add(ch);
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {symbols.Count()}");
            Console.WriteLine(word);
        }
    }
}
