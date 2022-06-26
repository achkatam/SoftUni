using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDayPerWroker = int.Parse(Console.ReadLine());

            int workersCnt = int.Parse(Console.ReadLine());

            //biscuit produced by competing factory for 30 days
            int compete = int.Parse(Console.ReadLine());
            
            double totalBisc = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    totalBisc += Math.Floor(biscuitsPerDayPerWroker * workersCnt * 0.75);
                }
                else
                {
                    totalBisc += biscuitsPerDayPerWroker * workersCnt;

                }

            }

            Console.WriteLine($"You have produced {totalBisc} biscuits for the past month.");

            double diff = Math.Abs(compete - totalBisc);

            if (totalBisc >= compete)
            {
                Console.WriteLine($"You produce {diff / compete * 100:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {diff / compete * 100:f2} percent less biscuits.");
            }

        }
    }
}
