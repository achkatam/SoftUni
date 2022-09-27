using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a line of integers separated by ", ". Print on two lines the count of numbers and their sum.

            //our parsing function
            Func<string, int> parser = n => int.Parse(n);
            int[] nums = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}
