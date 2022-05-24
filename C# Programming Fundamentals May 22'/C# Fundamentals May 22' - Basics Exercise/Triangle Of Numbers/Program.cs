using System;

namespace Triangle_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which receives a number – n, and prints a triangle from 1 to n.
            //Constraints
            //•	n will be in the interval[1...20].

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");

                }
                Console.WriteLine();
            }

        }
    }
}
