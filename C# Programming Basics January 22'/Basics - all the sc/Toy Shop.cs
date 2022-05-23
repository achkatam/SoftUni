using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());

            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int teddyCount = int.Parse(Console.ReadLine());
            int minnionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            

            //total count
            int toys = puzzleCount + dollCount + teddyCount + minnionCount + truckCount;

            //toys prices
            double toysPrice = puzzleCount * 2.60 +
                dollCount * 3 +
                teddyCount * 4.10 +
                minnionCount * 8.20 +
                truckCount * 2;


            if (toys >= 50)
            {
                toysPrice = toysPrice - toysPrice * 0.25;
            }
            toysPrice = toysPrice - toysPrice * 0.10;

            if (toysPrice > tripPrice)
            {
                Console.WriteLine($"Yes! {toysPrice - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice-toysPrice:f2} lv needed.");
            }



        }
    }
}
