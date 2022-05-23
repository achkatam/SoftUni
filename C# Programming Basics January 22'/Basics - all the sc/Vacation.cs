using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            //input 
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            //add-ins
            string staying1 = "Camp";
            string straying2 = "Hut";
            string staying3 = "Hotel";
            string destination1 = "Alaska";
            string destination2 = "Morocco";
            switch (season)
            {
                case "Summer":
                    if (budget <= 1000)
                    {
                        string staying = staying1;
                        string location = destination1;
                        price = budget * 0.65;
                        Console.WriteLine($"{location} - {staying} - {price:f2}");
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        string staying = straying2;
                        string location = destination1;
                        price = budget * 0.8;
                        Console.WriteLine($"{location} - {staying} - {price:f2}");
                    }
                    else if (budget > 3000)
                    {
                        string staying = staying3;
                        string location = destination1;
                        price = budget * 0.9;
                        Console.WriteLine($"{location} - {staying} - {price:f2}");
                    }
                    break;

                case "Winter":
                    if (budget <= 1000)
                    {
                        string staying = staying1;
                        string location = destination2;
                        price = budget * 0.45;
                        Console.WriteLine($"{location} - {staying} - {price:f2}");
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        string staying = straying2;
                        string location = destination2;
                        price = budget * 0.6;
                        Console.WriteLine($"{location} - {staying} - {price:f2}");
                    }
                    else if (budget > 3000)
                    {
                        string staying = staying3;
                        string location = destination2;
                        price = budget * 0.9;
                        Console.WriteLine($"{location} - {staying} - {price:f2}");
                    }
                    break;
            }


        }
    }
}
