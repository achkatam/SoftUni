using System;

namespace Veggie_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            // veggie = N lv/kg , fruits = M lv/kg, E 1.94

            //input
            double veggiesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            double veggiesWeight = double.Parse(Console.ReadLine());
            double fruitsWeight = double.Parse(Console.ReadLine());


            //calculation
            double veggiesSum = veggiesPrice * veggiesWeight;
            double fruitsSum = fruitsPrice * fruitsWeight;
            double income = veggiesSum + fruitsSum;
            double E = 1.94;
            double euroIncome = income / E;
            

            //output = income from all products in Euro:f2
            Console.WriteLine($"{euroIncome:f2}");

        }
    }
}
