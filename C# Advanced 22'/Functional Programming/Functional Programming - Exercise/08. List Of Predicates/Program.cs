using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find all numbers in the range 1…N that are divisible by the numbers of a given sequence. On the first line, you will be given an integer N – which is the end of the range. On the second line, you will be given a sequence of integers which are the dividers. Use predicates/functions.

            var predicate = new List<Predicate<int>>();

            int maxNum = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();

            int[] numbers = Enumerable.Range(1, maxNum).ToArray();

            foreach (var divider in dividers)
            {
                predicate.Add(x => x % divider == 0);
            }

            foreach (var num in numbers)
            {
                bool isDivisible = true;

                foreach (var match in predicate)
                {
                    if (!match(num))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{num} ");
                }
            }


        }
    }
}
