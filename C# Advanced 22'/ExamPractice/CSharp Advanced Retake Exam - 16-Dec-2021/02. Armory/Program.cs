using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _02._Armory
{
    class Officer
    {
        private int row;
        private int col;
        private int gold;
        private Stack<int> swords;
        private bool outOfBounds;

        public Officer(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.Gold = 0;
            this.Swords = new Stack<int>();
            OutOfBounds = false;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public int Gold { get; set; }
        public Stack<int> Swords { get; set; }
        public bool OutOfBounds { get; set; }

        public void Movement(char[,] matrix)
        {
            string direction = Console.ReadLine();

            switch (direction)
            {
                case "up":
                    Row--;
                    break;
                case "down":
                    Row++;
                    break;
                case "right":
                    Col++;
                    break;
                case "left":
                    Col--;
                    break;
            }


            if (!(Row >= 0 && Row < matrix.GetLength(0)
                && Col >= 0 && Col < matrix.GetLength(1)))
            {
                OutOfBounds = true;
            }

        }

        //public bool StillValid(char[,] matrix, int row, int col)
        //{
        //    return
        //       row >= 0 && row < matrix.GetLength(0)
        //       && col >= 0 && col < matrix.GetLength(1);
        //}
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size, size];

            CreateMatrix(matrix);

            //officer's starting position
            int[] pos = GetPosition(matrix);

            //create officer with his starting position
            Officer officer = new Officer(pos[0], pos[1]);

            while (officer.Gold < 65)
            {
                officer.Movement(matrix);

                if (officer.OutOfBounds) break;

                char currPosition = matrix[officer.Row, officer.Col];

                if (char.IsDigit(currPosition))
                {
                    officer.Gold += int.Parse(currPosition.ToString());
                    matrix[officer.Row, officer.Col] = '-';
                }
                else if (currPosition == 'M')
                {
                    MoveTheOfficer(officer, matrix);
                }
            }

            PrintOutput(matrix, officer);

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

        static void PrintOutput(char[,] matrix, Officer officer)
        {
            //o	If the army officer leaves the armory, print: "I do not need more swords!"
            //            o If the army officer fulfills the initial deal, print: "Very nice swords, I will come back for more!"
            //•	On the second line print the profit you’ve made: "The king paid {amount} gold coins."
            //•	At the end print the final state of the matrix(armory).
            if (officer.OutOfBounds)
            {
                Console.WriteLine("I do not need more swords!");
            }
            else
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                //print the officer's last position in the matrix
                matrix[officer.Row, officer.Col] = 'A';
            }

            Console.WriteLine($"The king paid {officer.Gold} gold coins.");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            // PrintMatrix(matrix);
        }

        static void MoveTheOfficer(Officer officer, char[,] matrix)
        {
            //the old position gets '-'
            matrix[officer.Row, officer.Col] = '-';

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'M')
                    {
                        officer.Row = row;
                        officer.Col = col;
                        matrix[row, col] = '-';
                        return;
                    }
                }
            }
        }

        public static int[] GetPosition(char[,] matrix)
        {
            int[] pos = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'A')
                    {
                        pos[0] = row;
                        pos[1] = col;
                        matrix[row, col] = '-';
                        return pos;
                    }
                }
            }

            return pos;
        }

        public static char[,] CreateMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
