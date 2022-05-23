using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {            
            //input
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qnt = double.Parse(Console.ReadLine());

            double price = 0;
            switch (city)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        price = qnt * 0.5;
                    }
                    else if (product == "water")
                    {
                        price = qnt * 0.8;
                    }
                    else if (product == "beer")
                    {
                        price = qnt * 1.2;
                    }
                    else if (product == "sweets")
                    {
                        price = qnt * 1.45;
                    }
                    else if (product == "peanuts")
                    {
                        price = qnt * 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        price = qnt * 0.4;
                    }
                    else if (product == "water")
                    {
                        price = qnt * 0.7;
                    }
                    else if (product == "beer")
                    {
                        price = qnt * 1.15;
                    }
                    else if (product == "sweets")
                    {
                        price = qnt * 1.30;
                    }
                    else if (product == "peanuts")
                    {
                        price = qnt * 1.5;
                    }
                    break;
                case "Varna":
                    if (product == "coffee")
                    {
                        price = qnt * 0.45;
                    }
                    else if (product == "water")
                    {
                        price = qnt * 0.7;
                    }
                    else if (product == "beer")
                    {
                        price = qnt * 1.1;
                    }
                    else if (product == "sweets")
                    {
                        price = qnt * 1.35;
                    }
                    else if (product == "peanuts")
                    {
                        price = qnt * 1.55;
                    }
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
