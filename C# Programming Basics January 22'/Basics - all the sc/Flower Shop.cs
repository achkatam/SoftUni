using System;

namespace _0._7_Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double magnolia = 3.25;
            double hyacinth = 4;
            double roses = 3.50;
            double cactuses = 8;

            //input
            int magnoliaCounts = int.Parse(Console.ReadLine());
            int hyacinthCounts = int.Parse(Console.ReadLine());
            int rosesCounts = int.Parse(Console.ReadLine());
            int cactusesCounts = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            //calculation
            double totalFlowerPrice = magnolia * magnoliaCounts +
                hyacinth * hyacinthCounts +
                roses * rosesCounts +
                cactuses * cactusesCounts;

            double taxMoney = totalFlowerPrice - (totalFlowerPrice * 0.05);

            //conditinal check
            if (taxMoney >= giftPrice)
            {
                double moneyLeft = taxMoney - giftPrice;
                Console.WriteLine($"She is left with {Math.Floor(moneyLeft)} leva.");
            }
            else if (taxMoney < giftPrice)
            {
                double moneyShort = giftPrice - taxMoney;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyShort)} leva.");
            }


        }
    }
}
