using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace B03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will receive a number n. On the next n lines, you will be given some information about the plants that you have discovered in the format: "{plant}<->{rarity}". Store that information because you will need it later. If you receive a plant more than once, update its rarity.
            //variable number of plants 
            int num = int.Parse(Console.ReadLine());

            //Create new dictionary to store the values
            var plants = new Dictionary<string, Plant>();

            for (int i = 0; i < num; i++)
            {
                string[] plantInput = Console.ReadLine().Split("<->"
                    , StringSplitOptions.RemoveEmptyEntries);

                string plantName = plantInput[0];
                int rarity = int.Parse(plantInput[1]);

                if (!plants.ContainsKey(plantName))
                {
                    plants.Add(plantName, new Plant(rarity, new List<double>()));
                }
                plants[plantName].Rarity = rarity;
            }

            string command = Console.ReadLine();

            //After that, until you receive the command "Exhibition", you will be given some of these commands:
            while (command != "Exhibition")
            {
                string[] tokens = command.Split(new[] { ": ", " - " }
                , StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];
                string plantName = tokens[1];

                if (!plants.ContainsKey(plantName))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    switch (cmd)
                    {
                        case "Rate":
                            {
                                //•	"Rate: {plant} - {rating}" – add the given rating to the plant(store all ratings)
                                plants[plantName].Rating.Add(double.Parse(tokens[2]));
                            }
                            break;
                        case "Update":
                            {
                                //•	"Update: {plant} - {new_rarity}" – update the rarity of the plant with the new one
                                plants[plantName].Rarity = int.Parse(tokens[2]);
                            }
                            break;
                        case "Reset":
                            {
                                //•	"Reset: {plant}" – remove all the ratings of the given plant
                                plants[plantName].Rating.Clear();
                            }
                            break;
                    }
                }

                command = Console.ReadLine();
            }
            //"Plants for the exhibition:
            //"- { plant_name1}; Rarity: { rarity}; Rating: { average_rating}"
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var plant in plants)
            {
                if (plant.Value.Rating.Count > 0)
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: { plant.Value.Rarity}; Rating: {plant.Value.Rating.Average():f2}");
                }
                else
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: { plant.Value.Rarity}; Rating: {0:f2}");
                }
            }

        }
    }
    class Plant
    {
        public Plant(int rarity, List<double> rating)
        {
            Rarity = rarity;
            Rating = new List<double>();
        }
        public int Rarity { get; set; }
        public List<double> Rating { get; set; }
    }
}

