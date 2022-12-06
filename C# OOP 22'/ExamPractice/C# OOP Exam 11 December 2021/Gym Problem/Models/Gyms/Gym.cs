using Gym.Models.Gyms.Contracts;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Utilities.Messages;
namespace Gym.Models.Gyms
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Gym : IGym
    {
        private string name;

        private ICollection<IEquipment> equipments;
        private ICollection<IAthlete> athletes;

        private Gym()
        {
            this.equipments = new List<IEquipment>();
            this.athletes = new List<IAthlete>();
        }
        protected Gym(string name, int capacity) : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);

                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public double EquipmentWeight => Math.Round(this.equipments.Sum(x => x.Weight),2);

        public ICollection<IEquipment> Equipment => this.equipments;

        public ICollection<IAthlete> Athletes => this.athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if (this.Capacity == this.athletes.Count)
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);

            this.athletes.Add(athlete);
        }

        public bool RemoveAthlete(IAthlete athlete) => this.athletes.Remove(athlete);

        public void AddEquipment(IEquipment equipment) => this.equipments.Add(equipment);

        public void Exercise()
        {
            foreach (var athlete in this.athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            var sb = new StringBuilder();

            string athletesOutput = this.athletes.Any() ? $"{string.Join(", ", this.athletes.Select(x => x.FullName))}" : "No athletes";

            sb
                .AppendLine($"{this.Name} is a {this.GetType().Name}:")
                .AppendLine($"Athletes: {athletesOutput}")
                .AppendLine($"Equipment total count: {this.equipments.Count}")
                .AppendLine($"Equipment total weight: {this.EquipmentWeight:f2} grams");

            return sb.ToString().TrimEnd();
        }

        
    }
}
