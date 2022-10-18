using System;

namespace ArraySumUsingRecursion
{
    internal class ArraySumUsingRecursion
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            long sum = Sum(arr, 0);

            Console.WriteLine(sum);
        }

        static long Sum(int[] arr, int startIndex)
        {
            Console.WriteLine("Enter: index = " + startIndex );
            if (startIndex == arr.Length - 1)
            {
                //Bottom of the recursion
                Console.WriteLine("Bottom -> Exit");
                return arr[startIndex];
            }

            long sum = arr[startIndex] + Sum(arr, startIndex + 1);
            Console.WriteLine("Exit: index = " + startIndex);
            return sum;
        }
    }
}
