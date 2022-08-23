using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //add-ons
            int sum = 0;
            //Solution
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    Console.WriteLine("Arrays are not identical. Found difference at {0} index", index);
                    Environment.Exit(0);
                }
                else
                {
                    sum += firstArray[index];
                }
            }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
