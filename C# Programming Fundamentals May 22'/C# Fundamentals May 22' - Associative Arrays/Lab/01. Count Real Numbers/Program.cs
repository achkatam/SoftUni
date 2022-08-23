using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers and print them in ascending order, along with their number of occurrences.

            Dictionary<int, int> occurenciesByNumber = new Dictionary<int, int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (!occurenciesByNumber.ContainsKey(number))
                {
                    occurenciesByNumber.Add(number, 0);
                }
                
                occurenciesByNumber[number]++;
            }
            foreach (var item in occurenciesByNumber.OrderBy(x=>x.Key))
            {

                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
