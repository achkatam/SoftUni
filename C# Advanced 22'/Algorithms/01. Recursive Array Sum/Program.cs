using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            long sum = SumArrayRecursive(array, 0);

            Console.WriteLine(sum);
        }

        public static long SumArrayRecursive(int[] array, int startIndex)
        {
            if (startIndex == array.Length - 1)
            {
                //Bottom
                return array[startIndex];
            }

            long sum = array[startIndex] + SumArrayRecursive(array,startIndex + 1);
            
            return sum;
        }
    }
}
