using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads one line of double prices separated by ", ". Print the prices with added VAT for all of them. Format them to 2 signs after the decimal point. The order of the prices must be the same.
            //VAT is equal to 20 % of the price.

            Func<decimal, string> vat = x => (x + (x * 20 / 100)).ToString("f2");

            Console.WriteLine(String.Join("\n"
                ,Console.ReadLine().Split(", "
                ,StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(vat)));

        }
    }
}
