using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //време за обедна почивка 8/8
            // 1/8 = за обяд
            // 1//4 = за отдих = 2/8
            // 1/8(обяд) + 2/8(почивка) - 3/8 сме заети
            //колко свободно време ни остава

            //ако имаме 80 мин почивка
            // 8/8 - 3/8 = 5/8 за сериала от обедната ни почивка
            //то имаме 50 мин за сериал от почивката 

            string series = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double timeForSeries = breakTime * 5.0 / 8;
            if (timeForSeries >= seriesTime)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(timeForSeries- seriesTime)} minutes " +
                    $"free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(seriesTime- timeForSeries)} more minutes.");
            }
            
        }
    }
}

