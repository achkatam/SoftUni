using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) : this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power, displacement)
        {
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
