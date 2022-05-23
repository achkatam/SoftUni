using System;

namespace School_supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double pens = 5.80;
            double markers = 7.20;
            double chem = 1.20;

            //input
            int pensC = int.Parse(Console.ReadLine());
            int markersC = int.Parse(Console.ReadLine());
            int chemC = int.Parse(Console.ReadLine());
            int dis = int.Parse(Console.ReadLine());

            //calculations
            double pensSum = pens * pensC;
            double markersSum = markers * markersC;
            double chemSum = chem * chemC;
            double materials = pensSum + markersSum + chemSum;
            double discount = materials + materials *  (dis / 100);
            double total = discount - (materials * dis / 100);
            

            //out
            Console.WriteLine(total);

                




        }

    }
}
