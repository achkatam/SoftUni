using System;
using System.Linq;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] triangle = new int[n][];
            for (int row = 0; row < n; row++)
            {
                triangle[row] = new int[row + 1];
                triangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] = triangle[row - 1][col - 1] +
                        triangle[row - 1][col];
                }
                triangle[row][row] = 1;
            }

            //Print the jagged array
            for (int row = 0; row < triangle.Length; row++)
            {
                Console.WriteLine(string.Join(" ", triangle[row]));
            }
        }
    }
}
