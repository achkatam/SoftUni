using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a program that finds the difference between the sums of the square matrix diagonals (absolute value).

            int n = int.Parse(Console.ReadLine());

            //create the matrix
            int[,] matrix = new int[n, n];

            //Method for matrix data typing in
            MatrixData(matrix);

            //variable for sum of primary diagonal
            int primarySum = 0;
            ////secondary sum
            int secSum = 0;

            for (int row = 0, col = matrix.GetLength(0) - 1; row < matrix.GetLength(0); row++, col--)
            {
                primarySum += matrix[row, row];
                secSum += matrix[row, col];
            }

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    primarySum += matrix[row, row];
            //}

            ////Console.WriteLine(primarySum);

            

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    secSum += matrix[row, matrix.GetLength(0) - row - 1];
            //}

            //Console.WriteLine(secSum);

            //variable for absolute difference primarySum - secSum
            int difference = Math.Abs(primarySum - secSum);

            //Print output
            Console.WriteLine(difference);

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
