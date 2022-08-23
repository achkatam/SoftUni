﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359([ \-])2\1[0-9]{3}\1[0-9]{4}\b";

            MatchCollection matches = Regex.Matches(input, pattern);


            Console.WriteLine(string.Join(", ", matches));

        }
    }
}
