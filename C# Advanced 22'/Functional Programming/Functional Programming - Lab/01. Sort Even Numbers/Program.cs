using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads one line of integers separated by ", ". Then prints the even numbers of that sequence sorted in increasing order.
            Console.WriteLine(String.Join(", ",
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray()));
        }
    }
}
