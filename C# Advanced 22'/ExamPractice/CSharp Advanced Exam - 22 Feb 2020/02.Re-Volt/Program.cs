using System;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace _02.Re_Volt
{

    class Player
    {
        public Player((int, int) playerLocation)
        {
            Row = playerLocation.Item1;
            Col = playerLocation.Item2;
        }

        public int Row { get; set; }
        public int Col { get; set; }

    }

    public class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            int commandCount = int.Parse(Console.ReadLine());

            var matrix = GetMatrix(size);

            Player player = new Player(GetPlayerLocation(matrix));
            var bonus = GetBonus(matrix);
            var traps = GetTrap(matrix);

            int oldRow = player.Row;
            int oldCol = player.Col;

            for (int i = 0; i < commandCount; i++)
            {
                string direction = Console.ReadLine();
                //Zero test 3
                //5
                //5
                //---- -
                //Bf-- -
                //-----
                //-----
                //----F
                //left
                //up
                //up

              //  PrintMatrix(matrix);
                switch (direction)
                {
                    case "up":
                        player.Row--;
                        break;
                    case "down":
                        player.Row++;
                        break;
                    case "right":
                        player.Col++;
                        break;
                    case "left":
                        player.Col--;
                        break;
                }

                if (IsValid(player.Row, player.Col, matrix))
                {
                    //last pos becomes '-'

                    matrix[oldRow, oldCol] = '-';
                  //  PrintMatrix(matrix);

                    (player.Row, player.Col) = Movement(player.Row, player.Col, matrix, direction, oldCol, oldRow);

                }
                else
                {
                   // matrix[oldRow, oldCol] = '-';
                    (player.Row, player.Col) = OutOfBounds(player.Row, player.Col, matrix, direction, oldCol, oldRow);
                  //  PrintMatrix(matrix);
                    //add movement
                }


                oldRow = player.Row;
                oldCol = player.Col;

            }

            Console.WriteLine("Player lost!");

            PrintMatrix(matrix);

        }

        public static object GetTrap(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'T')
                    {
                        return (row, col);
                    }
                }
            }

            return (0, 0);
        }

        public static (int,int) GetBonus(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        return (row, col);
                    }
                }
            }

            return (0, 0);
        }

        public static (int, int) OutOfBounds(int row, int col, char[,] matrix, string direction, int oldCol, int oldRow)
        {
            //if (matrix[oldRow, oldCol] == 'B')
            //{
            //    matrix[oldRow, oldCol] = 'B';

            //}
            //else
            //{
            //    matrix[oldRow, oldCol] = '-';

            //}
         //   PrintMatrix(matrix);
            switch (direction)
            {
                case "up":
                    row = matrix.GetLength(0) - 1;
                    break;
                case "down":
                    row = 0;
                    break;
                case "right":
                    col = 0;
                    break;
                case "left":
                    col = matrix.GetLength(1) - 1;
                    break;
            }

            Movement(row, col, matrix, direction, oldCol, oldRow);

           // PrintMatrix(matrix);

            return (row, col);
        }

        public static (int, int) Movement(int row, int col, char[,] matrix, string direction, int oldCol, int oldRow)
        {
            matrix[oldRow, oldCol] = '-';

            if (matrix[row, col] == 'F')
            {
                matrix[oldRow, oldCol] = '-';

                matrix[row, col] = 'f';

                //won the game
                Console.WriteLine("Player won!");
                PrintMatrix(matrix);

                Environment.Exit(0);
            }
            else if (matrix[row, col] == 'B')
            {
                //matrix[oldRow, oldCol] = '-';
                //it's a bonus move forward 1 position
              //  PrintMatrix(matrix);
                // matrix[row, col] = 'B';
                (row, col) = MoveForward(row, col, matrix, direction, oldRow, oldCol);
            }
            else if (matrix[row, col] == 'T')
            {
                //it's a trap, returns 1 position
                row = oldRow;
                col = oldCol;

                matrix[row, col] = 'f';
            }
            else
            {
                matrix[row, col] = 'f';

            }

          // PrintMatrix(matrix);

            return (row, col);
        }

        public static (int row, int col) MoveForward(int row, int col, char[,] matrix, string direction, int oldRow, int oldCol)
        {
            switch (direction)
            {
                case "up":
                    row--;
                    break;
                case "down":
                    row++;
                    break;
                case "right":
                    col++;
                    break;
                case "left":
                    col--;
                    break;
            }
            if (IsValid(row, col, matrix))
            {
                //last pos becomes '-'

                matrix[oldRow, oldCol] = '-';
               // PrintMatrix(matrix);
                (row, col) = Movement(row, col, matrix, direction, oldCol, oldRow);

            }
            else
            {
                // matrix[oldRow, oldCol] = '-';
                (row, col) = OutOfBounds(row, col, matrix, direction, oldCol, oldRow);
               // PrintMatrix(matrix);
                //add movement
            }
            // matrix[oldRow, oldCol] = 'B';
            //matrix[row, col] = 'f';
           // PrintMatrix(matrix);
            return (row, col);
        }

        public static bool IsValid(int row, int col, char[,] matrix)
        {
            return
                   row >= 0 && row < matrix.GetLength(0)
                   && col >= 0 && col < matrix.GetLength(1);

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

        public static (int, int) GetPlayerLocation(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        return (row, col);
                    }
                }
            }

            return (0, 0);
        }

        public static char[,] GetMatrix(int size)
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
