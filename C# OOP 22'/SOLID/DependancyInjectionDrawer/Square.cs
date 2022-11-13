namespace DependancyInjectionDrawer
{
    using DependancyInjectionDrawer.Renderers;
    using System;
    public class Square : Shape
    {
        //depends on Shape BUT also on Console
        public Square(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing square");
        }
    }
}
