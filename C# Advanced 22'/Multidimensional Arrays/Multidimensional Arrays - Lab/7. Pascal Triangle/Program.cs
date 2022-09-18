using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The triangle may be constructed in the following manner: In row 0 (the topmost row), there is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0. For example, the initial number in the first (or any other) row is 1 (the sum of 0 and 1), whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.

            int n = int.Parse(Console.ReadLine());

            //create the jagged array
            long[][] pascal = new long[n][];

            for (int row = 0; row < pascal.Length; row++)
            {
                pascal[row] = new long[row + 1];
                //Always starts and finishes with 1
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;

                for (int col = 1; col < pascal[row].Length - 1; col++)
                {
                    pascal[row][col] = pascal[row - 1][col - 1] + pascal[row - 1][col];
                }
            }

            foreach (var row in pascal)
            {
                Console.WriteLine(String.Join(" ", row));
            }

            //for (int row = 0; row < pascal.Length; row++)
            //{
            //    for (int col = 0; col < pascal[row].Length; col++)
            //    {
            //        Console.Write($"{pascal[row][col]} ");
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
