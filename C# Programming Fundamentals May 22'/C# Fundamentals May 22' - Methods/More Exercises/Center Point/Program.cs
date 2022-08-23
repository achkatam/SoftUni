using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2, and Y2. Create a method that prints the point that is closest to the center of the coordinate system(0, 0) in 
            //the format(X, Y). If the points are at the same distance from the center, print only the first one

            //coordinate data
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CenterCloserPoints(x1, y1, x2, y2);
        }
        static void CenterCloserPoints(double x1, double y1, double x2, double y2)
        {
            //The formula is Маth.Sqrt(X.Sqrt + Y.Sqrt )
            double closer1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double closer2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (closer2 >= closer1)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
