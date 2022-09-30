using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that traverses a collection of names and returns the first name, whose sum of characters is equal to or larger than a given number N, which will be given on the first line. Use a function that accepts another function as one of its parameters. Start by building a regular function to hold the basic logic of the program. Something along the lines of Func<string, int, bool>. Afterward, create your main function which should accept the first function as one of its parameters.

            int length = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //name, int to compare, T/F
            Func<string, int, bool> lengthOfName = (name, length) =>
            {
                int sum = 0;
                foreach (var character in name)
                {
                    sum += character;

                    if (sum >= length)
                    {
                        return true;
                    }

                }
                    return false;
            };


            string name = GetName(lengthOfName, names, length);

            Console.WriteLine(name);
        }

        static string GetName(Func<string, int, bool> lengthOfName, List<string> names, int length)
        {
            foreach (var name in names)
            {
                if (lengthOfName(name, length))
                {
                    return name;
                }
            }

            return null;
        }
    }
}
