using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a program that reads a matrix from the console. Then find the biggest sum of the 2x2 submatrix and print it to the console.
            //On the first line, you will get matrix sizes in format rows, columns.
            //In the lines of One next row, you will get elements for each column separated with a comma.
            //Print the biggest top - left square, which you find, and the sum of its elements

            int subMatrixRows = 2;
            int subMatrixCols = 2;

            var sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var rowData = Console.ReadLine().Split(", ");

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = int.Parse(rowData[col]);


                }
            }

            int maxSum = 0;
            int squareStartRow = 0;
            int squareStartCol = 0;

            for (int row = 0; row < rows - subMatrixRows + 1; row++)
            {
                for (int col = 0; col < cols - subMatrixCols + 1; col++)
                {
                    int sum = 0;

                    sum += matrix[row, col];
                    sum += matrix[row + 1, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        squareStartRow = row;
                        squareStartCol = col;

                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine($"{matrix[squareStartRow, squareStartCol]}" +
                $" {matrix[squareStartRow, squareStartCol + 1]}");
            Console.WriteLine($"{matrix[squareStartRow + 1, squareStartCol]}" +
                $" {matrix[squareStartRow + 1, squareStartCol + 1]}");

            Console.WriteLine(maxSum);
        }
    }
}
