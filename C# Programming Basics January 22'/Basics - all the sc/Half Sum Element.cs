using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (maxNum < num)
                {
                    maxNum = num;
                }
            }
            int diff = sum - maxNum; //сумата без най-голямото число

            if (diff == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {diff}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum-diff)}");
            }
        }
    }
}
