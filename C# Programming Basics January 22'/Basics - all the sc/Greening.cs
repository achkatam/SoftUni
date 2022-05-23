using System;

namespace Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double sqm = 7.61;
            double dis = sqm * 0.18;

            //input
            double area = double.Parse(Console.ReadLine());

            //calculation
            double price = area * sqm;
            double discount = price * 0.18;
            double final = price - discount;

            //output
            Console.WriteLine($"The final price is: {final} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }

    }
}
