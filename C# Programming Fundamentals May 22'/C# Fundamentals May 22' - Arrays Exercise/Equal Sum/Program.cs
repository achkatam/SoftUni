using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //add-ons
            int rightSum = 0;
            int leftSum = 0;

            //Solution
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine("0");
                    return;
                }

                leftSum = 0;
                for (int leftsum = i; leftsum > 0; leftsum--)
                {
                    int nextLeftNum = leftsum - 1;
                    if (leftsum > 0)
                    {
                        leftSum += numbers[nextLeftNum];
                    }
                }
                rightSum = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    int nextRightNum = j + 1;
                    if (j < numbers.Length - 1)
                    {
                        rightSum += numbers[nextRightNum];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");

        }
    }
}
