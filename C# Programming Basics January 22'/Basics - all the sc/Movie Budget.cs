using System;

namespace Movie_budget
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double outfitPerStatist = double.Parse(Console.ReadLine());

            //calculation
            double decor = budget * 0.10;
            double outfit = outfitPerStatist * statist;

            if (statist > 150)
            {
                outfit = outfit - (outfit * 0.10);
            }
            double expenses = decor + outfit;
            if (expenses > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(expenses - budget):f2} leva more.");
            }
            else if (expenses <= budget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - expenses):f2} leva left.");
            }
        }
    }
}
