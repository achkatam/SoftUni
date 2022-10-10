using System;

namespace _02._Wall_Destroyer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            //starting position of Vanko
            int row = 0;
            int col = 0;

            CreateMatrix(matrix, ref row, ref col);

            int holesCnt = 1; // after he leaves his starting position he leaves a hole
            int rodsCnt = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];

                int currRow = row;
                int currCol = col;

                switch (direction)
                {
                    case "up":
                        currRow--;
                        break;
                    case "down":
                        currRow++;
                        break;
                    case "left":
                        currCol--;
                        break;
                    case "right":
                        currCol++;
                        break;
                }

                if (IsValid(matrix, currRow, currCol))
                {
                   matrix = CheckMovements(matrix, ref currRow, ref currCol, ref row, ref col, ref holesCnt, ref rodsCnt);
                }
                else
                {
                    command = Console.ReadLine();

                    continue;
                }

               //To make it easier to follow the movements, print the matrix after every move
               // PrintMatrix(matrix);


                row = currRow;
                col = currCol;

                command = Console.ReadLine();
            }


            PrintOutput(matrix, holesCnt, rodsCnt);
        }

        public static char[,] CheckMovements(char[,] matrix, ref int currRow, ref int currCol, ref int row, ref int col, ref int holesCnt, ref int rodsCnt)
        {
            if (matrix[currRow, currCol] == '-')
            {
                matrix[row, col] = '*';
                matrix[currRow, currCol] = 'V';
                holesCnt++;
            }
            else if (matrix[currRow, currCol] == 'R')
            {
                rodsCnt++;
                matrix[row, col] = 'V';

                //return the matrix to its old position
                currRow = row;
                currCol = col;
                Console.WriteLine("Vanko hit a rod!");
            }
            else if (matrix[currRow, currCol] == 'C')
            {
                matrix[row, col] = '*';
                matrix[currRow, currCol] = 'E';
                holesCnt++;

                GotElectrocuted(matrix, holesCnt);

                Environment.Exit(0); // relevant to return
            }
            else if (matrix[currRow, currCol] == '*')
            {
                Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol}]!");
                matrix[row, col] = '*';
                matrix[currRow, currCol] = 'V';
            }

            return matrix;
        }


        public static void GotElectrocuted(char[,] matrix, int holesCnt)
        {
            Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCnt} hole(s).");

            PrintMatrix(matrix);
        }

        public static void PrintOutput(char[,] matrix, int holesCnt, int rodsCnt)
        {
            Console.WriteLine($"Vanko managed to make {holesCnt} hole(s) and he hit only {rodsCnt} rod(s).");

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static bool IsValid(char[,] matrix, int currRow, int currCol)
        {
            return currRow >= 0 && currRow < matrix.GetLength(0)
                && currCol >= 0 && currCol < matrix.GetLength(1);
        }

        public static void CreateMatrix(char[,] matrix, ref int startRow, ref int startCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'V')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
        }
    }
}
