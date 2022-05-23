using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            //input 
            int n = int.Parse(Console.ReadLine());

            double n9 = 0;
            double n19 = 0;
            double n29 = 0;
            double n39 = 0;
            double n50 = 0;
            double invalidNum = 0;
            double pointsSum = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                
                if (num >= 0 && num <= 9)
                {
                    n9++;
                    pointsSum += num * 0.2;
                }
                else if (num >=10 && num <= 19)
                {
                    n19++;
                    pointsSum += num * 0.3;
                }
                else if (num >=20 && num <=29)
                {
                    n29++;
                    pointsSum += num * 0.4;
                }
                else if (num >= 30 && num <=39)
                {
                    n39++;
                    pointsSum +=  50;
                }
                else if (num >=40 && num <=50)
                {
                    n50++;
                    pointsSum += 100;
                }
                if (num <0 && num >50)
                {
                    invalidNum++;
                    pointsSum = pointsSum / 2;
                }


            }
            Console.WriteLine($"{pointsSum:f2}");




        }
    }
}
