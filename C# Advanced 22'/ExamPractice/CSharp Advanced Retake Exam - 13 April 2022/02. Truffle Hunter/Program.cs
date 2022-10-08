using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _02._Truffle_Hunter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //dict of type of truffle and its occurence
            var truffles = new Dictionary<char, int>()
            {
                {'S',0 },
                {'W',0 },
                {'B',0 }
            };

            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];

            CreateMatrix(matrix);

            //eaten truffles by the wild boar
            int counter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop the hunt") break;

                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Collect":
                        CollectTruffles(matrix, truffles, tokens);
                        break;
                    case "Wild_Boar":
                        counter = BoarMovement(matrix, tokens, truffles, counter);
                        break;
                }
            }

            PrintOutput(matrix, truffles, counter);

        }

        public static bool IsValidPosition(int row, int col, char[,] forest)
        {
            return row >= 0 &&
                   col >= 0 &&
                   row < forest.GetLength(0) &&
                   col < forest.GetLength(1);
        }
        static void PrintOutput(char[,] matrix, Dictionary<char, int> truffles, int counter)
        {
            Console.WriteLine($"Peter manages to harvest {truffles['B']} black, {truffles['S']} summer, and {truffles['W']} white truffles.");
            Console.WriteLine($"The wild boar has eaten {counter} truffles.");
            //Then print the last state of the forest.
            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static int BoarMovement(char[,] matrix, string[] tokens, Dictionary<char, int> truffles, int counter)
        {
            int row = int.Parse(tokens[1]);
            int col = int.Parse(tokens[2]);

            string direction = tokens[3];


            if (matrix[row, col] != '-')
            {
                counter++;
                matrix[row, col] = '-';
            }

            while (true)
            {
                switch (direction)
                {
                    case "up"://rows -= 2
                        row -= 2;
                        break;
                    case "down": // rows += 2
                        row += 2;
                        break;
                    case "left": // col -=2
                        col -= 2;
                        break;
                    case "right": //col += 2
                        col += 2;
                        break;
                }

                if (!IsValidPosition(row, col, matrix))
                {
                    break;
                }
                else if (matrix[row, col] != '-')
                {
                    counter++;
                    matrix[row, col] = '-';
                }
            }


            return counter;
        }

        static void CollectTruffles(char[,] matrix, Dictionary<char, int> truffles, string[] tokens)
        {
            int row = int.Parse(tokens[1]);
            int col = int.Parse(tokens[2]);

            if (matrix[row, col] != '-')
            {
                char truffleType = matrix[row, col];
                truffles[truffleType]++;

                matrix[row, col] = '-';
            }

        }

        static void CreateMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
