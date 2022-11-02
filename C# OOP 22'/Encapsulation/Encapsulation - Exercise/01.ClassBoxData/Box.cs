using System;
using System.Security.Cryptography;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format
                        (ExceptionMessages.BoxParameterCannotBeZeroOrNegative, nameof(this.Length)));
                }

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format
                        (ExceptionMessages.BoxParameterCannotBeZeroOrNegative, nameof(this.Width)));
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format
                        (ExceptionMessages.BoxParameterCannotBeZeroOrNegative, nameof(this.Height)));
                }

                this.height = value;
            }
        }

        public double SurfaceArea() 
            => 2 * this.Length * this.Width + 2 * this.Length * this.height + 2 * this.Width * this.Height;

        public double LateralSurfaceArea()
            => 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        public double Volume() 
            => this.Length * this.Width * this.Height;
        //Volume = lwh
        //Lateral Surface Area = 2lh + 2wh
        //Surface Area = 2lw + 2lh + 2wh

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
