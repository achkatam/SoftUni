using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints a set of elements. On the first line, you will receive two numbers - n and m, which represent the lengths of two separate sets. On the next n + m lines, you will receive n numbers, which are the numbers in the first set, and m numbers, which are in the second set. Find all the unique elements that appear in both of them and print them in the order in which they appear in the first set - n.
            //For example:
            //Set with length n = 4: { 1, 3, 5, 7}
            //Set with length m = 3: { 3, 4, 5}
            //Set that contains all the elements that repeat in both sets -> { 3, 5}

            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();

            var counts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();

            for (int i = 0; i < counts[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < counts[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }


            //sets a new HashSet
            //set1.UnionWith(set2);

            //takes the equal elements
            set1.IntersectWith(set2);

            Console.WriteLine(String.Join(" ", set1));
        }
    }
}
