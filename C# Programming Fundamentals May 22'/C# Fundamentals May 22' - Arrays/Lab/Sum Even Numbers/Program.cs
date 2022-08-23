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
            int sum = 0;
            //Solution
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
