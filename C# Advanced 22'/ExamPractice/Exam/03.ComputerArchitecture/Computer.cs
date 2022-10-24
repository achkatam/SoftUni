using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public List<CPU> Multiprocessor { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }

        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Capacity > Count)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand) => Multiprocessor.Remove(Multiprocessor.FirstOrDefault(x => x.Brand == brand));

        public CPU MostPowerful() => Multiprocessor.OrderByDescending(x => x.Frequency).First();

        public CPU GetCPU(string brand) => Multiprocessor.FirstOrDefault(x => x.Brand == brand);
        
        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"CPUs in the Computer {Model}:");

            foreach (var cpu in Multiprocessor)
            {
                sb.AppendLine(cpu.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
