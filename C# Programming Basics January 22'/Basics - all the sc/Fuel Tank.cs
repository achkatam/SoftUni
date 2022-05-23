using System;

namespace _8.Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string typeFuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());

            //conditional 
            if (litersFuel >= 25)
            {
                if (typeFuel == "Diesel")
                {
                    Console.WriteLine($"You have enough diesel.");
                }
                else if (typeFuel == "Gas")
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else if (typeFuel == "Gasoline")
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine("Invadil fuel!");
                }
            }
            else if (litersFuel < 25)
            {
                if (typeFuel == "Diesel")
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }
                else if (typeFuel == "Gas")
                {
                    Console.WriteLine($"Fill your tank with gas!");

                }
                else if (typeFuel == "Gasoline")
                {
                    Console.WriteLine($"Fill your tank with gasoline!");

                }
                else
                {
                    Console.WriteLine("Invalid fuel!");

                }
            }

        }
    }
}
