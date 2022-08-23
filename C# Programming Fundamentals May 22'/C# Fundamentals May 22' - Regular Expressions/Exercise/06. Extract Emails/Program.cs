using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b";

            string input = Console.ReadLine();

            MatchCollection match = Regex.Matches(input, pattern);
            match.ToList().ForEach(Console.WriteLine);

        }
    }
}
