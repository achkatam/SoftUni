using System;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniorsFee = 0;
            double seniorsFee = 0;

            //input
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trailType = Console.ReadLine();

            switch (trailType)
            {
                case "trail":
                    juniorsFee = juniors * 5.50;
                    seniorsFee = seniors * 7;
                    break;
                case "cross-country":
                    if (juniors + seniors >= 50)
                    {
                        juniorsFee = (juniors * 8) - (juniors * 8 * 0.25);
                        seniorsFee = (seniors * 9.50) - (seniors * 9.50 * 0.25);
                    }
                    else
                    {
                        juniorsFee = juniors * 8;
                        seniorsFee = seniors * 9.50;
                    }
                    break;
                case "downhill":
                    juniorsFee = juniors * 12.25;
                    seniorsFee = seniors * 13.75;
                    break;
                case "road":
                    juniorsFee = juniors * 20;
                    seniorsFee = seniors * 21.50;
                    break;
            }
            double moneyCollected = (juniorsFee + seniorsFee) - ((juniorsFee + seniorsFee) * 0.05);
            Console.WriteLine($"{moneyCollected:f2}");
        }
    }
}
