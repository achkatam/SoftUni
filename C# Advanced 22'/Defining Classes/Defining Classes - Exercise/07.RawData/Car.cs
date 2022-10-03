using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            Tires = tires;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }

        public override string ToString() => $"{this.Model}\n";
        
    }
}
