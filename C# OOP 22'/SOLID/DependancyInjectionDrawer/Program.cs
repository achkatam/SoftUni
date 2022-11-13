namespace DependancyInjectionDrawer
{
    using System;
    using System.Collections.Generic;

    using DependancyInjectionDrawer.Renderers;

    public class Program
    {
        static void Main(string[] args)
        {
            
            IRenderer renderer = new ConsoleRenderer();

            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle(renderer));

            shapes.Add(new Square(renderer));


            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
