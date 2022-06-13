using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two integers.Calculate the factorial of each number. Divide the first result by the second and print the result of the division formatted to the second decimal point.

            //input
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            //variables for the factorials of the two nums
            double result = FactorialNum(firstNum);
            double result2 = FactorialNum(secondNum);

            //Output printing
            PrintTheResult(result, result2);

        }
        static void PrintTheResult(double result, double result2)
        {
            Console.WriteLine($"{result / result2:f2}");
        }

        static double FactorialNum(int num)
        {
            //Only 1 method is enough for 2 nums, this gives us just the formula.
            //Mind that th factorials always start from 1
            double result = 1;

            while (num != 1)
            {
                result *= num;
                num--;
            }
            return result;
        }
    }
}
