using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            //First create variables for the inputs
            int daysPlundering = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            //add-ons
            double totalPlunder = 0;

            for (int day = 1; day <= daysPlundering; day++)
            {
                totalPlunder += dailyPlunder;
                //, which is 50% of the daily plunder
                if (day % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5;
                }
                //they lose 30% of their total plunder.
                if (day % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 0.3;
                }
            }
            //If the gained plunder is more or equal to the target
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            //If the gained plunder is less than the target. Calculate the percentage left 
            else
            {
                Console.WriteLine($"Collected only {totalPlunder / expectedPlunder * 100:f2}% of the plunder.");
            }

        }
    }
}
