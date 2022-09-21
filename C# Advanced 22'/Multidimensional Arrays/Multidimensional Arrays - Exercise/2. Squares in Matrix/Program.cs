using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //matrix's dimension
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //create the matrix
            char[,] matrix = new char[input[0], input[1]];

             MatrixData(matrix);

            //counter. Increases if there is/are a/ square/s in the matrix
            int counter = 0;

            if (matrix.GetLength(0) > 1
                && matrix.GetLength(1) > 1)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        if (matrix[row, col] == matrix[row, col + 1]
                            && matrix[row, col] == matrix[row + 1, col + 1]
                            && matrix[row, col] == matrix[row + 1, col])
                        {
                            counter++;
                        }
                    }
                }

                Console.WriteLine(counter);
            }

            //matrix[row, col] == matrix[row, col + 1]
            //&& matrix[row, col] == matrix[row + 1, col + 1]
            //&& matrix[row, col] == matrix[row + 1, col])
            
        }

        static void MatrixData(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var chars = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => char.Parse(c))
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
        }
    }
}
