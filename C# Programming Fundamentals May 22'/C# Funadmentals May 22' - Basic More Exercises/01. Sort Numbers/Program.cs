using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives three real numbers and sorts them in descending order. Print each number on a new line.

            int number01 = int.Parse(Console.ReadLine());
            int number02 = int.Parse(Console.ReadLine());
            int number03 = int.Parse(Console.ReadLine());

            int[] numbers = { number01, number02, number03 };

            Array.Sort(numbers);
            Array.Reverse(numbers);//This will represent the descending order 

            foreach ( int nums in numbers)
            {
                Console.WriteLine(nums);
            }
        }
    }
}
