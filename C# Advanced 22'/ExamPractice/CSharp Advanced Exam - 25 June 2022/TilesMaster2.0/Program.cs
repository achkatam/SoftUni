using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace TilesMaster2_0
{
    class Location
    {
        public Location(string title, int neededArea)
        {
            Title = title;
            NeededArea = neededArea;
        }

        public string Title { get; set; }
        public int NeededArea { get; set; }
        public int FoundTiles { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Sink	40
            //Oven    50
            //Countertop  60
            //Wall    70

            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList());

            Queue<int> greyTiles = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList());



            //var posLocations = new Dictionary<string, int>
            //{
            //    { "Sink", 0 },
            //    { "Oven", 0 },
            //    { "Countertop", 0 },
            //    { "Wall", 0 }
            //};

            List<Location> locations = new List<Location>()
            {
                new Location( "Sink", 40),
                new Location( "Oven", 50) ,
                new Location( "Countertop", 60),
                new Location( "Wall", 70),
                new Location( "Floor", -1)
            };

            Location floor = locations[4];

            while (whiteTiles.Count != 0 && greyTiles.Count != 0)
            {
                int white = whiteTiles.Pop();
                int grey = greyTiles.Dequeue();

                if (white == grey)
                {
                    int newTile = white + grey;

                    Location possLocation = locations.FirstOrDefault(x => x.NeededArea == newTile);

                    if (possLocation != null)
                    {
                        possLocation.FoundTiles++;
                    }
                    else
                    {
                        floor.FoundTiles++;
                    }
                }
                else
                {
                    whiteTiles.Push(white / 2);
                    greyTiles.Enqueue(grey);
                }

            }


            string whitesLeft = whiteTiles.Count == 0 ? "none" : string.Join(", ", whiteTiles);
            string greysLeft = greyTiles.Count == 0 ? "none" : string.Join(", ", greyTiles);

            Console.WriteLine($"White tiles left: {whitesLeft}");
            Console.WriteLine($"Grey tiles left: {greysLeft}");

            locations = locations.Where(x => x.FoundTiles > 0).OrderByDescending(x => x.FoundTiles)
                .ThenBy(x => x.Title).ToList(); 

            foreach (var location in locations)
            {
               
                    Console.WriteLine($"{location.Title}: {location.FoundTiles}");
          
            }
        }
    }
}
