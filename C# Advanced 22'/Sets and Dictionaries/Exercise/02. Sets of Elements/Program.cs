using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints a set of elements. On the first line, you will receive two numbers - n and m, which represent the lengths of two separate sets. On the next n + m lines, you will receive n numbers, which are the numbers in the first set, and m numbers, which are in the second set. Find all the unique elements that appear in both of them and print them in the order in which they appear in the first set - n.
            //For example:
            //Set with length n = 4: { 1, 3, 5, 7}
            //Set with length m = 3: { 3, 4, 5}
            //Set that contains all the elements that repeat in both sets -> { 3, 5}

            //variable for input
            string input = Console.ReadLine();

            int n = int.Parse(input.Split(" ")[0]);
            int m = int.Parse(input.Split(" ")[1]);

            //Create sets
            var firstSet = new HashSet<int>();
            //add the nums in the first set
            for (int i = 0; i < n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            //add the nums in the second set
            var secSet = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
               secSet.Add(int.Parse(Console.ReadLine()));
            }

            //check if there is any unique elements using .IntersectWith
            //that function filters the elements in the firstSet with the unique ones only
            firstSet.IntersectWith(secSet);

            //Print output
            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
