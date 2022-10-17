using System;
using System.Linq;
using System.Security.Cryptography;

namespace _02.Survivor
{
    public class Program
    {

        private static char[][] beach;
        private static int playerRow;
        private static int playerCol;
        private static int tokensCnt;
        private static int opponentsTokens;


        static void Main(string[] args)
        {
            //Create the beach with its tokens and dashes 
            CreateBeach();

            string command = Console.ReadLine();

            while (command != "Gong")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

               // PrintBeach(beach);

                switch (cmd)
                {
                    case "Find":
                        {
                             playerRow = int.Parse(tokens[1]);
                             playerCol = int.Parse(tokens[2]);

                            if (IsValid(playerRow, playerCol, beach))
                            {
                                if (beach[playerRow][playerCol] == 'T') tokensCnt++;
                                beach[playerRow][playerCol] = '-';
                            }
                        }
                        break;
                    case "Opponent":
                        {
                            OpponentMove(tokens, beach);

                        }
                        break;
                }

                //PrintBeach(beach);
                command = Console.ReadLine();
            }


            PrintBeach(beach);

            PrintOutput(tokensCnt, opponentsTokens);
        }
        public static void PrintOutput(int tokensCnt, int opponentTokens)
        {
            Console.WriteLine($"Collected tokens: {tokensCnt}");
            Console.WriteLine($"Opponent's tokens: {opponentsTokens}");
        }
        public static void OpponentMove(string[] tokens, char[][] beach)
        {
            int opponentRow = int.Parse(tokens[1]);
            int opponentCol = int.Parse(tokens[2]);
            string direction = tokens[3];

            if (IsValid(opponentRow, opponentCol, beach))
            {
                if (beach[opponentRow][opponentCol] == 'T')
                {
                    beach[opponentRow][opponentCol] = '-';
                    opponentsTokens++;
                }

                switch (direction)
                {
                    case "up":
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (IsValid(opponentRow - 1, opponentCol, beach))
                                {
                                    opponentRow--;

                                    if (beach[opponentRow][opponentCol] == 'T')
                                    {
                                        beach[opponentRow][opponentCol] = '-';
                                        opponentsTokens++;
                                    }
                                }
                            }
                        }
                        break;
                    case "down":
                        for (int i = 0; i < 3; i++)
                        {
                            if (IsValid(opponentRow + 1, opponentCol, beach))
                            {
                                opponentRow++;

                                if (beach[opponentRow][opponentCol] == 'T')
                                {
                                    beach[opponentRow][opponentCol] = '-';
                                    opponentsTokens++;
                                }
                            }
                        }
                        break;
                    case "left":
                        for (int i = 0; i < 3; i++)
                        {
                            if (IsValid(opponentRow, opponentCol - 1, beach))
                            {
                                opponentCol--;

                                if (beach[opponentRow][opponentCol] == 'T')
                                {
                                    beach[opponentRow][opponentCol] = '-';
                                    opponentsTokens++;
                                }
                            }
                        }
                        break;
                    case "right":
                        for (int i = 0; i < 3; i++)
                        {
                            if (IsValid(opponentRow, opponentCol + 1, beach))
                            {
                                opponentCol++;

                                if (beach[opponentRow][opponentCol] == 'T')
                                {
                                    beach[opponentRow][opponentCol] = '-';
                                    opponentsTokens++;
                                }
                            }
                        }
                        break;
                }

               // PrintBeach(beach);
            }
        }

        public static bool IsValid(int playerRow, int playerCol, char[][] beach)
        {
            return playerRow >= 0 && playerRow < beach.Length
                && playerCol >= 0 && playerCol < beach[playerRow].Length;
        }

        public static void PrintBeach(char[][] beach)
        {
            for (int row = 0; row < beach.GetLength(0); row++)
            {
                for (int col = 0; col < beach[row].Length; col++)
                {
                    Console.Write(beach[row][col] + " ");
                }

                Console.WriteLine();
            }
        }

        public static void CreateBeach()
        {
            int size = int.Parse(Console.ReadLine());

            beach = new char[size][];

            for (int row = 0; row < size; row++)
            {
                var rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                beach[row] = rowData;
            }
        }
    }
}
