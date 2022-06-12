using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //Output
            Console.WriteLine(string.Join(" ", TribonacciSequence(num)));
        }
        static int[] TribonacciSequence(int number)
        {
            //Create array so we can check the elements 1 by 1, using For loop
            int[] tribonacciArray = new int[number];

            for (int num = 0; num < tribonacciArray.Length; num++)
            {
                if (num == 0 || num == 1)
                {
                    tribonacciArray[num] = 1;
                }
                else if (num == 2)
                {
                    tribonacciArray[num] = 2;
                }
                else
                {
                    tribonacciArray[num] = tribonacciArray[num - 3] +
                        tribonacciArray[num - 2] + tribonacciArray[num - 1];
                }
            }
            return tribonacciArray;
        }
    }
}
