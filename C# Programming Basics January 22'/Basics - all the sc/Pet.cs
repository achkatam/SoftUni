using System;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int days = int.Parse(Console.ReadLine());
            int foodLeftInKg = int.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodGr = double.Parse(Console.ReadLine());
            double KgTurtleFood = turtleFoodGr / 1000;

            //calculation
            double neededFood = days * (dogFoodKg + catFoodKg + KgTurtleFood);
            
            //conditional check
            if (neededFood <= foodLeftInKg)
            {
                double leftOver = foodLeftInKg - neededFood;
                Console.WriteLine($"{Math.Floor(leftOver)} kilos of food left.");
            }
            else if (neededFood > foodLeftInKg)
            {
                double moreFoodNeeded = neededFood - foodLeftInKg;
                Console.WriteLine($"{Math.Ceiling(moreFoodNeeded)} more kilos of food are needed.");
            }
            
            
        }
    }
}
