using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a working code that is a solution to Problem 5.Special Numbers.However, the variables are improperly named, declared before they are needed and some of them are used for multiple things. Without using your previous solution, modify the code so that it is easy to read and understand.
            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0;
            //int takova = 0;
            //bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine("{0} -> {1}", takova, toe);
            //    obshto = 0;
            //    ch = takova;
            //}
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            { 
                int sum = 0;
                int currNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
               bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currNum, isSpecialNum);
                sum = 0;
                i = currNum;
            }
        }
    }
}
