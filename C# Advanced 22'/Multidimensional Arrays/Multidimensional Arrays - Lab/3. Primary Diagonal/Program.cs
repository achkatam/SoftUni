using System;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a program that finds the sum of matrix primary diagonal.
            int n = int.Parse(Console.ReadLine());

            //square matrix
            int[,] matrix = new int[n, n];

            int sum = 0;


            sum = Calculation(matrix, sum);

            Console.WriteLine(sum);
        }

        static int Calculation(int[,] matrix, int sum)
        {
            //Use for loop to add the cols value in the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colInfo = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(colInfo[col]);
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, row];
            }

            // Console.WriteLine(sum);
            return sum;
        }
    }
}
