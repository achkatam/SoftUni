using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<string> data;

        public List<string> Data
        {
            get { return data; }
            set { data = value; }
        }


        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Ski = new List<Ski>();
        }

        public List<Ski> Ski { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }


        public void Add(Ski ski)
        {
            if (Ski.Count < Capacity)
            {
                Ski.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            return
                Ski.Remove(Ski.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model));
        }

        public Ski GetNewestSki() => Ski.OrderByDescending(x => x.Year).FirstOrDefault();

        public Ski GetSki(string manufacturer, string model) => Ski.FirstOrDefault(x => x.Manufacturer == manufacturer
        && x.Model == model);

        public int Count { get { return Ski.Count; } }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The skis stored in {Name}:");

            foreach (var ski in Ski)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
