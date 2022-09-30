using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reverses a collection and removes elements that are divisible by a given integer n. Use predicates/functions

            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            //if it is false the num will not be added in the list, insted of removing elements afterwards
            Predicate<int> filter = num => num % divider != 0;

            input.Reverse();

            input = AddToList(filter, input);

            Console.WriteLine(String.Join(" ", input));
        }

        static List<int> AddToList(Predicate<int> filter, List<int> input)
        {
            List<int> result = new List<int>();

            foreach (var num in input)
            {
                if (filter(num))
                {
                    result.Add(num);
                }
            }

            return result;
        }
    }
}
