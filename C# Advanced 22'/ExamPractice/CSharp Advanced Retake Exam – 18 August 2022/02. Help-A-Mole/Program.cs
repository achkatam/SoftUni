using System;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _02._Help_A_Mole
{
    public class Program
    {
        class Mole
        {
            //public Mole(int row, int col, int points)
            //{
            //    Row = row;
            //    Col = col;
            //    Points = points;
            //}

            public int Row { get; set; }
            public int Col { get; set; }
            public int Points { get; set; }
            public bool HasWon { get; set; } = false;
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = CreateMatrix(size);
            Mole mole = new Mole();

            // mole.Points = GetPoints(matrix, size, mole);


            (mole.Row, mole.Col) = GetMoleLocation(matrix, size, mole);

            string command = Console.ReadLine().ToLower();


            while (command != "end" && mole.Points < 25)
            {
                int oldRow = mole.Row;
                int oldCol = mole.Col;

                switch (command)
                {
                    case "up":
                        mole.Row--;
                        break;
                    case "down":
                        mole.Row++;
                        break;
                    case "right":
                        mole.Col++;
                        break;
                    case "left":
                        mole.Col--;
                        break;
                }

                if (IsValid(mole.Row, mole.Col, matrix))
                {
                    matrix[oldRow, oldCol] = '-';
                    (mole.Row, mole.Col) = Movement(mole.Row, mole.Col, matrix, mole.Points, command, size, mole, oldRow, oldCol);
                }
                else
                {
                    mole.Row = oldRow;
                    mole.Col = oldCol;
                    Console.WriteLine("Don't try to escape the playing field!");
                }
                oldRow = mole.Row;
                oldCol = mole.Col;

                if (mole.Points >= 25)
                {
                    mole.HasWon = true;
                }

                command = Console.ReadLine().ToLower();
            }

            PrintOutput(matrix, mole, size);

         } 

        static void PrintOutput(char[,] matrix, Mole mole, int size)
        {

            if (mole.HasWon)
            {
                Console.WriteLine($"Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {mole.Points} points.");
            }
            else
            {
                Console.WriteLine($"Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {mole.Points} points.");
            }


            matrix[mole.Row, mole.Col] = 'M';
            PrintMatrix(matrix, size);
        }

        static (int, int) Movement(int row, int col, char[,] matrix, int points, string command, int size, Mole mole, int oldRow, int oldCol)
        {
            if (matrix[mole.Row, mole.Col] == 'S')
            {
                //this changes the first 'S' to '-'
                matrix[mole.Row, mole.Col] = '-';
                mole.Points -= 3;
                (mole.Row, mole.Col) = Teleport(matrix, mole, oldRow, oldCol);

                matrix[mole.Row, mole.Col] = '-';
                //PrintMatrix(matrix, size);
            }
            else if (char.IsDigit(matrix[row, col]))
            {
                mole.Points += int.Parse(matrix[mole.Row, col].ToString());
                matrix[mole.Row, mole.Col] = '-';
            }
            else
            {
                matrix[mole.Row, mole.Col] = '-';
            }


           // PrintMatrix(matrix, size);

            return (mole.Row, mole.Col);
        }

        private static (int row, int col) Teleport(char[,] matrix, Mole mole, int oldRow, int oldCol)
        {
            matrix[mole.Row, mole.Col] = '-';
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        mole.Row = row;
                        mole.Col = col;
                        return (mole.Row, mole.Col);
                    }
                }
            }

            return (0, 0);
        }

        public static bool IsValid(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }

        static (int, int) GetMoleLocation(char[,] matrix, int size, Mole mole)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 'M')
                    {
                        mole.Row = row;
                        mole.Col = col;

                        return (mole.Row, mole.Col);
                    }
                }
            }

            return (0, 0);
        }

        public static void PrintMatrix(char[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static char[,] CreateMatrix(int size)
        {
            var matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                var rowData = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
