using System;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            double capacity = double.Parse(Console.ReadLine());
            double totalFans = double.Parse(Console.ReadLine());

            double fansA = 0;
            double fansB = 0;
            double fansV = 0;
            double fansG = 0;

            for (int i = 0; i < totalFans; i++)
            {
                string sector = Console.ReadLine();
                
                if (sector == "A")
                {
                    fansA++;

                }
                else if (sector =="B")
                {
                    fansB++;
                }
                else if (sector== "V")
                {
                    fansV++;
                }
                else if (sector== "G")
                {
                    fansG++;
                }
            }
            Console.WriteLine($"{fansA/totalFans *100:f2}%");
            Console.WriteLine($"{fansB/totalFans*100:f2}%");
            Console.WriteLine($"{fansV/totalFans*100:f2}%");
            Console.WriteLine($"{fansG/totalFans*100:f2}%");
            Console.WriteLine($"{totalFans/capacity*100:f2}%");

        }
    }
}
