using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class called Song that will hold the following information about some songs:
            //•	Type List
            //•	Name
            //•	Time
            //Input / Constraints
            //•	On the first line, you will receive the number of songs -N.
            int numOfSongs = int.Parse(Console.ReadLine());

            //List of songs
            List<Song> songs = new List<Song>();

            //For loop
            for (int i = 0; i < numOfSongs; i++)
            {
                //•	On the next N lines, you will be receiving data in the following format: "{typeList}_{name}_{time}"
                string[] cmd = Console.ReadLine().Split("_");


                //songType = cmd[0], songName= cmd[1], songDuration=cmd[2]
                var song = new Song(cmd[0], cmd[1], cmd[2]);

                //Add the song in the created list of songs
                songs.Add(song);
            }
            //•	On the last line, you will receive Type List or "all".
            string typeList = Console.ReadLine();

            //If you receive Type List as an input on the last line, print out only the names of the songs which are from that Type List. If you receive the "all" command, print out the names of all the songs.

            if (typeList == "all") songs.ToList().ForEach(song => Console.WriteLine(song.Name));
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == typeList) Console.WriteLine(song.Name);
                }
            }
        }
    }
    class Song
    {
        public Song(string typeList, string name, string duration)
        {
            TypeList = typeList;
            Name = name;
            Time = duration;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
