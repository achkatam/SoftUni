using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives a single integer. Your task is to find the sum of its digits.
            //For example: 12345-> 1 + 2 + 3 + 4 + 5 = 15

            //First attempt
            //input
            //int numInput = int.Parse(Console.ReadLine());
            //int finalSum = 0;
            //while (numInput !=0)
            //{
            //    int lastDigit = numInput % 10;
            //    finalSum += lastDigit;
            //    numInput /= 10;
            //}
            //Console.WriteLine(finalSum);

            //Second attempt

            //input
            string input = Console.ReadLine();
            int finalSum = 0;
            char[] charArray = input.ToCharArray();

            for (int value = 0; value < charArray.Length; value++)
            {
                finalSum += int.Parse(charArray[value].ToString());
            }
            Console.WriteLine(finalSum);
        }
    }
}
