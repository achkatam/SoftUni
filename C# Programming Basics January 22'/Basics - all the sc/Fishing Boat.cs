using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Цената зависи от сезона:
•	Цената за наем на кораба през пролетта е  3000 лв.
•	Цената за наем на кораба през лятото и есента е  4200 лв.
•	Цената за наем на кораба през зимата е  2600 лв.
В зависимост от броя си групата ползва отстъпка:
•	Ако групата е до 6 човека включително  –  отстъпка от 10%.
•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15%.
•	Ако групата е от 12 нагоре  –  отстъпка от 25%. 
Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
Напишете програма, която да пресмята дали рибарите ще съберат достатъчно */
            //input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double tripPrice = 0;
            //
            switch (season)
            {
                case "Spring":
                    tripPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    tripPrice = 4200;
                    break;
                case "Winter":
                    tripPrice = 2600;
                    break;
            }
            if (fishermen <= 6)
            {
                tripPrice -= tripPrice * 0.1;
            }
            else if (fishermen > 7 && fishermen <= 11)
            {
                tripPrice -= tripPrice * 0.15;
            }
            else if ( fishermen >12)
            {
                tripPrice -= tripPrice * 0.25;
            }
            if (fishermen %2 == 0 && season!= "Autumn")
            {
                tripPrice -= tripPrice * 0.05;                
            }
            if (budget >= tripPrice)
            {
                Console.WriteLine($"Yes! You have {budget - tripPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {tripPrice - budget:f2} leva.");
            }
        }
    }
}
