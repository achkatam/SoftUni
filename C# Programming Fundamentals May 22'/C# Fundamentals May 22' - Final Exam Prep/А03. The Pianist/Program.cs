using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace А03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the standard input, you will receive an integer n – the number of pieces you will initially have. On the next n lines, the pieces themselves will follow with their composer and key, separated by "|" in the following format: "{piece}|{composer}|{key}".
            //variable for number of pieces
            int num = int.Parse(Console.ReadLine());

            var pieces = new Dictionary<string, Piece>();

            for (int i = 0; i < num; i++)
            {
                string[] composerInfo = Console.ReadLine().Split("|",
                    StringSplitOptions.RemoveEmptyEntries);
                string symphonyName = composerInfo[0];
                string author = composerInfo[1];
                string key = composerInfo[2];

                pieces.Add(symphonyName, new Piece(symphonyName, author, key));
            }

            //Then, you will be receiving different commands, each on a new line, separated by "|", until the "Stop" command is given:
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command.Split('|'
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Add":
                        //•	"Add|{piece}|{composer}|{key}":
                        Add(tokens, pieces);
                        break;
                    case "Remove":
                        Remove(tokens, pieces);
                        break;
                    case "ChangeKey":
                        ChangeKey(tokens, pieces);
                        break;
                }

                command = Console.ReadLine();
            }

            //Upon receiving the "Stop" command, you need to print all pieces in your collection in the following format:
            //"{Piece} -> Composer: {composer}, Key: {key}"
            Console.WriteLine(string.Join("\n", pieces
                .Select(x => $"{x.Value.Symphony} -> Composer: {x.Value.Author}, Key: {x.Value.Key}")));

        }

        static void ChangeKey(string[] tokens, Dictionary<string, Piece> pieces)
        {
            //•	"ChangeKey|{piece}|{new key}":
            //o If the piece is in the collection, change its key with the given one and print:
            string piece = tokens[1];
            string key = tokens[2];
            if (pieces.ContainsKey(piece))
            {
                pieces[piece].Key = key;

                Console.WriteLine($"Changed the key of {piece} to {key}!");
                return;
            }
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            return;
        }

        static void Remove(string[] tokens, Dictionary<string, Piece> pieces)
        {
            //•	"Remove|{piece}":
            //o If the piece is in the collection, remove it and print:
            string piece = tokens[1];
            if (pieces.ContainsKey(piece))
            {
                pieces.Remove(piece);

                Console.WriteLine($"Successfully removed {piece}!");
                return;
            }
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            return;

        }

        static void Add(string[] tokens, Dictionary<string, Piece> pieces)
        {
            //o You need to add the given piece with the information about it to the other pieces and print:
            //"{piece} by {composer} in {key} added to the collection!"
            string piece = tokens[1];
            string composer = tokens[2];
            string key = tokens[3];

            if (!pieces.ContainsKey(piece))
            {
                pieces.Add(piece, new Piece(piece, composer, key));

                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                return;
            }
            Console.WriteLine($"{piece} is already in the collection!");
            return;
            //o If the piece is already in the collection, print:
            //"{piece} is already in the collection!"
        }
    }
    class Piece
    {
        public Piece(string symphonyName, string author, string key)
        {
            Symphony = symphonyName;
            Author = author;
            Key = key;
        }

        public string Symphony { get; set; }
        public string Author { get; set; }
        public string Key { get; set; }
        public override string ToString() => $"{this.Symphony} -> Composer: {this.Author}, Key: {this.Key}";
    }
}
