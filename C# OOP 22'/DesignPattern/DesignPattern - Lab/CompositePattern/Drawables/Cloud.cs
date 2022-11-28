namespace CompositePattern.Drawables
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Cloud : Shape
    {
        public Cloud(Position pos) : base(pos)
        {
            shape = new char[,]
            {
                {' ','*','*',' ', },
                {'*','*','*','*', },
                {' ','*','*',' ', }
            };
        }

      
    }
}
