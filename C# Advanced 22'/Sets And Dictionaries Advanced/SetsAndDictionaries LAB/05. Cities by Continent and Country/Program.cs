using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads continents, countries and their cities put them in a nested dictionary and prints them.

            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            AddData(continents, n);

            PrintOutput(continents);

        }

        static void PrintOutput(Dictionary<string, Dictionary<string, List<string>>> continents)
        {
            foreach (var cont in continents)
            {
                Console.WriteLine($"{cont.Key}:");
                foreach (var (country, city) in cont.Value)
                {
                    Console.WriteLine($"  {country} -> {string.Join(", ", city)}");
                }
            }
        }

        static void AddData(Dictionary<string, Dictionary<string, List<string>>> continents, int n)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(city);
            }
        }
    }
}
