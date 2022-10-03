using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Tires
    {
        //•	Tires: a collection of exactly 4 tires. Each tire should have two properties: age and pressure
        public Tires(double pressure,int age )
        {
            this.Age = age;
            this.Pressure = pressure;
        }

        public int Age { get; set; }
        public double Pressure { get; set; }
    }
}
