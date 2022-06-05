using System;
using System.Linq;
using System.Numerics;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input the heght of the triangle
            int height = int.Parse(Console.ReadLine());

            // Create an jagged array - array of arrays
            int[][] array = new int[height][];

            // For loop
            for (int row = 0; row < height; row++)
            {
                array[row] = new int[row + 1];

                for (int col = 0; col <= row; col++)
                {
                    if (col == 0 || col == row)
                    {
                        //The triangle starts from 1 to...
                        array[row][col] = 1;
                        Console.Write($"{array[row][col]} ");
                    }
                    else
                    {
                        array[row][col] = array[row - 1][col - 1] + array[row - 1][col];
                        Console.Write($"{array[row][col]} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
