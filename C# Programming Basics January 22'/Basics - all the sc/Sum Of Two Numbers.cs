using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            //add-ins
            int combinationCounter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {

                    combinationCounter++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNum})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNum}");

        }
    }
}
