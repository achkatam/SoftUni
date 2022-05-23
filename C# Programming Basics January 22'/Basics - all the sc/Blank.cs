using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    for (int s = 0; s <= 59; s++)
                    {
                        Console.WriteLine($"{h:d2}:{m:d2}:{s:d2}");
                        Thread.Sleep(1000);

                        if (h ==22 && m ==30)
                    }
                }
            }
        }
    }
}
