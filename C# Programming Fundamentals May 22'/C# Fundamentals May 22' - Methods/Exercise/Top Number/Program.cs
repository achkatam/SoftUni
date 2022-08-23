using System;

namespace Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            // A top number is an integer that holds the following properties:
            //•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
            //•	Holds at least one odd digit, e.g. 232, 707, 87578
            //•	Some examples of top numbers are: 17, 161, 251, 4310, 123200
            //You will receive a single integer from the console, representing the end value. Examples

            //input
            int integer = int.Parse(Console.ReadLine());

            //Output
            TopNumber(integer);
        }

        static void TopNumber(int num)
        {
            //Start with For loop, create boolean isOdd,int sum and int currNum
            for (int i = 1; i <= num; i++)
            {
                //boolean
                bool isOdd = false;
                //sum
                int sum = 0;

                int currNum = i;
                while (currNum != 0)
                {
                    sum += currNum % 10;//this variable sums up the digits in num
                    if ((currNum % 10) % 2 != 0) isOdd = true; // Check if the last digit taken is odd or even
                    currNum /= 10;//removes the last digit of the num
                }
                //Check if the sum is divisible by and isOdd = true
                if (sum % 8 == 0 && isOdd) Console.WriteLine(i);
            }
        }
    }
}
