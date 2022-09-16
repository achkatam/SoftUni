using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps track of a song's queue. The first song that is put in the queue, should be the first that gets played. A song cannot be added if it is currently in the queue.
            //You will be given a sequence of songs, separated by a comma and a single space.After that, you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.

            //variable for input songs
            var input = Console.ReadLine().Split(", "
                , StringSplitOptions.RemoveEmptyEntries).ToArray();

            //create the queue
            var songs = new Queue<string>(input);


            //while songs.Count() > 0
            while (songs.Any())
            {
                var tokens = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Play":
                        Play(songs);
                        break;
                    case "Add":
                        string addSong = string.Join(" ", tokens.Skip(1));

                        AddSong(songs, addSong, tokens);
                        break;
                    case "Show":
                        Show(songs);
                        break;
                }
            }

            Console.WriteLine($"No more songs!");
        }

        static void Show(Queue<string> songs)
        {
            Console.WriteLine(string.Join(", ", songs));
        }

        static void Play(Queue<string> songs)
        {
            songs.Dequeue();
        }
        static void AddSong(Queue<string> songs, string addSong, string[] tokens)
        {
            string song = string.Join(" ", tokens.Skip(1));
            if (!songs.Contains(song))
            {
                songs.Enqueue(song);

                return;
            }

            Console.WriteLine($"{song} is already contained!");
        }
    }
}
