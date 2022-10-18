using System;

namespace Brute_ForceAlgorithm
{
    public class BruteForceAlgorithm
    {
        static void Main(string[] args)
        {
            //Brute - Force Algorith, - tries all possible operation adn chooses the best one - slow and ineffective
            //Imagine a 5-digit pinlock - suitcase lock
            int[] arr = { 0, 0, 0, 0, 0 };
            GeneratePin(arr, 0, 1, 9);

        }

        public static void GeneratePin(int[] arr, int index, int startVal, int endVal)
        {
            if (index == arr.Length)
            {
                //Print the array and exit the recursion
                Console.WriteLine(String.Join(", ", arr));

                return;
            }

            for (int i = startVal; i <= endVal; i++)
            {
                arr[index] = i;
                GeneratePin(arr, index + 1, startVal, endVal);
            }
        }
    }
}
