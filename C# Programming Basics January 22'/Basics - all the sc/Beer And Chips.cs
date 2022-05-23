using System;

namespace _02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string fanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerBottles = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            //calculations
            double beerPrice = 1.2 * beerBottles;
            double chipsPrice =(beerPrice * 0.45);
            chipsPrice = Math.Ceiling(chipsCount * chipsPrice);
            double totalSum = chipsPrice + beerPrice;

            if (totalSum <= budget)
            {
                Console.WriteLine($"{fanName} bought a snack and has {budget-totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{fanName} needs {Math.Abs(budget-totalSum):f2} more leva!");
            }
            


        }
    }
}
