using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //using regexr.com
            string pattern = @"(.+)>(?<numbers>\d{3})\|(?<lcLetters>[a-z]{3})\|(?<ucLetters>[A-Z]{3})\|(?<symbols>.{3})<\1";

            //number of inputs
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                var match = Regex.Match(input, pattern);

                string password = string.Empty;

                if (match.Success)
                {
                    string numbers = match.Groups["numbers"].Value;
                    //low case letters
                    string lcLetters = match.Groups["lcLetters"].Value;
                    //upper case letters
                    string ucLetters = match.Groups["ucLetters"].Value;
                    string symbols = match.Groups["symbols"].Value;

                    password = string.Join("", numbers, lcLetters, ucLetters, symbols);

                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine($"Try another password!");
                }
            }

        }
    }
}
