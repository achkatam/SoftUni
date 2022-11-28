namespace CompositePattern.Drawables
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class Shape : Drawable
    {
        public Shape(Position pos) : base(pos)
        {
        }

        public override void Draw()
        {

            foreach (IDrawable child in children)
            {
                child.Draw();
            }
        }
        public override void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Position.Top--;
                    break;
                    case Direction.Down:
                    Position.Top++;
                    break;
                case Direction.Left:
                    Position.Left--;
                    break;
                    case Direction.Right:
                    Position.Left++;
                    break;
                default:break;
            }

            base.Move(direction);
        }
    }
}
