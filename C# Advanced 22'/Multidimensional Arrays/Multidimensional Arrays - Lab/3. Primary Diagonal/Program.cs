using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a program that finds the sum of matrix primary diagonal.

            //square matrix

            int size = int.Parse(Console.ReadLine());

            int rows = size;
            int cols = size;

            //create the square matrix
            int[,] matrix = new int[rows, cols];

            //variable for sum
            int sum = 0;

            sum = SumThePrimaryDiagonal(size, matrix, sum);

            Console.WriteLine(sum);
            //inputs       output
            //3
            //1 2 3        15
            //4 5 6
            //7 8 9

        }

        static int SumThePrimaryDiagonal(int size, int[,] matrix, int sum)
        {

            //input the matrix
            for (int row = 0; row < size; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (int row = 0; row < size; row++)
            {
                sum += matrix[row, row];
            }

            return sum;
        }
    }
}
