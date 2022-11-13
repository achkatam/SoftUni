namespace DependancyInjectionDrawer
{
    using DependancyInjectionDrawer.Renderers;
    using System;

    public class Button
    {
        private IRenderer renderer;

        //constructor injection
        //public Button(IRenderer renderer)
        //{
        //    this.renderer = renderer;
        //}

        //prop injection
        public IRenderer Renderer { get; set; }

        //
        public void Draw(IRenderer renderer)
        {
            renderer.WriteLine("Button");
        }

    }
}
