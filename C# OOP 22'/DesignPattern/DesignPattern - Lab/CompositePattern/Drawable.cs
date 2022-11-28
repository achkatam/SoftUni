namespace CompositePattern
{
    using System;
    using System.Collections.Generic;
    

    public class Drawable : IDrawable
    {
        protected List<IDrawable> children;
        protected char[,] shape;

        public Drawable()
        {
            children = new List<IDrawable>();

        }
        public Drawable(Position position) : this()
        {
            Position = position;
        }

        public void AddChild(IDrawable child)
        {
            children.Add(child);
        }

        public Position Position { get; set; }
        public virtual void Draw()
        {
            
            foreach (IDrawable child in children)
            {
                child.Draw();
            }
        }

        public virtual void Move(Direction direction)
        {

            foreach (IDrawable child in children)
            {
                child.Move(direction);
            }
        }

        public void RemoveChild(IDrawable child)
        {
            children.Remove(child);
        }
    }
}
