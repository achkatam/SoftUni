using System;

namespace Fish_market
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double midiPKg = 7.50;
            /*palamud = 60% по-скъп от skumriq
             * safrid = 80% по-скъп от caca*/
            

            //input
            double skumriqPriceKg = double.Parse(Console.ReadLine());
            double cacaPriceKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            //calculions
            double palamudSum = skumriqPriceKg + skumriqPriceKg * 0.6;
            double palamudTotal = palamudSum * palamudKg;
            double safridSum = cacaPriceKg + cacaPriceKg * 0.8;
            double safridTotal = safridSum * safridKg;
            double midiSum = midiPKg * midiKg;
            double finalPrice = palamudTotal + safridTotal + midiSum;

            //output
            Console.WriteLine($"{finalPrice:f2}");



        }
    }
}



