using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a program that reads a matrix from the console and prints the sum for each column. On the first line, you will get matrix rows. On the next rows lines, you will get elements for each column separated with a space. 


            var sizes = Console.ReadLine()
              .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row,col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
