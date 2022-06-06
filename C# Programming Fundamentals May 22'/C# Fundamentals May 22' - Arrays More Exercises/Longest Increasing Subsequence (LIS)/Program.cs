using System;
using System.Linq;

namespace Longest_Increasing_Subsequence__LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create arrays for sequence, lis, length, previousNum
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lis;
            int[] length = new int[sequence.Length];
            int[] previousNum = new int[sequence.Length];//previous element in the array
            //add - ons for maxLenght and the last index
            int maxLength = 0;
            int lastIndex = -1;

            //Check the elements in the array sequence.Length by for loop
            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                previousNum[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (j == i)// If this is true the loop is invalid
                    {
                        continue;
                    }
                    if (sequence[j] < sequence[i] && length[i] <= length[j])
                    {
                        length[i] = 1 + length[j];
                        previousNum[i] = j; //Takes the index vlue from the largest element
                    }
                }
                if (length[i] > maxLength)
                {
                    maxLength = length[i];//Save the value of max count of elements
                    lastIndex = i;// Represents the last index of the array
                }
            }
            lis = new int[maxLength]; // lis[] takes the values of maxLength
            //Checks the elements of maxLength[] array 
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = sequence[lastIndex];
                lastIndex = previousNum[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
