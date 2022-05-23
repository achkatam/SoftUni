using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gasoline = 2.22;
            const double diesel = 2.33;
            const double gas = 0.93;

            const double gasolineWithCard = 2.04;
            const double dieselWithCard = 2.21;
            const double gasWithCard = 0.85;

            string typeOfFuel = Console.ReadLine();
            double fuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double finalSum = 0;

            if (fuel >= 20 && fuel <= 25)
            {
                switch (card)
                {
                    case "Yes":
                        switch (typeOfFuel)
                        {
                            case "Gasoline":
                                finalSum = gasolineWithCard * fuel * 0.92;
                                break;
                            case "Diesel":
                                finalSum = dieselWithCard * fuel * 0.92;
                                break;
                            case "Gas":
                                finalSum = gasWithCard * fuel * 0.92;
                                break;

                        }
                        break;
                    case "No":
                        switch (typeOfFuel)
                        {
                            case "Gasoline":
                                finalSum = gasoline * fuel * 0.92;
                                break;
                            case "Diesel":
                                finalSum = diesel * fuel * 0.92;
                                break;
                            case "Gas":
                                finalSum = gas * fuel * 0.92;
                                break;
                        }
                        break;

                }
            }
            else if (fuel > 25)
            {
                switch (card)
                {
                    case "Yes":
                        switch (typeOfFuel)
                        {
                            case "Gasoline":
                                finalSum = gasolineWithCard * fuel * 0.90;
                                break;
                            case "Diesel":
                                finalSum = dieselWithCard * fuel * 0.90;
                                break;
                            case "Gas":
                                finalSum = gasWithCard * fuel * 0.90;
                                break;

                        }
                        break;
                    case "No":
                        switch (typeOfFuel)
                        {
                            case "Gasoline":
                                finalSum = gasoline * fuel * 0.90;
                                break;
                            case "Diesel":
                                finalSum = diesel * fuel * 0.90;
                                break;
                            case "Gas":
                                finalSum = gas * fuel * 0.90;
                                break;
                        }
                        break;

                }
            }
            else
            {
                switch (card)
                {
                    case "Yes":
                        switch (typeOfFuel)
                        {
                            case "Gasoline":
                                finalSum = gasolineWithCard * fuel;
                                break;
                            case "Diesel":
                                finalSum = dieselWithCard * fuel;
                                break;
                            case "Gas":
                                finalSum = gasWithCard * fuel;
                                break;

                        }
                        break;
                    case "No":
                        switch (typeOfFuel)
                        {
                            case "Gasoline":
                                finalSum = gasoline * fuel;
                                break;
                            case "Diesel":
                                finalSum = diesel * fuel;
                                break;
                            case "Gas":
                                finalSum = gas * fuel;
                                break;
                        }
                        break;

                }
            }
            Console.WriteLine($"{finalSum:f2} lv.");
        }
    }
}
