using System;

namespace _04._Numbers_Divided_by_3_Without_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 99; i++)
            {
                if ( i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
