using System;

namespace Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //основи на трапеца = б1 и б2, височина h
            //formula = (b1+b2)*h/2

            //input
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //calculation
            double area = (b1 + b2) * h / 2;

            //output
            Console.WriteLine($"{area:f2}");

        }
    }
}
