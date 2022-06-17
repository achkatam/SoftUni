using System;
using System.Linq;
using System.Collections.Generic;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list for integers
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> gaussNums = new List<int>();

            //Iterate nums
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                //Add the i index + the last one 
                int currGaussNum = numbers[i] + numbers[numbers.Count - 1 - i];
                gaussNums.Add(currGaussNum);
            }
            //If check if counts is even or odd
            if (numbers.Count % 2 != 0)
            {
                gaussNums.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", gaussNums));
        }
    }
}
