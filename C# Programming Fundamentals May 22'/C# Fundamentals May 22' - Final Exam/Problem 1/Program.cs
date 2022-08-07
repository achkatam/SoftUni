using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Translate":
                        {
                            input = Translate(input, tokens);
                        }
                        break;
                    case "Includes":
                        {
                            Includes(input, tokens);
                        }
                        break;
                    case "Start":
                        {
                            Start(input, tokens);
                        }
                        break;
                    case "Lowercase":
                        input = Lowercase(input);
                        break;
                    case "FindIndex":
                        {
                            FindIndex(input, tokens);
                        }
                        break;
                    case "Remove":
                        {
                            input = Remove(input, tokens);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            // Console.WriteLine(input);

        }

        static string Remove(string input, string[] tokens)
        {
            int startIndex = int.Parse(tokens[1]);
            int count = int.Parse(tokens[2]);

            input = input.Remove(startIndex, count);

            Console.WriteLine(input);
            return input;
        }

        static void FindIndex(string input, string[] tokens)
        {
            string givenString = tokens[1];
            int index = input.LastIndexOf(givenString);

            Console.WriteLine(index);
        }

        static string Lowercase(string input)
        {
            input = input.ToLower();

            Console.WriteLine(input);
            return input;
        }

        static void Start(string input, string[] tokens)
        {
            string start = tokens[1];

            if (input.StartsWith(start))
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Includes(string input, string[] tokens)
        {
            string substring = tokens[1];
            if (input.Contains(substring))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static string Translate(string input, string[] tokens)
        {
            char character = char.Parse(tokens[1]);
            char sub = char.Parse(tokens[2]);

            input = input.Replace(character, sub);

            Console.WriteLine(input);
            return input;
        }
    }
}
