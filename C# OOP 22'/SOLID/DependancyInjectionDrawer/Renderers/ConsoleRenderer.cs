namespace DependancyInjectionDrawer.Renderers
{
    using System;

    public class ConsoleRenderer : IRenderer
    {
        public void Write(object text)
        {
            Console.Write(text);
        }

        public void WriteAt(int y, int x)
        {
            Console.SetCursorPosition(y, x);
        }

        public void WriteLine(object text)
        {
            Console.WriteLine(text);
        }
    }
}
