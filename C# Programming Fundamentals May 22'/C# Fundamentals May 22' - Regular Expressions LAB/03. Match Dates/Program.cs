using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
