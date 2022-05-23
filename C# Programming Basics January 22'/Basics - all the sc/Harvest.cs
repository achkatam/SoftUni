using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //От лозе с Х кв.м. се заделя 40% за вино.от 1 кв.м. се изкарват Y кг грозде.
            //За 1л вино са нужни 2.5 кг грозде.Желаното количество за продан е  Z л

            //input
            int XArea = int.Parse(Console.ReadLine());
            double YGrapePerSQM = double.Parse(Console.ReadLine());
            int ZneededLiter = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            //calculation
            double totalGrape = XArea * YGrapePerSQM;
            double wine = 0.40 * totalGrape / 2.5;
            double difference = wine - ZneededLiter;
            //Conditinal check
            if (wine < ZneededLiter)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");

            }
            else if (wine >= ZneededLiter)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - ZneededLiter)} liters left -> {Math.Ceiling(wine - ZneededLiter) / workers} liters per person.");
            }
        }
    }
}
