namespace Shapes
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            IDrawable rec = new Rectangle(width, height);

            circle.Draw();
            rec.Draw();
        }
    }
}
