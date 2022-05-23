using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double N = double.Parse(Console.ReadLine());

            double debitP1 = P1 * N;
            double debitP2 = P2 * N;
            double debitTotal = debitP1 + debitP2;

            double debitTotalPercent = (debitTotal / V) * 100;
            double debitP1Percent = (debitP1 / debitTotal) * 100;
            double debitP2Percent = (debitP2 / debitTotal) * 100;

            double poolOverFlow = (N * (P1 + P2)) - V;

            if (V > debitTotal)
            {
                Console.WriteLine($"The pool is {debitTotalPercent:f2}% full." +
                    $"Pipe 1: {debitP1Percent:f2}%. Pipe 2: {debitP2Percent:f2}%.");
            }
            if (V < debitTotal)
            {
                Console.WriteLine($"For {N:f2} hours the pool overflows with {poolOverFlow:f2} liters.");
            }


        }
    }
}
