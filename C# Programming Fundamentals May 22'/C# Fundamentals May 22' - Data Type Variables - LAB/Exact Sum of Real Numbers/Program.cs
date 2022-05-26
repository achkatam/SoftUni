using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program to enter n numbers and calculate and print their exact sum(without rounding).

            int count = int.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 0; i < count; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);

        }
    }
}
