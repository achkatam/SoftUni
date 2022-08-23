using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //string[] input = Console.ReadLine().Split();
            //double[] numbers = new double[input.Length];

            //First solution
            //for (int i = 0; i < input.Length; i++)
            //{
            //    numbers[i] = double.Parse(input[i]);
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            //}

            //Second Attempt
            //input
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNum = new int[numbers.Length];

            //Solution
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNum[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedNum[i]}");
            }
        }
    }
}
