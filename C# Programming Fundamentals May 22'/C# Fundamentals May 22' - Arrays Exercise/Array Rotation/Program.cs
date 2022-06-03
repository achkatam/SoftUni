using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //add-ons
            int rotations = int.Parse(Console.ReadLine());
            //Solution
            for (int rotation = 0; rotation < rotations; rotation++)
            {
                int tempEl = array[0];
                for (int operation = 0; operation < array.Length -1; operation++)
                {
                    array[operation] = array[operation + 1];
                }
                array[array.Length - 1] = tempEl;
            }
            Console.WriteLine(string.Join(' ', array));

        }
    }
}
