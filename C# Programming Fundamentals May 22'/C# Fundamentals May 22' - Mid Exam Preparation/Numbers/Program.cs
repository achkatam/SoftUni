using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read a sequence of integers and find and print the top 5 numbers greater than the average value in the sequence, sorted in descending order.
            //Input
            //•	Read from the console a single line holding space - separated integers.
            //  Output
            //•	Print the above - described numbers on a single line, space - separated.
            //•	If less than 5 numbers hold the property mentioned above, print less than 5 numbers.
            //•	Print "No" if no numbers hold the above property.

            //Create the list 
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            //boolean if the num is greate than the average
            bool isGreater = false;
            //List for the greatest numbers limited to 5 counts
            List<double> greatestNums = new List<double>();

            //Find the average num of numbers
            double averageNum = numbers.Sum() / numbers.Count();

            //For loop to iterate thru the list of numbers
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNum)
                {
                    greatestNums.Add(numbers[i]);
                }
            }
            greatestNums.Sort();
            //greatestNums.Reverse();

            
            //This way we're gonna remove the first numbers until list's count gets 5
            while (greatestNums.Count > 5 )
            {
                double currNum = greatestNums[0];
                greatestNums.Remove(currNum);
            }
            if (greatestNums.Count == 0)
            {
                Console.WriteLine("No");
            }
            greatestNums.Reverse();
            Console.WriteLine(string.Join(' ', greatestNums));

        }
    }
}
