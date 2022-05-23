using System;

namespace Godzilla_Vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double outfit = double.Parse(Console.ReadLine());

            //
            double decor = budget * 0.1;
            double outfitPrice = statist * outfit;

            if (statist > 150)
            {
                outfitPrice = outfitPrice - (outfitPrice * 0.1);
            }
            double expenses = decor + outfitPrice;

            if (budget>= expenses)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-expenses:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {expenses-budget:f2} leva more.");
            }
            
        }
    }
}
