using System;

namespace Swimming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            //calculation
            double neededSec = distanceInMeters * secondsPerMeter;
            //every 15 m add + 12.5 sec;
            double addedSec = Math.Floor(distanceInMeters / 15) * 12.5;

            double totalTime =(neededSec + addedSec);

            //Conditinal check
            if (totalTime < recordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {(totalTime):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime-recordSeconds):f2} seconds slower.");
            }
        }
    }
}
