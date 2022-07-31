using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace B02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|/)(?<city>[A-Z][A-Za-z]{2,})\1";

            string input = Console.ReadLine();
            int totalPoints = 0;

            MatchCollection citiesMatched = Regex.Matches(input, pattern);

            var destination = new List<string>();
            foreach (Match match in citiesMatched)
            {
                string city = match.Groups["city"].Value;
                
                totalPoints += city.Length;
                destination.Add(city);
            }

            //"Destinations: {destinations joined by ', '}".
            Console.WriteLine($"Destinations: {string.Join(", ",destination )}");
            //On the second line, print "Travel Points: {travel_points}".
            Console.WriteLine($"Travel Points: {totalPoints}");

        }
    }
}
