using System;

namespace _04._Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int catsCount = int.Parse(Console.ReadLine());

            int smallCatsCount = 0;
            int bigCatsCount = 0;
            int hugeCatsCount = 0;
            double totalFood = 0;
            for (int i = 1; i <= catsCount; i++)
            {
                double foodGr = double.Parse(Console.ReadLine());

                if( foodGr >=100 && foodGr < 200)
                {
                    smallCatsCount++;
                }
                else if (foodGr <300)
                {
                    bigCatsCount++;
                }
                else
                {
                    hugeCatsCount++;
                }
                totalFood += foodGr;
            }
            Console.WriteLine($"Group 1: {smallCatsCount} cats.");
            Console.WriteLine($"Group 2: {bigCatsCount} cats.");
            Console.WriteLine($"Group 3: {hugeCatsCount} cats.");
            Console.WriteLine($"Price for food per day: {(totalFood/1000)*12.45:f2} lv.");
        }
    }
}
