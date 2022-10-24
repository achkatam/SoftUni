using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;

namespace Problem2
{
    public class RallyRacing
    {
        class Car
        {
            public Car((int, int) coordinates, int klmsPassed, string carNumber)
            {
                Row = coordinates.Item1;
                Col = coordinates.Item2;
                KlmsPassed = klmsPassed;
                CarNumber = carNumber;
            }

            public int Row { get; set; }
            public int Col { get; set; }
            public int KlmsPassed { get; set; }
            public string CarNumber { get; set; }
            public bool HasWon { get; set; } = false;
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string carNumber = Console.ReadLine();

            var matrix = CreateMatrix(size);

            Car car = new Car((0, 0), 0, carNumber);

            string command = Console.ReadLine().ToLower();

            while (command != "end" && car.HasWon == false)
            {
                int oldRow = car.Row;
                int oldCol = car.Col;

                switch (command)
                {
                    case "up":
                        car.Row--;
                        break;
                    case "down":
                        car.Row++;
                        break;
                    case "right":
                        car.Col++;

                        break;
                    case "left":
                        car.Col--;

                        break;
                }

                if (IsValid(car.Row, car.Col, matrix))
                {
                    matrix[oldRow, oldCol] = '.';
                    (car.Row, car.Col) = Movement(matrix, car, size);
                }

                oldRow = car.Row;
                oldCol = car.Col;

                command = Console.ReadLine().ToLower();
            }

            PrintOutput(car, matrix, size);
        }

        static void PrintOutput(Car car, char[,] matrix, int size)
        {

            if (car.HasWon)
            {
                Console.WriteLine($"Racing car {car.CarNumber} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {car.CarNumber} DNF.");
            }

            Console.WriteLine($"Distance covered {car.KlmsPassed} km.");
            matrix[car.Row, car.Col] = 'C';

            PrintMatrix(matrix, size);
        }

        static (int, int) Movement(char[,] matrix, Car car, int size)
        {
            if (matrix[car.Row, car.Col] == 'T')
            {
                //move to the other side of the tunnel
                (car.Row, car.Col) = GoThroughTunnel(car, matrix);

            }
            else if (matrix[car.Row, car.Col] == '.')
            {
                car.KlmsPassed += 10;
            }
            else if (matrix[car.Row, car.Col] == 'F')
            {
                //finishes the race
                car.HasWon = true;
                car.KlmsPassed += 10;
                //Console.WriteLine($"Racing car {car.CarNumber} finished the stage!");

                //Environment.Exit(0);
            }

          //  PrintMatrix(matrix, size);


            return (car.Row, car.Col);
        }

        static (int, int) GoThroughTunnel(Car car, char[,] matrix)
        {
            matrix[car.Row, car.Col] = '.';
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'T')
                    {
                        car.Row = row;
                        car.Col = col;
                        car.KlmsPassed += 30;
                        matrix[car.Row, car.Col] = '.';

                        return (car.Row, car.Col);
                    }
                }
            }

            return (car.Row, car.Col);
        }

        public static bool IsValid(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0)
                 && col >= 0 && col < matrix.GetLength(1);
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
                var rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
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
