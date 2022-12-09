using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private ICollection<IDecoration> decorations;
        private ICollection<IFish> fishes;

        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);

                name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort => this.decorations.Sum(x => x.Comfort);

        public ICollection<IDecoration> Decorations => this.decorations;

        public ICollection<IFish> Fish => this.fishes;

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (fishes.Count == Capacity)
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);

            this.fishes.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in this.fishes)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            var sb = new StringBuilder();

            string fishOutput = this.fishes.Any() ? $"{string.Join(", ", this.fishes)}"
                : "none";

            sb
                .AppendLine($"{this.Name} ({this.GetType().Name}):")
                .AppendLine($"Fish: {fishOutput}")
                .AppendLine($"Decorations: {this.decorations.Count}")
                .AppendLine($"Comfort: {this.Comfort}");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveFish(IFish fish)
        {
            return this.fishes.Remove(fish);
        }
    }
}
