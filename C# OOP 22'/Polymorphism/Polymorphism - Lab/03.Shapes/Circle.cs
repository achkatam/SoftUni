namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radiius
        {
            get => this.radius;
            private set => this.radius = value;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        => 2 * Math.PI * radius;

        public override string Draw()
        {
            return base.Draw() + $"{this.GetType().Name}";
        }
    }
}
