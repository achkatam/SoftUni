using System;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //formula area = a * h / 2

            //input
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //calculation
            double area = a * h / 2;

            //output
            Console.WriteLine($"{area:f2}");


        }
    }
}
