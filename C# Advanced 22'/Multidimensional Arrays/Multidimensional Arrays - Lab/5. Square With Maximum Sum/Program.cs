using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a matrix from the console. Then find the biggest sum of the 2x2 submatrix and print it to the console.
            //On the first line, you will get matrix sizes in format rows, columns.
            //In the lines of One next row, you will get elements for each column separated with a comma.
            //Print the biggest top - left square, which you find, and the sum of its elements.
            //•	If you find more than one max square, print the top-left one

            int[] size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            //initialize subMatrixRow and col at 2. This will protect from getting out of bounds.
            int subMatrixRow = 2;
            int subMatrixCol = 2;

            //initialize variables for startRow and startCol for square matrix when the maxSum found
            int startRow = 0, startCol = 0, maxSum = int.MinValue;


            for (int row = 0; row < rows - subMatrixRow + 1; row++)
            {
                for (int col = 0; col < cols - subMatrixCol + 1; col++)
                {
                    //variable for sum
                    int sum = 0;

                    //sum each direction of the square matrix
                    //top left
                    sum += matrix[row, col];
                    //bottom left
                    sum += matrix[row + 1, col];
                    //bottom right
                    sum += matrix[row + 1, col + 1];
                    //top right
                    sum += matrix[row, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            //variables for position of the square matrix
            int topLeft = matrix[startRow, startCol];
            int topRight = matrix[startRow, startCol + 1];
            int bottomLeft = matrix[startRow + 1, startCol];
            int bottomRight = matrix[startRow + 1, startCol + 1];

            Console.WriteLine($"{topLeft} {topRight}");
            Console.WriteLine($"{bottomLeft} {bottomRight}");
            Console.WriteLine(maxSum);
        }

    }
}
