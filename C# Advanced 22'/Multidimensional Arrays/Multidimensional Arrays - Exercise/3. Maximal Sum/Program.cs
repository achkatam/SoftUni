using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has a maximal sum of its elements.

            var n = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

            //create the matrix
            int[,] matrix = new int[n[0], n[1]];

            //Method for matrix data typing in
            MatrixData(matrix);

            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;


            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum =
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxSumRow; row < maxSumRow + 3; row++)
            {

                for (int col = maxSumCol; col < maxSumCol + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        static void MatrixData(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colInfo[col];
                }
            }
        }
    }
}
