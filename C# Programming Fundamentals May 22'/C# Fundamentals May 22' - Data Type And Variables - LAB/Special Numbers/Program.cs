using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A number is special when its sum of digits is 5, 7, or 11.
            //Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).

            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                int sum = 0;
                int currentNum = i;

                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;

                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");

                }
            }

        }
    }
}
