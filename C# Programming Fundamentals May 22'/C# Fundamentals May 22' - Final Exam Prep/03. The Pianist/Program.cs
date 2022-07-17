using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the standard input, you will receive an integer n – the number of pieces you will initially have. On the next n lines, the pieces themselves will follow with their composer and key, separated by "|" in the following format: "{piece}|{composer}|{key}".

            var pianist = new Dictionary<string, Symphony>();

            //variable for count of pianists
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split('|'
                    , StringSplitOptions.RemoveEmptyEntries);

                string symphonyName = input[0];
                string author = input[1];
                string key = input[2];

                pianist.Add(symphonyName, new Symphony(symphonyName, author, key));
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] token = command.Split('|'
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = token[0];

                string symphonyName = token[1];

                switch (cmd)
                {
                    case "Add":
                        Add(pianist, token);
                        break;
                    case "Remove":
                        Remove(pianist, token);
                        break;
                    case "ChangeKey":
                        ChangeKey(pianist, token);
                        break;
                }

                command = Console.ReadLine();
            }
            //Upon receiving the "Stop" command, you need to print all pieces in your collection in the following format:
            //"{Piece} -> Composer: {composer}, Key: {key}"

            //Console.WriteLine(string.Join('\n',
            //    pianist.Select(x => $"{x.Key} -> Composer: {x.Value.Author}, Key: {x.Value.Key}")));

            foreach (var symphony in pianist)
            {
                Console.WriteLine($"{symphony.Key} -> Composer: {symphony.Value.Author}, Key: {symphony.Value.Key}");
            }
        }

        static void ChangeKey(Dictionary<string, Symphony> pianist, string[] token)
        {
            //•	"ChangeKey|{piece}|{new key}":
            //o If the piece is in the collection, change its key with the given one and print:
            //"Changed the key of {piece} to {new key}!"
            //o Otherwise, print:
            //"Invalid operation! {piece} does not exist in the collection."
            if (!pianist.ContainsKey(token[1]))
            {
                Console.WriteLine($"Invalid operation! {token[1]} does not exist in the collection.");
                return;
            }

            pianist[token[1]].Key = token[2];
            Console.WriteLine($"Changed the key of {token[1]} to {token[2]}!");
        }

        static void Remove(Dictionary<string, Symphony> pianist, string[] token)
        {
            //•	"Remove|{piece}":
            //o If the piece is in the collection, remove it and print:
            //"Successfully removed {piece}!"
            //o Otherwise, print:
            //"Invalid operation! {piece} does not exist in the collection."
            if (!pianist.ContainsKey(token[1]))
            {
                Console.WriteLine($"Invalid operation! {token[1]} does not exist in the collection.");
                return;
            }

            pianist.Remove(token[1]);
            Console.WriteLine($"Successfully removed {token[1]}!");
        }

        static void Add(Dictionary<string, Symphony> pianist, string[] token)
        {
            //•	"Add|{piece}|{composer}|{key}":
            //o You need to add the given piece with the information about it to the other pieces and print:
            //"{piece} by {composer} in {key} added to the collection!"
            //o If the piece is already in the collection, print:
            //"{piece} is already in the collection!"
            if (pianist.ContainsKey(token[1]))
            {
                Console.WriteLine($"{token[1]} is already in the collection!");
                return;
            }

            pianist[token[1]] = new Symphony(token[1], token[2], token[3]);
            Console.WriteLine($"{token[1]} by {token[2]} in {token[3]} added to the collection!");
        }
    }
    class Symphony
    {
        public Symphony(string name, string author, string key)
        {
            Name = name;
            Author = author;
            Key = key;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Key { get; set; }
    }
}
