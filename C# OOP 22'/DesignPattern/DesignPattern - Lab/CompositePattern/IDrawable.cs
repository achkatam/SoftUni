namespace CompositePattern
{
    using System.IO;

    public interface IDrawable
    {
        void Draw();
        void Move(Direction direction);
        void AddChild(IDrawable child);
        void RemoveChild(IDrawable child);
    }
}
