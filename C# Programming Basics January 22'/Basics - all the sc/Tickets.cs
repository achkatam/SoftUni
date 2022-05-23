using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double VIP = 499.99;
            double Normal = 249.99;
            //input
            double budget = double.Parse(Console.ReadLine());
            string cat = Console.ReadLine();
            int ppl = int.Parse(Console.ReadLine());
            double transport = 0;
            double difference = 0;
            double tickets = 0;

            //conditional
            if (ppl <= 4)
            {
                transport = budget * 0.75;
            }
            else if (ppl >= 5 && ppl<=9)
            {
                transport = budget * 0.60;
            }
            else if (ppl >= 10 && ppl <= 24)
            {
                transport = budget * 0.50;
            }
            else if ( ppl >= 25 && ppl <=49)
            {
                transport = budget * 0.40;
            }
            else if ( ppl >= 50)
            {
                transport = budget * 0.25;
            }
            switch (cat)
            {
                case "VIP":
                    tickets = ppl * VIP;
                    break;
                case "Normal":
                    tickets = ppl * Normal;
                    break;
                    
            }
            difference = budget - transport - tickets;
            if (difference > 0)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva.");
            }
        }
    }
}
