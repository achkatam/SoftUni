using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU(string brand, int cores, double frequency)
        {
            Brand = brand;
            Cores = cores;
            Frequency = frequency;
        }

        public string Brand { get; set; }
        public int Cores { get; set; }
        public double Frequency { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            //frqcny:f1
            //"{brand} CPU:
            //Cores: { cores}
            //Frequency: { frequency} GHz"

            sb.AppendLine($"{Brand} CPU:");
            sb.AppendLine($"Cores: { Cores}");
            sb.AppendLine($"Frequency: {Frequency:F1} GHz");

            return sb.ToString().Trim();
        }

    }
}
