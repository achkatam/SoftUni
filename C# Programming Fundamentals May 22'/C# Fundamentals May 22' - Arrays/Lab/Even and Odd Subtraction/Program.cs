using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //add-ons
            int oddSum = 0;
            int evenSum = 0;
            //Solution
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
