using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace E02.Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";

            string input = Console.ReadLine();

            //Cannot be zero. anth * 0 => 0;
            long treshold = 1;

            var matches = Regex.Matches(input, pattern);
            var digit = Regex.Matches(input, digitPattern);

            var coolEmojis = new List<string>();

            foreach (Match num in digit)
            {
                treshold *= int.Parse(num.Value);
            }

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{matches.Count()} emojis found in the text. The cool ones are:");
            foreach (Match match in matches)
            {
                string emoji = match.Groups["emoji"].Value;
                //Sum up all the emojis' element
                long emojiTreshold = emoji.ToCharArray().Sum(x => x);

                if (emojiTreshold >= treshold)
                {
                    Console.WriteLine(match.Value);
                }
            }

        }
    }
}
