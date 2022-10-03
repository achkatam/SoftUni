using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a matrix from the console and prints the sum for each column. On the first line, you will get matrix rows. On the next rows lines, you will get elements for each column separated with a space. 

            int[] size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            //create the matrix
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                //variable for sum
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }

            //input
            //3, 6
            //7 1 3 3 2 1
            //1 3 9 8 5 6
            //4 6 7 9 1 0

        }
    }
}
