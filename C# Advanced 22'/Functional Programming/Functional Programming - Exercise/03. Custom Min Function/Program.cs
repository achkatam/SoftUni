using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple program that reads from the console a set of integers and prints back on the console the smallest number from the collection. Use Func<T, T>.

            //create the function - receives array of integers and prints out an integer
            Func<int[], int> minNum = numbers => numbers.Min();

            Console.WriteLine(minNum(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray()));

        }
    }
}
