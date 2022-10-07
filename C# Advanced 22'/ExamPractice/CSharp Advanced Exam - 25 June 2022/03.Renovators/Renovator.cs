using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Renovators
{
    public class Renovator
    {
        //You are given a class Renovator,  create the following fields:
        //•	Name: string
        //•	Type: string
        //•	Rate: double
        //•	Days: int
        //•	Hired: boolean - false by default
        //The class constructor should receive(name, type, rate, days). 
        //The class should also have a method:
        //•	Override the ToString() method in the format:
        //     "-Renovator: {name}
        //--Specialty: {type
        //    }
        //--Rate per day: {rate} BGN"
        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;
            Hired = false;
        }

        public string Name { get; }
        public string Type { get; }
        public double Rate { get; }
        public int Days { get; }
        public bool Hired { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"-Renovator: {this.Name}");
            output.AppendLine($"--Specialty: {this.Type}");
            output.AppendLine($"--Rate per day: {this.Rate} BGN");
            return output.ToString().TrimEnd();
        }
    }
}
