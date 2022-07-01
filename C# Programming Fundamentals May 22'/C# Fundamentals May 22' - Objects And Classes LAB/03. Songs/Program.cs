using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input / Constraints
            //•	On the last line, you will receive Type List or "all".
            int songCount = int.Parse(Console.ReadLine());
            //•	On the first line, you will receive the number of songs - N.

            //Create list for the songs
            List<Song> songs = new List<Song>();

            //For loop to iterate thru the loop
            for (int i = 0; i < songCount; i++)
            {
                //•	On the next N lines, you will be receiving data in the following format:  "{typeList}_{name}_{time}"
                string[] tokens = Console.ReadLine().Split('_');
                Song song = new Song(tokens[0], tokens[1], tokens[2]);

                songs.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var song  in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name) ;
                    }
                }
            }

        }
    }
    //Define a class called Song that will hold the following information about some songs:
    //•	Type List
    //•	Name
    //•	Time
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
