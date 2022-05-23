using System;

namespace Blank
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int m = 0;
            for (h = 0; h < 24; h++)
            {
                for (m = 0; m < 60; m++)
                {
                    Console.WriteLine($"{h:d2}:{m:d2}");
                   
                }
            }
            
        }
    }
}
