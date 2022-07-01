using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a number N in the range [0 - 1000]. Calculate the Factorial of N and print out the result.

            int number = int.Parse(Console.ReadLine());

                BigInteger factorial = 1;
            //for loop starts from 2, factorial of 1 is 1
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
