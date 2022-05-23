using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int foodAmount = 1000 * int.Parse(Console.ReadLine());

            string command = string.Empty;

            int totalEatenFood = 0;

            while ((command = Console.ReadLine()) != "Adopted")
            {
                
                int eatenFood = int.Parse(command);

                totalEatenFood += eatenFood;
                
            }
            if (totalEatenFood <= foodAmount)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodAmount - totalEatenFood} grams.");
            }
            else if (totalEatenFood > foodAmount)
            {
                Console.WriteLine($"Food is not enough. You need {totalEatenFood - foodAmount} grams more.");
            }
        }
    }
}
