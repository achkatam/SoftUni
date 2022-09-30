using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a collection of strings from the console and then prints them onto the console. Each name should be printed on a new line. Use Action<T>.

            //input
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = input => Console.WriteLine(input) ;

            foreach (var name in input)
            {
                print(name);
            }
        }

    }
}
