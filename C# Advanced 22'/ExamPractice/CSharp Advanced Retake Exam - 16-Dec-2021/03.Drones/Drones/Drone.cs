using System.Xml.Linq;
using System;
using System.Text;

namespace Drones
{
    public class Drone
    {
        //•	Name: string
        //•	Brand: string
        //•	Range: int
        //•	Available: boolean - true by default
        //The class constructor should receive(name, brand, range). 
        //The class should also have a method:
        //•	Override the ToString() method in the format:
        //     "Drone: {name}
        //  Manufactured by: {brand
        //    }
        //    Range: {range
        //}
        //kilometers "


        public Drone(string name, string brand, int range)
        {
            Name = name;
            Brand = brand;
            Range = range;
            Available = true;
        }

        public string Name { get; set; }
        public string Brand { get; set; }
        public int Range { get; set; }
        public bool Available { get; set; }

        public override string ToString()
        {
            return $"Drone: {Name}" + Environment.NewLine +
                $"Manufactured by: {Brand}" + Environment.NewLine +
                $"Range: {Range} kilometers";
        }
    }
}
