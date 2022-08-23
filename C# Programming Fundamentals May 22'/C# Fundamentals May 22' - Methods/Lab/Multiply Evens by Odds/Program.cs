using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            //input the number 
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEven(number);
            int oddSum = GetSumOfOdd(number);
            int multiplication = GetMultipleOfEvenAndOdd(evenSum, oddSum);
            //Output
            Console.WriteLine(multiplication);
        }
        //Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
        //•	Create a method called GetMultipleOfEvenAndOdds()
        //•	Create a method GetSumOfEvenDigits()
        //•	Create GetSumOfOddDigits()
        //•	You may need to use Math.Abs() for negative numbers
        static int GetSumOfEven(int number)
        {
            int evenSum = 0;
            int digit = number;
            // While loop to check the elements in the num until it gets lower or equal zero
            while (digit > 0)
            {
                int currentNum = digit % 10;//This will return the last digit of the number we input
                //If statement - check if the last current digit is even
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                //Take away the last digit you just checked
                digit = digit / 10;
            }
            //The loop continues until digit equals 0 or lower
            //Return the sum of All EVEN digits from the number;
            return evenSum;
        }
        static int GetSumOfOdd(int number)
        {
            int oddSum = 0;
            int digit = number;
            // While loop to check the elements in the num until it gets lower or equal zero
            while (digit > 0)
            {
                int currNum = digit % 10;// last digit 
                if (currNum % 2 != 0)
                {
                    oddSum += currNum;
                }
                //Take away the last digit you just checked
                digit /= 10;
            }
            //The loop continues until digit equals 0 or lower
            //Return the sum of All EVEN digits from the number;
            return oddSum;
        }
        static int GetMultipleOfEvenAndOdd(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
