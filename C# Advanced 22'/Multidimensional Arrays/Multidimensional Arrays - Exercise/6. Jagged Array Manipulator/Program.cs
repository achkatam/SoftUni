using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading;
using System.Xml.Linq;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Create a program that populates, analyzes and manipulates the elements of a matrix with an unequal length of its rows.
            //First, you will receive an integer N equal to the number of rows in your matrix.
            //On the next N lines, you will receive sequences of integers, separated by a single space. Each sequence is a row in the matrix.
            //After populating the matrix, start analyzing it. If a row and the one below it have equal length, multiply each element in both of them by 2, otherwise - divide by 2.
            //Then, you will receive commands. There are three possible commands:
            //•	"Add {row} {column} {value}" - add { value}
            //to the element at the given indexes, if they are valid.
            //•	"Subtract {row} {column} {value}" - subtract { value}
            //from the element at the given indexes, if they are valid.
            //•	"End" - print the final state of the matrix(all elements separated by a single space) and stop the program.

            int rows = int.Parse(Console.ReadLine());

            //create jaggedArray
            int[][] jaggedArray = new int[rows][];

            //type in the data in the jagged array
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                int[] colInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

                jaggedArray[row] = colInfo;
            }

            //lenght - 1
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                switch (cmd)
                {
                    //•	"Add {row} {column} {value}" - add {value} to the element at the given indexes, if they are valid.
                    case "Add":
                        if (IsValid(row, col, jaggedArray))
                        {
                            jaggedArray[row][col] += value;
                        }
                        break;
                    //•	"Subtract {row} {column} {value}" - subtract { value}
                    //from the element at the given indexes, if they are valid.
                    case "Subtract":
                        if (IsValid(row,col,jaggedArray))
                        {
                            jaggedArray[row][col] -= value;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            //Print output
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }
        }
        static bool IsValid(int row, int col, int[][] jaggedArray)
        {
            return
                row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length;
        }
    }
}

        