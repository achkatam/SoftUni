namespace DependancyInjectionDrawer.Renderers
{
    public interface IRenderer
    {
        void Write(object text);

        void WriteLine(object text);

        void WriteAt(int y, int x);
    }
}
