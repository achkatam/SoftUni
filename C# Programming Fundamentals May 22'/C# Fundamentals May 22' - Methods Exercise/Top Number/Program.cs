using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print all the top numbers
            //Top number is: divisible by 8 => 8, 17, 88
            //Hold at least one odd digit = 232, 707, 87578
            //Examples: 17, 161, 251, 4310, 123200

            //input
            int number = int.Parse(Console.ReadLine());

            //Output the method
            TopNumber(number);
        }
        static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                //Create boolean isOdd, currNum and check the constraints, then print all the nums
                bool isOdd = false;
                int currNum = i;
                //The sum represents the number BY SUM OF DIGITS
                int sum = 0;
                //Check the digits of the number 1 by 1
                while (currNum != 0)
                {
                    sum += currNum % 10;//Takes the last digit of the number
                    //Check the last digit if it's odd
                    if ((currNum % 10) % 2 != 0)
                    {
                        isOdd = true;
                    }
                    currNum /= 10;
                }
                //Check if the SUM of DIGITS is divisible by 8 and isOdd
                if (isOdd && sum % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}