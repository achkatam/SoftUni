using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads N, a number representing rows and cols of a matrix. On the next N lines, you will receive rows of the matrix. Each row consists of ASCII characters. After that, you will receive a symbol. Find the first occurrence of that symbol in the matrix and print its position in the format: "({row}, {col})". If there is no such symbol print an error message 
            //"{symbol} does not occur in the matrix "

            int n = int.Parse(Console.ReadLine());

            //square matrix
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    //boolean when we find the char
                    bool isFound = matrix[row, col] == symbol;
                    if (isFound)
                    {
                        Console.WriteLine($"({row}, {col})");

                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix ");
        }
    }
}
