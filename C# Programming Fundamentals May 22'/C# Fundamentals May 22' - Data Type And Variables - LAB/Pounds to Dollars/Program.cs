using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that converts British pounds to US dollars formatted to the 3rd decimal point.
            //1 British Pound = 1.31 Dollars

            double britishPound = double.Parse(Console.ReadLine());

            double poundToUsdRate = 1.31;
            double result = britishPound * poundToUsdRate;

            Console.WriteLine($"{result:f3}");
        }
    }
}
