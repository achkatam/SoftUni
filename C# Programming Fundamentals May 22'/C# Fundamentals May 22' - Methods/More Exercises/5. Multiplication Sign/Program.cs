using System;

namespace _5._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a number num1, num2, and num3.Write a program that finds if num1 * num2 * num3(the product) is negative, positive, or zero. Try to do this WITHOUT multiplying the 3 numbers.
            string product = string.Empty;

            Console.WriteLine(Numbers(product));

        }
        static string Numbers(string product)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            product = string.Empty;
            //
            int[] numbers = { num1, num2, num3 };
            //counter for negative - * - = +
            int negativeCnt = 0;

            //boolean for zero
            bool isZero = false;
            //boolean for negative
            bool isNegative = false;

            //Check with for loop
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0) negativeCnt++;
                if (numbers[i] == 0) isZero = true;
            }


            if (negativeCnt == 1 || negativeCnt == 3)
            {
                isNegative = true;
            }
            //
            if (isZero)
            {
                product = "zero";
            }
            else if (isNegative)
            {
                product = "negative";
            }
            else
            {
                product = "positive";
            }


            return product;
        }
    }
}
