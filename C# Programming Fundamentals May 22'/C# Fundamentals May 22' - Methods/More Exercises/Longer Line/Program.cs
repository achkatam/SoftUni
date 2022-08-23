using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            //coordinate data
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            //Output
            CenterCloserPoints(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void CenterCloserPoints(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            //The formula is Маth.Sqrt(X.Sqrt + Y.Sqrt )
            double closer1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double closer2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            double closer3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            double closer4 = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            //Create pair for easier calculations
            double firstPair = closer1 + closer2;
            double secondPair = closer3 + closer4;

            //The greater pair shoud be taken then should be printed the closer point first !!!
            //If it's true, means the firstPair is greater so we will work with it
            if (GetLargerPair(firstPair, secondPair) == true)
            {
                //Compare which pair between closer1, closer2 is closer to the center line
                if (closer1 > closer2)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            else
            {
                //Compare which pair between closer3, closer4 is closer to the center line
                if (closer3 > closer4)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
        }
        static bool GetLargerPair(double firstPair, double secondPair)
        {
            //Compare which pair is larger, shoud be printed later by the complaints
            if (firstPair > secondPair)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
