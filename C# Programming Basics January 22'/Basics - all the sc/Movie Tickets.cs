using System;

namespace Movie_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (char symbol1 = (char)a1; symbol1 <= a2-1; symbol1++)
            {
                for (int symbol2 = 1; symbol2 <= n-1; symbol2++)
                {
                    for (int symbol3 = 1; symbol3 <= n/2-1; symbol3++)
                    {
                        if (symbol1 %2 !=0 && (symbol2+symbol3+(int)symbol1) %2 != 0)
                        {
                            Console.WriteLine($"{symbol1}-{symbol2}{symbol3}{(int)symbol1}");
                        }
                    }
                }
            }

        }
    }
}
