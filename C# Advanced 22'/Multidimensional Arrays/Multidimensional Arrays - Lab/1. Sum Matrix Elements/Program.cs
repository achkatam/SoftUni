using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a matrix from the console and prints:
            //•	Count of rows
            //•	Count of columns
            //•	Sum of all matrix elements
            //On the first line, you will get matrix sizes in format[rows, columns]

            //input
            var matrixSizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int rows = matrixSizes[0];
            int cols = matrixSizes[1];

            //initialize the matrix
            int[,] matrix = new int[rows, cols];

            //input the data for the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }

            //initialize the sum
            int sum = 0;

            //sum up the elements
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            //output
            PrintOutput(matrix, sum);

        }

        static void PrintOutput(int[,] matrix, int sum)
        {
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
