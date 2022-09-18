using System;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a matrix from the console and prints:
            //•	Count of rows
            //•	Count of columns
            //•	Sum of all matrix elements

            var sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, cols];

            for (int row  = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(", ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = int.Parse(rowData[col]);
                }
            }
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row,col];
                   
                }

                Console.WriteLine();
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
