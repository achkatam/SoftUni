namespace DependancyInjectionDrawer
{
    using DependancyInjectionDrawer.Renderers;
    using System;

    public abstract class Shape
    {
        protected IRenderer renderer;

        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public int Top { get; set; }

        public int Left { get; set; }

        public abstract void Draw();
    }
}
