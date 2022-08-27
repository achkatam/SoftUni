using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create nested dictionary<name of a vlogger<Vlogger(followers, followings)>>
            var vloggers = new Dictionary<string, Vlogger>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                var tokens = command.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries);

                var nameOne = tokens[0];
                var cmd = tokens[1];
                var nameTwo = tokens[2];

                switch (cmd)
                {
                    case "joined":
                        if (!vloggers.ContainsKey(nameOne))
                        {
                            vloggers.Add(nameOne, new Vlogger());
                        }
                        break;
                    case "followed":
                        if (vloggers.ContainsKey(nameOne)
                            && vloggers.ContainsKey(nameTwo)
                            && nameOne != nameTwo)
                        {
                            vloggers[nameOne].Following.Add(nameTwo);
                            vloggers[nameTwo].Followers.Add(nameOne);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            //Each vlogger has a unique vloggername. Vloggers can follow other vloggers and a vlogger can follow as many other vloggers as he wants, but he cannot follow himself or follow someone he is already a follower of. You need to print the total count of vloggers in your collection. Then you have to print the most famous vlogger – the one with the most followers, with his followers. If more than one vloggers have the same number of followers, print the one following fewer people, and his followers should be printed in lexicographical order (in case the vlogger has no followers, print just the first line, which is described below). Lastly, print the rest of the vloggers, ordered by the count of followers in descending order, then by the number of vloggers he follows in ascending order. The whole output must be in the following format:
            vloggers = vloggers.OrderByDescending(x => x.Value.Followers.Count)
                .ThenBy(x => x.Value.Following.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            //PrintOutput
            PrintOutput(vloggers);

        }

        static void PrintOutput(Dictionary<string, Vlogger> vloggers)
        {
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            Console.WriteLine($"1. {vloggers.First().Key} : {vloggers.First().Value.Followers.Count} followers, {vloggers.First().Value.Following.Count} following");

            foreach (var follower in vloggers.First().Value.Followers.OrderBy(x => x))
            {
                Console.WriteLine($"*  {follower}");
            }

            vloggers.Remove(vloggers.First().Key);

            //counter for vloggers starting from 2
            int counter = 2;

            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
            {
                //{No}. {vlogger} : {followers} followers, {followings} following
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");

                counter++;
            }
        }
    }
    class Vlogger
    {
        //Use HashSet because vloggers' usernames are unique
        public Vlogger()
        {
            Followers = new HashSet<string>();
            Following = new HashSet<string>();
        }
        public HashSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }
    }
}
