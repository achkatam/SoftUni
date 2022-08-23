using System;
using System.Linq;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input for the Fibonacci number
            int inputNum = int.Parse(Console.ReadLine());

            ////Solution using class
            //Console.WriteLine(GetFibonacciNum(inputNum));

            //Create an array
            int[] numbers = new int[inputNum];

            //Solution using recursive method

            //Creating For loop which follow the all the numbers in the array numbers[]
            for (int nums = 0; nums < numbers.Length; nums++)
            {
                if (nums == 0 || nums == 1)
                {
                    numbers[nums] = 1;
                }
                else
                {
                    numbers[nums] = numbers[nums - 1] + numbers[nums - 2];
                }
                
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
        //static int GetFibonacciNum(int inputNum)
        //{
        //    //Created a new class which contains the formula 
        //    if (inputNum == 1 || inputNum == 2)
        //    {
        //        return 1;
        //    }
        //    return GetFibonacciNum(inputNum - 1) + GetFibonacciNum(inputNum - 2);
        //}
    }
}
