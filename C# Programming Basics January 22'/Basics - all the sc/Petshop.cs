using System;

namespace Petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double dogp = 2.50;
            double catp = 4;

            //input
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());

            //calculation
            double total = dogp * dog + catp * cat;

            //output
            Console.WriteLine($"{total} lv.");

        }
    }
}
