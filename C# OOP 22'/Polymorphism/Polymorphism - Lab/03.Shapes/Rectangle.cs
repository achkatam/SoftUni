namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Height
        {
            get => this.height;
            private set => this.height = value;
        }

        public double Wigth
        {
            get => this.width;
            private set => this.width = value;
        }

        //area = height * width
        //perimeter = 2 * (height + width)
        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        => 2 * (height + width);

        public override string Draw()
        {
            return base.Draw() + $"{this.GetType().Name}";
        }
    }
}
