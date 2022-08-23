using System;
using System.Collections.Generic;
using System.Linq;


namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. If there are no elements left in the list, print "empty".

            //First create List of integers
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //Easier
            numbers.RemoveAll(number => number < 0);
            numbers.Reverse();

            //Using for cycle to iterate all nums
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] < 0)
            //    {
            //        numbers.RemoveAt(i);
            //        i--;
            //    }
            //}
            //numbers.Reverse();
            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }
            Console.WriteLine("empty");

        }
    }
}
