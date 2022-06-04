using System;
using System.Linq;

namespace _8._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int givenNum = int.Parse(Console.ReadLine());

            //Solution

            for (int i = 0; i < num.Length; i++)
            {
                //int number = num[i];
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] + num[j] == givenNum)
                    {
                        Console.WriteLine($"{num[i]} {num[j]}");
                    }
                }
            }
        }
    }
}
