namespace PlanetWars.Models.Planets
{
    using PlanetWars.Models.MilitaryUnits.Contracts;
    using PlanetWars.Models.Planets.Contracts;
    using PlanetWars.Models.Weapons.Contracts;
    using PlanetWars.Repositories;
    using PlanetWars.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    public abstract class Planet : IPlanet
    {
        private string name;
        private double budget;
        private UnitRepository units;
        private WeaponRepository weapons;
        private PlanetRepository planets; 
        protected Planet(string name, double budget)
        {
            this.name = name;
            this.budget = budget;
            this.units = new UnitRepository();
            this.weapons = new WeaponRepository();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);

                this.name = value;
            }
        }

        public double Budget
        {
            get => this.budget;
            private set
            {
                if (value < 0)
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);

                this.budget = value;
            }
        }

        public double MilitaryPower => GetTotalPower();

        public IReadOnlyCollection<IMilitaryUnit> Army => this.units.Models;

        public IReadOnlyCollection<IWeapon> Weapons => this.weapons.Models;

        public void AddUnit(IMilitaryUnit unit)
        {
           this.units.AddItem(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.AddItem(weapon);
        }

        public void TrainArmy()
        {
            foreach (var unit in Army)
            {
                unit.IncreaseEndurance();
            }
        }

        public void Spend(double amount)
        {
             if (this.Budget < amount)
                throw new InvalidOperationException(ExceptionMessages.UnsufficientBudget);

            this.Budget -= amount;
        }

        public void Profit(double amount)
        {
            this.Budget += amount;
        }
        public string PlanetInfo()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"Planet: {this.Name}")
            .AppendLine($"--Budget: {this.Budget} billion QUID")
            .Append($"--Forces:")
            .AppendLine(this.Army.Any() ? $"{string.Join(", ", this.units)}" : "No units")
            .Append($"--Combat equipment:")
            .AppendLine(this.Weapons.Any() ? $"{string.Join(", ", this.weapons)}" : "No weapons")
            .AppendLine($"--Military Power: {this.MilitaryPower}");
             
            return sb.ToString().Trim();
        }
         
        private double GetTotalPower()
        {
            double totalPower = Army.Select(x => x.EnduranceLevel).Sum() +
                Weapons.Select(x => x.DestructionLevel).Sum();

            if (Army.Any(x => x.GetType().Name == "AnonymousImpactUnit"))
                totalPower += totalPower + (30 * 100);

            if (Weapons.Any(x => x.GetType().Name == "NuclearWeapon"))
                totalPower += totalPower + (45 * 100);

            return Math.Round(totalPower, 3);
        }
    }
}
