using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double result =Factorial(firstNum);
            double result2 = Factorial(secondNum);
            PrintResult(result, result2);
        }

        private static void PrintResult(double result, double result2)
        {
            Console.WriteLine($"{result/ result2:f2}");
        }

        private static double Factorial(int number)
        {
            double result = 1;//Factorials always start from 1
            while (number!=1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}
