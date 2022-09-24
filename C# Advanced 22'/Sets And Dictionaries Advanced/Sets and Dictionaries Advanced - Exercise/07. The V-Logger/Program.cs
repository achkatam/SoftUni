using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;
using System.Xml;

namespace _07._The_V_Logger
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Create a program that keeps the information about vloggers and their followers. The input will come as a sequence of strings, where each string will represent a valid command. The commands will be presented in the following format:
            //•	"{vloggername}" joined The V - Logger – keep the vlogger in your records.
            //o Vloggernames consist of only one word.
            //o If the given vloggername already exists, ignore that command.

            //•	"{vloggername} followed {vloggername}" – The first vlogger followed the second vlogger.
            //o If any of the given vlogernames does not exist in your collection, ignore that command.
            //o Vlogger cannot follow himself.
            //o Vloggers cannot follow someone he is already a follower of.
            //•	"Statistics" - Upon receiving this command, you have to print a statistic about the vloggers.
            //Each vlogger has a unique vloggername. Vloggers can follow other vloggers and a vlogger can follow as many other vloggers as he wants, but he cannot follow himself or follow someone he is already a follower of. You need to print the total count of vloggers in your collection. Then you have to print the most famous vlogger – the one with the most followers, with his followers. If more than one vloggers have the same number of followers, print the one following fewer people, and his followers should be printed in lexicographical order(in case the vlogger has no followers, print just the first line, which is described below). Lastly, print the rest of the vloggers, ordered by the count of followers in descending order, then by the number of vloggers he follows in ascending order. The whole output must be in the following format:
            //"The V-Logger has a total of {registered vloggers} vloggers in its logs.
            //1. { mostFamousVlogger} : { followers}
            //            followers, { followings} following           //*  { follower1}          //            *  { follower2} … 
            //{ No}. { vlogger} : { followers}
            //            followers, { followings}
            //            following
            //{ No}. { vlogger} : { followers}
            //            followers, { followings}
            //            following…"


            var vloggers = new List<Vlogger>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {

                var tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[1];
                if (cmd == "joined")
                {
                    string user = tokens[0];
                    string joined = tokens[2];

                    var vlogger = new Vlogger(user);
                    if (vloggers.Any(x => x.Name == user))
                    {
                        command = Console.ReadLine();

                        continue;
                    }

                    vloggers.Add(vlogger);
                    vlogger.Name = user;
                    vlogger.Followers = new SortedSet<string>();
                    vlogger.Followings = new SortedSet<string>();

                }
                else if (cmd == "followed")
                {
                    string user = tokens[0];
                    string toFollow = tokens[2];

                    if (user == toFollow)
                    {
                        command = Console.ReadLine();

                        continue;
                    }

                    if (vloggers.Any(x => x.Name == user) && vloggers.Any(x => x.Name == toFollow))
                    {
                        Vlogger vloggerFollowing = vloggers.First(v => v.Name == user);
                        vloggerFollowing.AddFollowing(toFollow);

                        Vlogger vloggerFollower = vloggers.First(v => v.Name == toFollow);
                        vloggerFollower.AddFollower(user);
                    }
                }

                command = Console.ReadLine();
            }

            vloggers = vloggers
                .OrderByDescending(v => v.Followers.Count)
                .ThenBy(v => v.Followings.Count)
                .ToList();

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in vloggers)
            {
                Console.WriteLine($"{counter}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Followings.Count} following");
                if (counter == 1)
                {
                    foreach (var follower in vlogger.Followers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                counter++;
            }

        }
    }
    class Vlogger
    {
        public Vlogger(string name)
        {
            Name = name;
            Followers = new SortedSet<string>();
            Followings = new SortedSet<string>();
        }
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; }
        public SortedSet<string> Followings { get; set; }

        public void AddFollower(string name)
        {
            Followers.Add(name);
        }

        public void AddFollowing(string name)
        {
            Followings.Add(name);
        }
    }
}
