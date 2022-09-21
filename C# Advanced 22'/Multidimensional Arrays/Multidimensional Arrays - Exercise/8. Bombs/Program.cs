using System;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will be given a square matrix of integers, each integer separated by a single space and each row on a new line. Then on the last line of input, you will receive indexes - coordinates to several cells separated by a single space, in the following format: row1,column1 row2,column2 row3,column3 … 
            //On those cells there are bombs. You have to proceed with every bomb, one by one in the order they were given.When a bomb explodes deals damage equal to its integer value, to all the cells around it(in every direction and all diagonals). One bomb can't explode more than once and after it does, its value becomes 0. When a cell's value reaches 0 or below, it dies.Dead cells can't explode.
            //You must print the count of all alive cells and their sum. Afterward, print the matrix with all of its cells(including the dead ones). 

            //size of the matrix
            int n = int.Parse(Console.ReadLine());

            //create the square matrix
            var matrix = new int[n, n];

            //4
            //8 3 2 5
            //6 4 7 9
            //9 9 3 6
            //6 8 1 2
            //1,2 2,1 2,0


            MatrixData(matrix);

            string[] bombInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var bomb in bombInfo)
            {
                int[] input = bomb.Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

                int row = input[0];
                int col = input[1];

                Directions(matrix, col, row);
            }

            //counter for alive cells
            int counter = 0;
            //sum of the alive cells
            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        counter++;
                        sum += matrix[row, col];
                    }
                }
            }

            //•	On the first line, you need to print the count of all alive cells in the format: 
            //            "Alive cells: {aliveCells}"
            Console.WriteLine($"Alive cells: {counter}");
            //•	On the second line, you need to print the sum of all alive cells in the format: 
            //"Sum: {sumOfCells}"
            Console.WriteLine($"Sum: {sum}");
            //•	At the end print the matrix. The cells must be separated by a single space.

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }


        }

        static void Directions(int[,] matrix, int col, int row)
        {
            //actual position
            int value = matrix[row, col];

            if (value > 0)
            {
                matrix[row, col] = 0;

                HorizontalMovements(matrix, col, row, value);

                VerticalMovements(matrix, col, row, value);

                DiagonalMovements(matrix, col, row, value);

            }


        }

        static void DiagonalMovements(int[,] matrix, int col, int row, int value)
        {
            //3.Diagonal movements - check both
            //3.1. top right
            if (row > 0 && col < matrix.GetLength(1) - 1 && matrix[row - 1, col + 1] > 0)
            {
                matrix[row - 1, col + 1] -= value;
            }
            //3.2. top left
            if (row > 0 && col > 0 && matrix[row - 1, col - 1] > 0)
            {
                matrix[row - 1, col - 1] -= value;
            }
            //3.3. bottom right
            if (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row + 1, col + 1] > 0)
            {
                matrix[row + 1, col + 1] -= value;
            }
            //3.4. bottom left
            if (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row + 1, col - 1] > 0)
            {
                matrix[row + 1, col - 1] -= value;
            }
        }

        static void VerticalMovements(int[,] matrix, int col, int row, int value)
        {
            //2.Vertical movements - check the rows
            //2.1.Upward
            if (row > 0 && matrix[row - 1, col] > 0)
            {
                matrix[row - 1, col] -= value;
            }
            //2.2.Downward
            if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] > 0)
            {
                matrix[row + 1, col] -= value;
            }
        }

        static void HorizontalMovements(int[,] matrix, int col, int row, int value)
        {
            //1.Horizontal movements - check the cols
            //1.1. left
            if (col > 0 && matrix[row, col - 1] > 0)
            {
                matrix[row, col - 1] -= value;
            }
            //1.2. right
            if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] > 0)
            {
                matrix[row, col + 1] -= value;
            }
        }

        static void MatrixData(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colInfo = Console.ReadLine()
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
