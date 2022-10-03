using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Find the count of 2 x 2 squares of equal chars in a matrix.
            //Input
            //•	On the first line, you are given the integers rows and cols – the matrix's dimensions.
            //•	Matrix characters come at the next rows lines(space separated).

            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            MatrixData(matrix);

            //counter for square matrix
            int counter = GetSquareMatrix(matrix);

            Console.WriteLine(counter);
        }

        static int GetSquareMatrix(char[,] matrix)
        {
            int counter = 0;

            if (SizeIsGood(matrix))
                //iterate to the last element of rows
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    //iterate to the last element of cols
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        bool squareFound = FindSquare(matrix, row, col);

                        if (squareFound) counter++;
                    }
                }

            return counter;
        }

        static bool FindSquare(char[,] matrix, int row, int col)
        {
            return
                //equals the element on right side
                matrix[row, col] == matrix[row, col + 1]
                            //bottom left
                            && matrix[row, col] == matrix[row + 1, col]
                            //bottom right
                            && matrix[row, col] == matrix[row + 1, col + 1];
        }

        static bool SizeIsGood(char[,] matrix) => matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1;

        static void MatrixData(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
