using System;
using System.Data;
using System.Linq;

namespace _1._Diagonal_Difference
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a program that finds the difference between the sums of the square matrix diagonals (absolute value).

            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            MatrixData(matrix);

            //sum up the primary diagonal
            int primarySum = PrimaryDiagonal(matrix);

            //sum up the secondary diagonal
            int secSum = SecondaryDiagonal(matrix);

            //PrintOutput
            Console.WriteLine(Math.Abs(primarySum - secSum));
        }

        static int SecondaryDiagonal(int[,] matrix)
        {
            int secSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                secSum += matrix[row, matrix.GetLength(0) - row - 1];
            }

            return secSum;
        }

        static int PrimaryDiagonal(int[,] matrix)
        {
            int primarySum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primarySum += matrix[row, row];
            }

            return primarySum;
        }

        static void MatrixData(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
