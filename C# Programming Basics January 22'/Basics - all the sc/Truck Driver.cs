using System;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKm = 0;
            double money = 0;

            //input
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double salaryPerSeason = 0;
            double tax = 0;

            switch (season)
            {
                case "Spring":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 0.75;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                        

                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 0.95;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKm = 1.45;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    break;
                case "Autumn":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 0.75;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 0.95;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKm = 1.45;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    break;
                case "Summer":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 0.90;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 1.1;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKm = 1.45;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    break;
                case "Winter":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKm = 1.05;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKm = 1.25;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKm = 1.45;
                        money = pricePerKm * kmPerMonth;
                        salaryPerSeason = money * 4;
                        tax = salaryPerSeason - (salaryPerSeason * 0.1);
                    }
                    break;                    
            }
            Console.WriteLine($"{tax:f2}");
        }
    }
}
