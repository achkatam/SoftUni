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
            //Array of special numbers.. 
            int[] specialNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //special bomb number holding a certain power
            int bombNum = (specialNum[0]);
            int power = specialNum[1];

            //For loops to iterate through the list

            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                if (currNum == bombNum)
                {
                    //Initialize startIndex and endIndex
                    int startIndex = i - power;
                    int endIndex = i + power;
                    //Always keep the index in the arrays bounds
                    if (startIndex < 0) startIndex = 0;
                    if (endIndex > numbers.Count - 1) endIndex = numbers.Count - 1;

                    int numToBeRemoved = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, numToBeRemoved);
                    i = startIndex - 1;
                }
            }
            //Finally, print the sum of the remaining elements in the sequence.
            Console.WriteLine(numbers.Sum());
        }
    }
}
