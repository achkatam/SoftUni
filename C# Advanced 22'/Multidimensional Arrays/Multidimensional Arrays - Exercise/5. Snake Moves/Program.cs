using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You have a task to visualize the snake's path in a square form. A snake is represented by a string. The isle is a rectangular matrix of size N x M. A snake starts going down from the top-left corner and slithers its way down. The first cell is filled with the first symbol of the snake, the second cell is filled with the second symbol, etc. The snake is as long as it takes to fill the stairs– if you reach the end of the string representing the snake, start again at the beginning. After you fill the matrix with the snake's path, you should print it.

            var dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            char[,] matrix = new char[dimensions[0], dimensions[1]];

            int currIndex = 0;

            string input = Console.ReadLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currIndex == input.Length)
                        {
                            currIndex = 0;
                        }

                        matrix[row, col] = input[currIndex];

                        currIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (currIndex == input.Length)
                        {
                            currIndex = 0;
                        }

                        matrix[row, col] = input[currIndex];

                        currIndex++;
                    }
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }

        }
    }
}
