using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            //The knight moves to the nearest square, but not on the same row, column or diagonal. (This can be thought of as moving two squares horizontally, then one square vertically, or moving one square horizontally, then two squares vertically— i.e. in an "L" pattern.) 
            //The knight game is played on a board with dimensions N x N and a lot of chess knights 0 <= K <= N2.
            //You will receive a board with K for knights and '0' for empty cells. Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight.

            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            if (SmallerSize(n))
            {
                Console.WriteLine(0);

                return;
            }

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            //counter for removed knights
            int counter = 0;

            while (true)
            {
                //counters for the knight attacking most of the enemies
                int mostAttacking = 0;
                int rowMost = 0;
                int colMost = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')//if knight met
                        {
                            int attackedKnights = AttackCounter(matrix, row, col, n);

                            if (mostAttacking < attackedKnights)
                            {
                                mostAttacking = attackedKnights;
                                rowMost = row;
                                colMost = col;
                            }
                        }
                    }
                }

                if (mostAttacking == 0) break;
                else
                {
                    matrix[rowMost, colMost] = '0';
                    //removed knights
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

        static int AttackCounter(char[,] matrix, int row, int col, int n)
        {
            //counter for attacked knights so far
            int attackedKnights = 0;

            //Check all directions
            //left-up 
            if (ValidCell(row - 1, col - 2, n))
            {
                if (matrix[row - 1, col - 2] == 'K') attackedKnights++;
            }

            //left-down
            if (ValidCell(row + 1, col - 2, n))
            {
                if (matrix[row + 1, col - 2] == 'K') attackedKnights++;
            }

            //right-up
            if (ValidCell(row - 1, col + 2, n))
            {
                if (matrix[row - 1, col + 2] == 'K') attackedKnights++;
            }

            //right-down
            if (ValidCell(row + 1, col + 2, n))
            {
                if (matrix[row + 1, col + 2] == 'K') attackedKnights++;
            }

            //up-left
            if (ValidCell(row - 2, col - 1, n))
            {
                if (matrix[row - 2, col - 1] == 'K') attackedKnights++;
            }

            //up-right
            if (ValidCell(row - 2, col + 1, n))
            {
                if (matrix[row - 2, col + 1] == 'K') attackedKnights++;
            }

            //down-left
            if (ValidCell(row + 2, col - 1, n))
            {
                if (matrix[row + 2, col - 1] == 'K') attackedKnights++;
            }

            //down-right
            if (ValidCell(row + 2, col + 1, n))
            {
                if (matrix[row + 2, col + 1] == 'K') attackedKnights++;
            }

            return attackedKnights;
        }

        static bool ValidCell(int row, int col, int n)
        {
            return
                row >= 0 && row < n
                && col >= 0 && col < n;
        }

        static bool SmallerSize(int n)
        {
            return
                n < 3;
        }
    }
}
