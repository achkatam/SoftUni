namespace DependancyInjectionDrawer
{
    using DependancyInjectionDrawer.Renderers;
    using System;
    public class Circle : Shape
    {
        //depends on Shape BUT also on Console
        public Circle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
}
