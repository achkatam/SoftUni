using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Calculation
            double area = GetAreaParameters(width, height);
            //Output
            Console.WriteLine(area);
        }
        //Create a method that gives you the size of the rectangle, so we can the area 
        static double GetAreaParameters(double width, double height)
        {
            double area = width * height;
            return area;
        }

    }
}
