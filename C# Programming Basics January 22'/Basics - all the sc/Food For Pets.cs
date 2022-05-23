using System;

namespace Food_For_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int totalDays = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());


            double biscuit = 0;
            double eatenFood = 0;
            int totalDogFood = 0;
            int totalCatFood = 0;

            for (int day = 1; day <= totalDays; day++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());

                totalDogFood += dogFood;
                totalCatFood += catFood;
                eatenFood += dogFood + catFood;
                if (day % 3 == 0)
                {
                    biscuit += (dogFood+catFood) * 0.1;
                }

            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuit)}gr.");
            Console.WriteLine($"{eatenFood/totalFood*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalDogFood/eatenFood*100:f2}% eaten from the dog.");
            Console.WriteLine($"{totalCatFood/eatenFood*100:f2}% eaten from the cat.");

        }
    }
}
