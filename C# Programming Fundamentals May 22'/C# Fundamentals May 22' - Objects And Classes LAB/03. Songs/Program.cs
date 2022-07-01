using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a class called Song that will hold the following information about some songs:
            //•	Type List
            //•	Name
            //•	Time
            //Input / Constraints

            //Create list of songs
            List<Song> songs = new List<Song>();


            //•	On the first line, you will receive the number of songs - N.
            int numOfSongs = int.Parse(Console.ReadLine());

            //for loop to numsOfSongs
            for (int i = 0; i < numOfSongs; i++)
            {
                //•	On the next N lines, you will be receiving data in the following format:  "{typeList}_{name}_{time}"
                string[] songProps = Console.ReadLine().Split('_');

                Song song = new Song(songProps[0], songProps[1], songProps[2]);

                //Add each created song to the list
                songs.Add(song);
            }
            //•	On the last line, you will receive Type List or "all".
            string typeList = Console.ReadLine();

            //If you receive the "all" command, print out the names of all the songs.
            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            //If you receive Type List as an input on the last line, print out only the names of the songs which are from that Type List
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
    }
    class Song
    {

        //Create constructor of the Song
        public Song(string typeList, string name, string duration)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Duration = duration;
        }
        //Create the properties
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
    }
}
