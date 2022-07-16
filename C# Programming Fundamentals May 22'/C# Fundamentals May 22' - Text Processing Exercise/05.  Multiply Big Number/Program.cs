using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _05.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given two lines – the first one can be a really big number (0 to 1050). The second one will be a single-digit number (0 to 9). Your task is to display the product of these numbers.
            //Note: do not use the BigInteger class.

            string bigNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());


            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int reminder = 0;

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                //Convert the string bigNum into integer
                int digit = int.Parse(bigNum[i].ToString());

                int result = digit * multiplier + reminder;
                //Return the last digit of the number
                sb.Append(result % 10);

                reminder = result / 10;
            }

            if (reminder != 0)
            {
                sb.Append(reminder);
            }

            StringBuilder reversed = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversed.Append(sb[i]);
            }

            Console.WriteLine(reversed);
        }
    }
}
