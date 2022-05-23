using System;

namespace Food_delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double chicken = 10.35;
            double fish = 12.40;
            double veggie = 8.15;
            double delivery = 2.50;

            //input
            int chickenC = int.Parse(Console.ReadLine());
            int fishC = int.Parse(Console.ReadLine());
            int veggieC = int.Parse(Console.ReadLine());

            //calculations
            double chickenT = chicken * chickenC;
            double fishT = fishC * fish;
            double veggieT = veggieC * veggie;
            double dessert = (chickenT + fishT + veggieT) * 0.20;
            double meal = chickenT + fishT + veggieT + dessert;
            double total = meal + delivery;

            //output
            Console.WriteLine(total);



        }
    }
}
