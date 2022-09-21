using System;
using System.Linq;
using System.Numerics;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We get as input the size of the field in which our miner moves. The field is always a square. After that, we will receive the commands which represent the directions in which the miner should move. The miner starts from position – 's'. The commands will be: left, right, up, and down. If the miner has reached a side edge of the field and the next command indicates that he has to get out of the field, he must remain in his current position and ignore the current command. The possible characters that may appear on the screen are:
            //•	* – a regular position on the field
            //•	e – the end of the route.
            //•	c - coal
            //•	s - the place where the miner starts
            //Each time when the miner finds coal, he collects it and replaces it with '*'.Keep track of the count of the collected coals. If the miner collects all of the coals in the field, the program stops and you have to print the following message: "You collected all coals! ({rowIndex}, {colIndex})".
            //If the miner steps at 'e' the game is over(the program stops) and you have to print the following message: "Game over! ({rowIndex}, {colIndex})".
            //If there are no more commands and none of the above cases had happened, you have to print the following message: "{remainingCoals} coals left. ({rowIndex}, {colIndex})".

            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            var commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //starting positions
            int startRow = 0, startCol = 0;
            //coals counter
            int coals = 0;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => char.Parse(c))
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    if (input[col] == 's')
                    {
                        //starting position
                        startRow = row;
                        startCol = col;
                    }
                    else if (input[col] == 'c')
                    {
                        coals++;
                    }

                    //fill up the matrix
                    matrix[row, col] = input[col];
                }
            }

            //current position of the player
            int currRow = startRow;
            int currCol = startCol;

            //iterate thru each command
            foreach (var command in commands)
            {
                //boolean if it the game is over
                bool isOver = false;

                //moving upwards and downwards change rows// moving to the right and left change cols
                switch (command)
                {
                    case "up":
                        if (currRow > 0)
                        {
                            currRow--;
                            isOver = SwitchCommand(matrix, ref currRow, ref currCol, ref coals);
                        }
                        break;
                    case "down":
                        if (currRow < matrix.GetLength(0) - 1)
                        {
                            currRow++;
                            isOver = SwitchCommand(matrix, ref currRow, ref currCol, ref coals);
                        }
                        break;
                    case "right":
                        if (currCol < matrix.GetLength(0) - 1)
                        {
                            currCol++;
                            isOver = SwitchCommand(matrix, ref currRow, ref currCol, ref coals);
                        }
                        break;
                    case "left":
                        if (currCol > 0)
                        {
                            currCol--;
                            isOver = SwitchCommand(matrix, ref currRow, ref currCol, ref coals);
                        }
                        break;
                }

                //o	If all the coals have been collected, print the following output: "You collected all coals! ({rowIndex}, {colIndex})".
                //o If you have reached the end, you have to stop moving and print the following line: "Game over! ({rowIndex}, {colIndex})".
                //o If there are no more commands and none of the above cases had happened, you have to print the following message: "{totalCoals} coals left. ({rowIndex}, {colIndex})".

            }

            if (coals == 0)
            {
                Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");

                return;
            }

            if (matrix[currRow, currCol] == 'e')
            {
                Console.WriteLine($"Game over! ({currRow}, {currCol})");

                return;
            }

            Console.WriteLine($"{coals} coals left. ({currRow}, {currCol})");

        }

        static bool SwitchCommand(int[,] matrix, ref int currRow, ref int currCol, ref int coals)
        {
            if (matrix[currRow, currCol] == 'e') return true;//the game ends

            if (matrix[currRow, currCol] == 'c')
            {
                matrix[currRow, currCol] = '*';
                coals--;

                if (coals == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
