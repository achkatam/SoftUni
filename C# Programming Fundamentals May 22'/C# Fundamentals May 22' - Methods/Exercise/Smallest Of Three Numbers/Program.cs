using System;
using System.Linq;

namespace Smallest_Of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            //Output
            Console.WriteLine(SmallestInteger(num1, num2, num3));
        }

        static int SmallestInteger(int num1, int num2, int num3)
        {
            //Using Math.Min class to find the smallest among 3 nums
            return Math.Min(num1, Math.Min(num2, num3));
        }
        //Shorter than the prev one method
        //static void PrintTheSmallestNum(int a, int b, int c) => Console.WriteLine(Math.Min(a, Math.Min(b, c)));

    }
}
