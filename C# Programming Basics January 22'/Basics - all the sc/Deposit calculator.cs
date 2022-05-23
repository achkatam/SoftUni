using System;

namespace Deposit_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double apy = double.Parse(Console.ReadLine());

            //calculations
            double gains = deposit * (apy / 100);
            double aprm = gains / 12;
            double sum = deposit + months * aprm;

            //output
            Console.WriteLine(sum);

        }
    }
}
