using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that filters a list of names according to their length. On the first line, you will be given an integer n, representing a name's length. On the second line, you will be given some names as strings separated by space. Write a function that prints only the names whose length is less than or equal to n.

            // representing a name's length
            int length = int.Parse(Console.ReadLine());

            Predicate<string> nameLength = name => name.Length <= length;

            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in names)
            {
                if (nameLength(name))
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
