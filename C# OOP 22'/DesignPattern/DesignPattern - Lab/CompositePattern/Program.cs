namespace CompositePattern
{
    using CompositePattern.Drawables;
    using System;
    using System.Threading;

    public class Program
    {
        static void Main(string[] args)
        {
            IDrawable page = new Drawable();

            IDrawable clouds = new Drawable();

            clouds.AddChild(new Cloud(new Position(5, 13)));
            clouds.AddChild(new Cloud(new Position(2, 33)));
            clouds.AddChild(new Cloud(new Position(15, 23)));

            IDrawable lines = new Drawable();

            lines.AddChild(new Line(new Position(0, 0)));
            lines.AddChild(new Line(new Position(25, 0)));
            lines.AddChild(new Line(new Position(24, 0)));

            page.AddChild(lines);
            page.AddChild(clouds);

            while (true)
            {
                Console.Clear();
                page.Draw();

                page.Move(Direction.Right);
                Thread.Sleep(1000);
            }


            Console.ReadLine();
        }
    }
}
