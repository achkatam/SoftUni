using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints a number from a collection, which appears an even number of times in it. On the first line, you will be given n – the count of integers you will receive. On the next n lines, you will be receiving the numbers. It is guaranteed that only one of them appears an even number of times. Your task is to find that number and print it in the end. 

            //Dictionary<int, int> number, occurencies
            var numbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(num)) numbers.Add(num, 0);

                numbers[num]++;
            }

            foreach (var num in numbers.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(num.Key);
            }

            //Console.WriteLine(numbers.Single(x => x.Value % 2 == 0).Key);
        }
    }
}
