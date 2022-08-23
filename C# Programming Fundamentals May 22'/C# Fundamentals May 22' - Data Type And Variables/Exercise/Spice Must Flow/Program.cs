using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MINIMUM_SPICES_TO_BE_MINED = 100;
            const int DAILY_DECREASING_BY = 10;

            //input
            int countOfSpices = int.Parse(Console.ReadLine());
            int totalMined = 0;
            int daysCounter = 0;

            //Attempt Solution
            while (countOfSpices >= MINIMUM_SPICES_TO_BE_MINED)
            {
                totalMined += countOfSpices - CONSUMED_BY_WORKERS;
                countOfSpices -= DAILY_DECREASING_BY;
                daysCounter++;
                if (countOfSpices < MINIMUM_SPICES_TO_BE_MINED)
                {
                    totalMined -= CONSUMED_BY_WORKERS;
                }
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalMined);


        }
    }
}
