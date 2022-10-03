using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Cargo
    {
        //•	Cargo: a class with two properties – type and weight
        public Cargo(string type, int Weight)
        {
            this.Type = type;
            this.Weight = Weight;
        }
        public string Type { get; set; }
        public int Weight { get; set; }
    }
}
