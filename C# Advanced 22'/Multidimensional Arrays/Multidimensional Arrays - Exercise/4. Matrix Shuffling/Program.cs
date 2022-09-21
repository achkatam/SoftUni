using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string matrix from the console and performs certain operations with its elements. User input is provided in a similar way as in the problems above – first, you read the dimensions and then the data. 
            //Your program should then receive commands in the format: "swap row1 col1 row2 col2" where row1, col1, row2, col2 are coordinates in the matrix. For a command to be valid, it should start with the "swap" keyword along with four valid coordinates(no more, no less). You should swap the values at the given coordinates(cell[row1, col1] with cell[row2, col2]) and print the matrix at each step(thus you'll be able to check if the operation was performed correctly). 
            //If the command is not valid(doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered.

            var dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            MatrixData(matrix);

            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (IsValidCommand(dimensions, tokens))
                {
                    string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];

                    //change the values
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];

                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }

        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        static bool IsValidCommand(int[] dimensions, string[] tokens)
        {
            return
                tokens[0] == "swap"
                && tokens.Length == 5
                && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < dimensions[0]
                && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < dimensions[1]
                 && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < dimensions[0]
                 && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < dimensions[1];

        }

        static void MatrixData(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] strings = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = strings[col];
                }
            }
        }
    }
}
