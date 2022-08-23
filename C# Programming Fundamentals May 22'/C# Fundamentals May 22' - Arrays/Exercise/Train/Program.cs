using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int numOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numOfWagons];
            //add-ons
            int sum = 0;
            //Solution

            for (int indexOfWagons = 0; indexOfWagons < wagons.Length; indexOfWagons++)
            {
                wagons[indexOfWagons] = int.Parse(Console.ReadLine());
                sum += wagons[indexOfWagons];
            }

            foreach (int wagon in wagons)
            {
                Console.Write(wagon + " ");
            }

            Console.WriteLine($"\n{sum}");

        }
    }
}
