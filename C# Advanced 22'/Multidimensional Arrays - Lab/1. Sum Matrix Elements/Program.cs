using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the matrix dimensions: rows, cols
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            (int rows, int cols) = (dimensions[0], dimensions[1]);

            //Read the numbers for the matrix
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            //Print the matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
