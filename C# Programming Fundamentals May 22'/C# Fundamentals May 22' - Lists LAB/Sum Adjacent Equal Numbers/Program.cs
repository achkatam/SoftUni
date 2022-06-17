using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.
            //•	After two numbers are summed, the result could be equal to some of its neighbors and should be summed as well (see the examples below)
            //•	Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available)

            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            //Iterate through the elements. Check if the number at the current index is equal to the next number.If it is, aggregate the numbers and reset the loop, otherwise don't do anything.

            //For loop to iterate to the last number of the List, NOT THE SIZE OF THE LIST
            for (int i = 0; i < numbers.Count - 1; i++)
            {                                          
                if (numbers[i] == numbers[i + 1])// If [i] equals the next number, the nwe sum them up
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);//Remove the enext number
                    i = -1;////Move the index to the leftmost side of the array
                }
            }
            //Output
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
