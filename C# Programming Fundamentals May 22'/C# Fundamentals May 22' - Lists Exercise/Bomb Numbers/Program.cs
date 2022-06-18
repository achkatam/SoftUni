using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a sequence of numbers and a special bomb number holding a certain power. Your task is to detonate every occurrence of the special bomb number and according to its power the numbers to its left and right.The bomb power refers to how many numbers to the left and right will be removed, no matter their values.Detonations are performed from left to right and all the detonated numbers disappear.Finally, print the sum of the remaining elements in the sequence.

            //Create the list of numbers
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //add-ons
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNum = tokens[0];
            int power = tokens[1];

            //For loop to iterate
            for (int i = 0; i < numbers.Count; i++)
            {
                int target = numbers[i];
                if (target == bombNum)
                {
                    BombNumber(numbers, power, i);
                }
            }
            //Sum them up as an output
            Console.WriteLine(numbers.Sum()); ;
        }

        private static void BombNumber(List<int> numbers, int power, int index)
        {
            int start = Math.Max(0, index - power);//goes to the left
            int end = Math.Min(numbers.Count - 1, index + power);//goes to the right
            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
