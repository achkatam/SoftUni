using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BeaverAtWork
{
    public class Beaver
    {
        public Beaver((int, int) beaverPosition)
        {
            Branches = new Stack<char>();
            Row = beaverPosition.Item1;
            Col = beaverPosition.Item2;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public Stack<char> Branches { get; set; }
        public int BranchesCount { get; set; }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            //initialize the matrixy by given size
            int size = int.Parse(Console.ReadLine());

            var matrix = GetMatrix(size);

            Beaver beaver = new Beaver(GetBeaver(matrix));

            beaver.BranchesCount = GetBranches(matrix);

            string command = Console.ReadLine();

            int branchesCnt = beaver.BranchesCount;

            while (command != "end" && beaver.BranchesCount > 0)
            {
                //the following variables represent the old positions of the beaver
                int row = beaver.Row;
                int col = beaver.Col;

                switch (command)
                {
                    case "up":
                        beaver.Row--;
                        break;
                    case "down":
                        beaver.Row++;
                        break;
                    case "right":
                        beaver.Col++;
                        break;
                    case "left":
                        beaver.Col--;
                        break;
                }
               // PrintMatrix(matrix);

                if (IsValid(matrix, beaver.Row, beaver.Col))
                {
                    //the last position becomes '-', the new one 'B'
                    matrix[row, col] = '-';
                    (beaver.Row, beaver.Col) = MoveBeaverInDirection(beaver.Row, beaver.Col, matrix,ref branchesCnt, beaver.Branches, command);
                    beaver.BranchesCount = branchesCnt;
                }
                else
                {
                    //drops its last branch
                    if (beaver.Branches.Any()) beaver.Branches.Pop();

                    //DOES NOT changes its position
                    beaver.Row = row;
                    beaver.Col = col;
                }

               // PrintMatrix(matrix);
                command = Console.ReadLine();
            }

            PrintOutput(beaver.BranchesCount, beaver.Branches, matrix);
         }

        public static void PrintOutput(int branchesCount, Stack<char> branches, char[,] matrix)
        {
            if (branchesCount == 0)
            {
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches.Reverse())}.");
            }
            else if (branchesCount > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {branchesCount} branches left.");
            }

            PrintMatrix(matrix);
        }

        public static (int,int) MoveBeaverInDirection(int row, int col, char[,] matrix,ref int branchesCount, Stack<char> branches, string command)
        {
            //if it's lower character,  Pop it in the stack
            if (char.IsLower(matrix[row, col]))
            {
                branches.Push(matrix[row, col]);
               // matrix[row, col] = 'B';
                branchesCount--;
                //PrintMatrix(matrix);
            }
            else if (matrix[row,col] == 'F')
            {
                //eats the fish, change the cell to '-' and swims away
                matrix[row, col] = '-';
                (row, col) = SwimsToTheOppositeSide(row, col, matrix, branches, branchesCount, command);
                (row, col) = MoveBeaverInDirection(row, col, matrix,ref branchesCount, branches, command);
                //PrintMatrix(matrix);
            }
            matrix[row, col] = 'B';
           // PrintMatrix(matrix);

            return (row, col);
        }

        public static (int row, int col) SwimsToTheOppositeSide(int row, int col, char[,] matrix, Stack<char> branches, int branchesCount, string command)
        {
            switch (command)
            {
                //if it's last char the beaver swims to the opposite side of the pond, if not swims to the end into the direction
                case "up":
                    if (row == 0) row = matrix.GetLength(0) - 1;
                    else row = 0;
                    break;
                case "down":
                    if (row == matrix.GetLength(0) - 1) row = 0;
                    else row = matrix.GetLength(0) - 1;
                    break;
                case "right":
                    if (col == matrix.GetLength(1)) col = 0;
                    else col = matrix.GetLength(1) - 1;
                    break;
                case "left":
                    if (col == 0) col = matrix.GetLength(1) - 1;
                    else col = 0;
                    break;
            }
            //matrix[row, col] = 'B';
            PrintMatrix(matrix);
            return (row, col);
        }

        public static bool IsValid(char[,] matrix, int row, int col) => row >= 0 && row < matrix.GetLength(0) && col >=0 && col < matrix.GetLength(1);

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();
            }
        }

        public static int GetBranches(char[,] matrix)
        {
            int branchesCnt = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (char.IsLower(matrix[row, col]))
                    {
                        branchesCnt++;
                    }
                }
            }

            return branchesCnt;
        }

        public static (int, int) GetBeaver(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == 'B')
                    {
                        return (row,col);
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
                var rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
