using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a program that counts in a given array of double values the number of occurrences of each value

            //input
            var nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n))
                .ToArray();

            //create dictionary         -number, occurencies
            var numbers = new Dictionary<double, int>();

            foreach (double num in nums)
            {
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 0);
                }

                numbers[num]++;
            }

            foreach (var (number,occurencies) in numbers)
            {
                Console.WriteLine($"{number} - {occurencies} times");
            }

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine($"{num.Key} - {num.Value} times");
            //}
        }
    }
}
