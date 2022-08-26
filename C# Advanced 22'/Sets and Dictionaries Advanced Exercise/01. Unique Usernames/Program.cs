using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones. On the first line, you will be given an integer N. On the next N lines, you will receive one username per line. Print the collection on the console in order of insertion:

            // number of people
            int n = int.Parse(Console.ReadLine());

            var people = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                people.Add(name);
            }

            Console.WriteLine(string.Join("\n", people));
        }
    }
}
