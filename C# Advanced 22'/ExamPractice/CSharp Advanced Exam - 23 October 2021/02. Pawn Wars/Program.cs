using System;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace _02._Pawn_Wars
{
    class Pawn
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Color { get; set; }

        public Pawn((int, int) position, string color)
        {
            Row = position.Item1;
            Col = position.Item2;
            Color = color;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //chess board size is 8x8
            int size = 8;

            char[,] chessBoard = GetBoard(size);

            int row = 0;
            int col = 0;

            Pawn white = new Pawn(GetPosition(chessBoard, 'w'), "White");
            Pawn black = new Pawn(GetPosition(chessBoard, 'b'), "Black");

            bool whiteTurn = true;

            while (true)
            {
                if (whiteTurn)
                {


                    if (white.Row == 0)
                    {
                        //promote to a queen
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {(char)(97 + white.Col)}8.");

                        return;
                    }

                    if (IsValid(white.Row - 1, white.Col - 1, chessBoard) && chessBoard[white.Row - 1, white.Col - 1] == 'b')
                    {
                        //up-left diagonal
                        //hits the black pawn
                        white.Row--;
                        white.Col--;

                        Console.WriteLine($"Game over! White capture on {(char)(97 + white.Col)}{8 - white.Row}.");

                        return;
                    }

                    if (IsValid(white.Row - 1, white.Col + 1, chessBoard) && chessBoard[white.Row - 1, white.Col + 1] == 'b')
                    {
                        //up-right diagonal
                        //hits the black pawn
                        white.Row--;
                        white.Col++;

                        Console.WriteLine($"Game over! White capture on {(char)(97 + white.Col)}{8 - white.Row}.");

                        return;
                    }


                    //otherwise keep going up the board
                    white.Row--;
                    chessBoard[white.Row, white.Col] = 'w';

                }
                else
                {
                    if (black.Row == 7)
                    {
                        //gets promoted to a queen
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {(char)(97 + black.Col)}1.");

                        return;
                    }

                    if (IsValid(black.Row + 1, black.Col + 1, chessBoard) && chessBoard[black.Row + 1, black.Col + 1] == 'w')
                    {
                        //down-right
                        //hits the white pawn

                        black.Row++;
                        black.Col++;

                        Console.WriteLine($"Game over! Black capture on {(char)(97 + black.Col)}{8 - black.Row}.");

                        return;
                    }

                    if (IsValid(black.Row + 1, black.Col - 1, chessBoard) && chessBoard[black.Row + 1, black.Col - 1] == 'w')
                    {
                        //down-left
                        //hits the white pawn

                        black.Row++;
                        black.Col--;

                        Console.WriteLine($"Game over! Black capture on {(char)(97 + black.Col)}{8 - black.Row}.");

                        return;
                    }

                    //otherwise keep going down
                    black.Row++;
                    chessBoard[black.Row, black.Col] = 'b';
                }

                whiteTurn = !whiteTurn;
            }

            PrintBoard(chessBoard, size);

        }

        public static bool IsValid(int row, int col, char[,] chessBoard)
        {
            return row >= 0 && row < chessBoard.GetLength(0)
                && col >= 0 && col < chessBoard.GetLength(1);
        }

        public static (int, int) GetPosition(char[,] chessBoard, char color)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    if (chessBoard[row, col] == color)
                    {
                        return (row, col);
                    }
                }
            }

            return (0, 0);
        }

        public static void PrintBoard(char[,] board, int size)
        {
            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {
                    Console.Write(board[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static char[,] GetBoard(int size)
        {
            char[,] board = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                var rowData = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    board[row, col] = rowData[col];
                }
            }

            return board;
        }
    }
}
