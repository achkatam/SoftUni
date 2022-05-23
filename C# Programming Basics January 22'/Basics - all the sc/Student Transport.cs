using System;

namespace Student_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            //taxi = нач.тарифа - 0,70. днвена - 0,79 лв/км , нощна - 0,90 лв/км
            //автобус = днвена/нощна = 0,09 лв/км. най-малко 20 км.
            //влак = днвена/нощна = 0,06 лв/км. най- малко 100км

            //input
            int nKM = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            //Conditional
            if (time == "day")
            {
                if (nKM < 20)
                {
                    double taxiPrice = 0.70 + nKM * 0.79;
                    Console.WriteLine($"{taxiPrice:f2}");
                }
                else if (nKM >= 20 && nKM <= 99)
                {
                    double busPrice = 0.09 * nKM;
                    Console.WriteLine($"{busPrice:f2}");
                }
                else if (nKM > 100)
                {
                    double trainPrice = 0.06 * nKM;
                    Console.WriteLine($"{trainPrice:f2}");
                }
                
            }
            else if (time == "night")
            {
                if (nKM < 20)
                {
                    double taxiPrice = 0.70 + 0.90 * nKM;
                    Console.WriteLine($"{taxiPrice:f2}");
                }
                else if ( nKM >= 20 && nKM <=99)
                {
                    double busPrice = 0.09 * nKM;
                    Console.WriteLine($"{busPrice:f2}");
                }
                else if (nKM > 100)
                {
                    double trainPrice = 0.06 * nKM;
                    Console.WriteLine($"{trainPrice:f2}");
                }
            }
        }
    }
}
