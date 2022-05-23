using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int locationsCount = int.Parse(Console.ReadLine());
            double totalAverage = 0;

            for (int i = 1; i <= locationsCount; i++)
            {
                double expectedAvergaeSupply = double.Parse(Console.ReadLine());
                int daysForMining = int.Parse(Console.ReadLine());
                double totalMined = 0;

                for (int j = 1; j <= daysForMining; j++)
                {
                    double minedGold = double.Parse(Console.ReadLine());
                    totalMined += minedGold;


                }
                totalAverage = totalMined / daysForMining;
                if (totalAverage >= expectedAvergaeSupply)
                {
                    Console.WriteLine($"Good job! Average gold per day: {totalAverage:f2}.");

                }
                else
                {
                    Console.WriteLine($"You need {Math.Abs(expectedAvergaeSupply - totalAverage):f2} gold.");

                }
            }

        }
    }
}
