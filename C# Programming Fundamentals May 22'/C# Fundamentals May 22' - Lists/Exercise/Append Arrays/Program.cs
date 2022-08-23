using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program to append several arrays of numbers one after another.
            //•	Arrays are separated by '|'
            //•	Their Values are separated by spaces(' ', one or several)
            //•	Take all arrays starting from the rightmost and going to the left and place them in a new array in that order

            string[] array = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            //Create the list
            List<int> num = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                num.AddRange(array[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            }
            Console.WriteLine(string.Join(' ', num));
        }
    }
}
