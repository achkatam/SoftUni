using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fishes;
        private string material;
        private int capacity;

        public string Material { get; set; }
        public int Capacity { get; set; }
        public List<Fish> Fish { get; set; }

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }

        public int Count { get { return Fish.Count; } }

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Length <= 0 || fish.Weight <= 0)
            {
                return "Invalid fish.";
            }

            if (Count == Capacity)
            {
                return "Fishing net is full.";
            }

            Fish.Add(fish);

            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            return Fish.Remove(Fish.Find(x => x.Weight == weight));
        }

        public Fish GetFish(string fishType)
        {
            return Fish.Find(x => x.FishType == fishType);
        }

        public Fish GetBiggestFish()
        {
            //return Fish.OrderByDescending(x => x.Length).First();
            Fish biggestFish = null;
            double longestLength = double.MinValue;

            foreach (var fish in Fish)
            {
                if (fish.Length > longestLength)
                {
                    longestLength = fish.Length;
                    biggestFish = fish;
                }
            }

            return biggestFish;
        }

        public string Report()// - returns information about the Net and all fish that were not released, order by fish's length descending  in the following format:	
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Into the {Material}:");

            foreach (var fish in Fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd(); 
        }
        //o	"Into the {material}:
        //{Fish1
        //    }
        //{Fish2
        //}


    }
}
