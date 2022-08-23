using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(string.Join(' ', matches));
        }
    }
}
