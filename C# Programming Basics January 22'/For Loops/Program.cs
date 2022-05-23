using System;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // F O R L O O P S

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            int[] luckyNums = { 4, 8, 15, 16, 23, 42 };
            foreach(int luckyNumber in luckyNums)
            {
                Console.WriteLine(luckyNumber);
            }
        }
    }
}
