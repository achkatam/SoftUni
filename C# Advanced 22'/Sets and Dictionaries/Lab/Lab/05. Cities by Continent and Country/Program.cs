using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary<continent, Dictionary<country, List<city>>()
            var cities = new Dictionary<string, Dictionary<string, List<string>>>();

            int citiesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < citiesCount; i++)
            {
                var tokens = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                AddCity(continent, country, city, cities);

            }

            PrintOutput(cities);
        }

        static void AddCity(string continent, string country, string city, Dictionary<string, Dictionary<string, List<string>>> cities)
        {
            //Add the continent
            if (!cities.ContainsKey(continent))
            {
                cities.Add(continent, new Dictionary<string, List<string>>());
            }

            //Add the country
            Dictionary<string, List<string>> countries = cities[continent];
            if (!countries.ContainsKey(country))
            {
                countries.Add(country, new List<string>());
            }

            //Add city in existing continent
            countries[country].Add(city);
        }
        static void PrintOutput(Dictionary<string, Dictionary<string, List<string>>> cities)
        {
            foreach (var (continentName, countries) in cities)
            {
                Console.WriteLine(continentName + ":");
                foreach (var (countryName, citiesInCoutnry) in countries)
                {
                    Console.Write($"  {countryName} -> ");
                    Console.WriteLine(string.Join(", ", citiesInCoutnry));
                }
            }
        }
    }
}
