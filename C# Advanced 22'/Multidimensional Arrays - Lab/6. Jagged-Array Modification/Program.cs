using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read a jagged array
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rowsCount][];
            for (int row = 0; row < rowsCount; row++)
            {
                jagged[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            //Execute the commands
            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split(' ');
                string cmd = tokens[0];

                if (cmd == "Add" || cmd == "Subtract")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    int val = int.Parse(tokens[3]);

                    if (cmd == "Subtract")
                    {
                        val = -val;
                    }
                    if (row >= 0 && row < jagged.Length
                        && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += val;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }

            //Print the jagged array
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }

        }
    }
}
