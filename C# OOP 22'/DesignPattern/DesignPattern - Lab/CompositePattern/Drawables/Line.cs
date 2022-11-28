namespace CompositePattern.Drawables
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Line : Shape
    {
        public Line(Position pos) : base(pos)
        {
            shape = new char[,]
            {
               {'-','-','-','-' }
            };
        }

       
    }
}
