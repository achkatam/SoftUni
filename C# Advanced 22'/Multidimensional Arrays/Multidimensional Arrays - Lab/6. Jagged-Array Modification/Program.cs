using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a matrix from the console. On the first line, you will get matrix rows. On the next rows lines, you will get elements for each column separated with space. You will be receiving commands in the following format:
            //•	Add { row}{ col}{ value} – Increase the number at the given coordinates with the value.
            //•	Subtract { row}{ col}{ value} – Decrease the number at the given coordinates by the value.
            //Coordinates might be invalid. In this case, you should print "Invalid coordinates".When you receive "END" you should print the matrix and stop the program.

            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine()
                    .Split().Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();

            command = Calculation(jaggedArray, command);

            PrintOutput(jaggedArray);
        }

        static void PrintOutput(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[row]));
            }
        }

        static string Calculation(int[][] jaggedArray, string command)
        {
            while (command != "END")
            {
                var tokens = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row >= 0 && row < jaggedArray.Length
                    && col >= 0 && col < jaggedArray[row].Length)
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
                    Console.WriteLine($"Invalid coordinates");
                }

                command = Console.ReadLine();
            }

            return command;
        }
    }
}
