using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //It's tricky because we gotta use BigInteger because of the ^ operation
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;
            BigInteger bestSnowball = int.MinValue;

            string bestSnowballFormula = "";

            //Attempt solution


            for (int i = 0; i < snowballs; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = (snowballSnow / snowballTime);
                snowballValue = BigInteger.Pow(currentSnowballValue, snowballQuality);

                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballSnow;
                    bestSnowballFormula = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(bestSnowballFormula);
        }
    }
}
