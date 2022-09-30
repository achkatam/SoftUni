using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a collection of names as strings from the console, appends "Sir" in front of every name and prints it back in the console. Use Action<T>.

            Action<string> print = input => Console.WriteLine("Sir" + " " + input);

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
