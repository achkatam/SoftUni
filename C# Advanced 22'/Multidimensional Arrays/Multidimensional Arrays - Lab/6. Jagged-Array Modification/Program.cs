using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace _6._Jagged_Array_Modification
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a matrix from the console. On the first line, you will get matrix rows. On the next rows lines, you will get elements for each column separated with space. You will be receiving commands in the following format:
            //•	Add { row} { col} { value} – Increase the number at the given coordinates with the value.
            //•	Subtract { row} { col} { value} – Decrease the number at the given coordinates by the value.
            //Coordinates might be invalid. In this case, you should print "Invalid coordinates".When you receive "END" you should print the matrix and stop the program.

            int rows = int.Parse(Console.ReadLine());

            var jaggedArray = new int[rows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }


            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                bool isValid = ValidJaggedArray(jaggedArray, row, col);

                if (isValid)
                {
                    switch (cmd)
                    {
                        case "Add":
                            jaggedArray[row][col] += value;
                            break;
                        case "Subtract":
                            jaggedArray[row][col] -= value;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");

                    command = Console.ReadLine();

                    continue;
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }

                Console.WriteLine();
            }

        }



        static bool ValidJaggedArray(int[][] jaggedArray, int row, int col)
        {
            return
                row >= 0 && row < jaggedArray.Length
                && col >= 0 && col < jaggedArray[row].Length;
        }
    }
}
