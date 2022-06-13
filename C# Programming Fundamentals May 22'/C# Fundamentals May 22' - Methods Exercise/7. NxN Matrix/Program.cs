using System;

namespace _7._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.

            //input
            int num = int.Parse(Console.ReadLine());

            //Output
            Matrix(num);
        }
        static void Matrix(int number)
        {
            //Create for loop to make the matrix
            //For loop for rows
            for (int row = 0; row < number; row++)
            {
                //For loop for columns
                for (int col = 0; col < number; col++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
