using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CitiesByContinentsAndCountries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads continents, countries and their cities put them in a nested dictionary and prints them.

            //dict of                       cont, List<Country>(country, city)
            var continents = new List<Continent>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                Continent cont = AddContinent(continents, continent);

                Country thisCountry = AddCountry(country, cont);

                //add the city in the country
                thisCountry.Cities.Add(city);
            }

            PrintOutput(continents);
        }

        static void PrintOutput(List<Continent> continents)
        {
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.ContinentName}:");

                foreach (var country in continent.Countries)
                {
                    Console.WriteLine($"  {country.CountryName} -> {string.Join(", ", country.Cities)}");
                }
            }
        }

        static Country AddCountry(string country, Continent cont)
        {
            //check if country exists in continent
            if (!cont.Countries.Any(x => x.CountryName == country))
            {
                cont.Countries.Add(new Country(country));
            }
            Country thisCountry = cont.Countries.Find(x => x.CountryName == country);
            return thisCountry;
        }

        static Continent AddContinent(List<Continent> continents, string continent)
        {
            //check if continent exists in continents
            if (!continents.Any(x => x.ContinentName == continent))
            {
                continents.Add(new Continent(continent));
            }
            Continent cont = continents.Find(x => x.ContinentName == continent);
            return cont;
        }
    }
    class Continent
    {
        public Continent(string continentName)
        {
            ContinentName = continentName;
            Countries = new List<Country>();
        }

        public string ContinentName { get; set; }
        public List<Country> Countries { get; set; }
    }

    class Country
    {
        public Country(string countryName)
        {
            CountryName = countryName;
            Cities = new List<string>();
        }

        public string CountryName { get; set; }
        public List<string> Cities { get; set; }
    }
}
