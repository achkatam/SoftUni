using System;
using System.Linq;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a number that represents how many lines we will get as input.On the next N lines, you will receive a string with 2 numbers separated by a single space. You need to compare them.If the left number is greater than the right number, you need to print the sum of all digits in the left number, otherwise, print the sum of all digits in the right number.

            //input
            int n = int.Parse(Console.ReadLine());

            //Attempt solution
            //add-ons
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] num = input.Split(' ');
                long firstNum = long.Parse(num[0]);
                long secondNum = long.Parse(num[1]);

                if(firstNum > secondNum)
                {
                    while (firstNum !=0)
                    {
                        sum += firstNum % 10;
                        firstNum /= 10;
                    }
                    Console.WriteLine($"{Math.Abs(sum)}");
                    sum = 0;
                }
                else if (firstNum <= secondNum)
                {
                    while (secondNum !=0)
                    {
                        sum += secondNum % 10;
                        secondNum /= 10;
                    }
                    Console.WriteLine($"{Math.Abs(sum)}");
                    sum = 0;
                }
            }
        }
    }
}
