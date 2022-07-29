using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emojisPattern = @"(\*{2}|:{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string numbersPattern = @"\d";


            MatchCollection emojiMatches = Regex.Matches(input, emojisPattern);
            MatchCollection numberMatches = Regex.Matches(input, numbersPattern);

            long treshold = 1;

            foreach (Match number in numberMatches)
            {
                treshold *= int.Parse(number.Value);
            }

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{emojiMatches.Count()} emojis found in the text. The cool ones are:");
            foreach (Match emojiMatch in emojiMatches)
            {
                string emoji = emojiMatch.Groups["emoji"].Value;
                long emojiTreshold = emoji.ToCharArray().Sum(c=>c);

                if (emojiTreshold >= treshold)
                {
                    Console.WriteLine(emojiMatch.Value);
                }
            }
        }
    }
}
