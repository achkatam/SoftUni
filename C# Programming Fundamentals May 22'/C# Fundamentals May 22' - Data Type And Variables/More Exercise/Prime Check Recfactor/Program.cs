using System;

namespace Prime_Check_Recfactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a program that checks if numbers in a given range[2...N] are prime. For each number is printed "{number} -> {true or false}".The code, however, is not very well written.Your job is to modify it in a way that is easy to read and understand.
            //Code
            //Sample Code
            //int ___Do___ = int.Parse(Console.ReadLine());
            //            for (int takoa = 2; takoa <= ___Do___; takoa++)
            //            {
            //                bool takovalie = true;
            //                for (int cepitel = 2; cepitel < takoa; cepitel++)
            //                {
            //                    if (takoa % cepitel == 0)
            //                    {
            //                        takovalie = false;
            //                        break;
            //                    }
            //                }
            //Console.WriteLine("{0} -> {1}", takoa, takovalie);

            //input
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i <= n; i++)
            {
                isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        
                    }
                }
                Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
