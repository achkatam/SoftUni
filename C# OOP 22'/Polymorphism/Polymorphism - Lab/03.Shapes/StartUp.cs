namespace Shapes
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            double heigth = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            Shape shape = new Rectangle(heigth, width);

            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.Draw());
            double radius = double.Parse(Console.ReadLine());

            shape = new Circle(radius);

            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.Draw());

        }
    }
}
