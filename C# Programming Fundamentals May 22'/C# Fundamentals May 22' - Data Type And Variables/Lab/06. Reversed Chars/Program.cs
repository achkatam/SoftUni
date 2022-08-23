using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that takes 3 lines of characters and prints them in reversed order with a space between them.

            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            Console.WriteLine($"{third} {second} {first}");
        }
    }
}
