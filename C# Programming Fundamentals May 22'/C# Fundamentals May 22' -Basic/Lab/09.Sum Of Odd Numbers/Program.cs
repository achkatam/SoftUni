﻿using System;

namespace _09.Sum_Of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Create a program that prints on a new line the next n odd numbers(starting from 1).On the last row print the sum of all n odd numbers.
            //Input
            //A single number n is read from the console, indicating how many odd numbers need to be printed.
            //Output
            //Print the next n odd numbers, starting from 1, separated by new lines.On the last line, print the sum of these numbers.
            //Constraints
            //•	n will be in the interval[1…100]

            int countOfOddNums = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < countOfOddNums; i++)
            {

                int currentOddNum = 1 + (i * 2);

                Console.WriteLine(currentOddNum);
                sum += currentOddNum;
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
