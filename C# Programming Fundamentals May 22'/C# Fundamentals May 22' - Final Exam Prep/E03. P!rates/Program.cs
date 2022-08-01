using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace E03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Until the "Sail" command is given, you will be receiving:
            //•	You and your crew have targeted cities, with their population and gold, separated by "||".
            //•	If you receive a city that has already been received, you have to increase the population and gold with the given values.

            Dictionary<string, Treasure> cities = new Dictionary<string, Treasure>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Sail") break;

                string[] info = command.Split("||"
                    , StringSplitOptions.RemoveEmptyEntries);
                string city = info[0];
                int population = int.Parse(info[1]);
                int gold = int.Parse(info[2]);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new Treasure(population, gold));
                }
                else
                {
                    cities[city].Population += population;
                    cities[city].Gold += gold;
                }

            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;
                string[] tokens = command.Split("=>"
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                string city = tokens[1];

                switch (cmd)
                {
                    case "Plunder":
                        //	"Plunder=>{town}=>{people}=>{gold}"
                        //o You have successfully attacked and plundered the town, killing the given number of people and stealing the respective amount of gold.
                        {
                            Plunder(cities, tokens, city);
                        }
                        break;
                    case "Prosper":
                        {
                            Prosper(cities, tokens, city);
                        }
                        break;
                }
            }   

            if(cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                Console.WriteLine(string.Join("\n",cities.Select(x=> $"{x.Key} -> Population: {x.Value.Population} citizens, Gold: {x.Value.Gold} kg")));
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static void Plunder(Dictionary<string, Treasure> cities, string[] tokens, string city)
        {
            int peopleKilled = int.Parse(tokens[2]);
            int goldStolen = int.Parse(tokens[3]);

            cities[city].Gold -= goldStolen;
            cities[city].Population -= peopleKilled;
            Console.WriteLine($"{city} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");

            if (cities[city].Gold == 0 || cities[city].Population == 0)
            {
                Console.WriteLine($"{city} has been wiped off the map!");
                cities.Remove(city);
            }
        }

        static void Prosper(Dictionary<string, Treasure> cities, string[] tokens, string city)
        {
            int gold = int.Parse(tokens[2]);
            if (gold < 0)
            {
                Console.WriteLine($"Gold added cannot be a negative number!");
            }
            else
            {
                cities[city].Gold += gold;
                Console.WriteLine($"{gold } gold added to the city treasury. {city} now has {cities[city].Gold} gold.");
            }
        }
    }
    class Treasure
    {
        public Treasure(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
