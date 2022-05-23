using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int groupOfTrekkers = int.Parse(Console.ReadLine());

            double musala = 0;
            double monblan = 0;
            double kilimandzharp = 0;
            double k2 = 0;
            double everst = 0;
            double trekkers = 0;
            double totalHikers = 0;

            for (int i = 1; i <= groupOfTrekkers; i++)
            {
                 trekkers = int.Parse(Console.ReadLine());

                if (trekkers <= 5)
                {
                    musala += trekkers;
                }
                else if (trekkers <=12)
                {
                    monblan += trekkers;
                }
                else if (trekkers <=25)
                {
                    kilimandzharp += trekkers;
                }
                else if (trekkers <= 40)
                {
                    k2 += trekkers;
                }
                else if (trekkers >= 41)
                {
                    everst += trekkers;
                }
                
            }
            totalHikers += musala + monblan + kilimandzharp + k2 + everst; 

            musala = musala / totalHikers * 100.0;
            monblan = monblan / totalHikers * 100.0;
            kilimandzharp = kilimandzharp / totalHikers * 100.0;
            k2 = k2 / totalHikers * 100.0;
            everst = everst / totalHikers * 100.0;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimandzharp:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everst:f2}%");
        }
    }
}
