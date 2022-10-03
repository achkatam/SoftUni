using System;

namespace _4._Symbol_in_Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads N, a number representing rows and cols of a matrix. On the next N lines, you will receive rows of the matrix. Each row consists of ASCII characters. After that, you will receive a symbol. Find the first occurrence of that symbol in the matrix and print its position in the format: "({row}, {col})". If there is no such symbol print an error message 
            //"{symbol} does not occur in the matrix "

            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            //inputs for the matrix
            for (int row = 0; row < size; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            //the char we look for
            char symbol = char.Parse(Console.ReadLine());

            //iterate thru the matrix
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    bool symbolFound = matrix[row, col] == symbol;

                    if (symbolFound)
                    {
                        Console.WriteLine($"({row}, {col})");

                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix ");

            //input
            //3
            //ABC
            //DEF
            //X!@
            //!


        }
    }
}
