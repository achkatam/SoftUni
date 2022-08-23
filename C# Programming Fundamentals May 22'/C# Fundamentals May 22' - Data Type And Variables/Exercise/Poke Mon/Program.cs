using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int startingPower = power;
            int targetCoutner = 0;

            //Attempt solution
            while (power >= distance)
            {
                power -= distance;
                targetCoutner++;
                if (startingPower * 0.5 == power && exhaustionFactor > 0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(targetCoutner);
        }
    }
}
