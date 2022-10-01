using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsepower;
        private double cubicCapacity;

        public int HorsePower
        {
            get { return horsepower; }
            set { horsepower = value; }
        }

        public double CubicCapacity
        {
            get { return cubicCapacity; }
            set { cubicCapacity = value; }
        }

        public Engine(int horsepower, double cubicCapacity)
        {
            HorsePower = horsepower;
            CubicCapacity = cubicCapacity;
        }

    }
}
