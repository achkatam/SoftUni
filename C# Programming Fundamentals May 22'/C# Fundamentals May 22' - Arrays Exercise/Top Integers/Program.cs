using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] inputArray = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //Solution

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool greaterCurrNum = true;
                for (int j = i+1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        greaterCurrNum = false;
                        break;
                    }
                }
                if (greaterCurrNum)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }
        }
    }
}
