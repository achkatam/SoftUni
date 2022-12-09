using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Repositories.Contracts;
using PlanetWars.Utilities.Messages;

namespace PlanetWars.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;
        private double budget;
        private IRepository<IMilitaryUnit> unitRepository;
        private IRepository<IWeapon> weaponRepository;

        public Planet(string name, double budget)
        {
            this.Name = name;
            this.Budget = budget;
            this.unitRepository = new UnitRepository();
            this.weaponRepository = new WeaponRepository();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }

                name = value;
            }
        }

        public double Budget
        {
            get { return budget; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);

                budget = value;
            }
        }

        public double MilitaryPower => CalculateMilitaryPower();
         
        public IReadOnlyCollection<IMilitaryUnit> Army => this.unitRepository.Models;

        public IReadOnlyCollection<IWeapon> Weapons => this.weaponRepository.Models;

        public void AddUnit(IMilitaryUnit unit) => this.unitRepository.AddItem(unit);

        public void AddWeapon(IWeapon weapon) => this.weaponRepository.AddItem(weapon);

        public string PlanetInfo()
        {
           var sb = new StringBuilder();

            string forcesOutput = this.Army.Any() ? $"{string.Join(", ", this.Army.Select(x => x.GetType().Name))}" : "No units";

            string combatOutput = this.Weapons.Count
                 > 0 ? $"{string.Join(", ", this.Weapons.Select(x => x.GetType().Name))}" : "No weapons";

            sb
                .AppendLine($"Planet: {this.Name}")
                .AppendLine($"--Budget: {this.Budget,2} billion QUID")
                .AppendLine($"--Forces: {forcesOutput}")
                .AppendLine($"--Combat equipment: {combatOutput}")
                .AppendLine($"--Military Power: {this.MilitaryPower}");

            return sb.ToString().TrimEnd();
        }

        public void Profit(double amount)
        {
            this.Budget += amount;
        }

        public void Spend(double amount)
        {
            if (this.Budget < amount)
            {
                throw new InvalidOperationException(ExceptionMessages.UnsufficientBudget);
            }

            this.Budget -= amount;
        }

        public void TrainArmy()
        {
            foreach (var unit in this.Army)
            {
                unit.IncreaseEndurance();
            }
        }

        private double CalculateMilitaryPower()
        {
            double totalPower = this.Army.Sum(x => x.EnduranceLevel) + this.Weapons.Sum(x => x.DestructionLevel);

            if (this.unitRepository.Models.Any(x => x.GetType() == typeof(AnonymousImpactUnit)))
                   totalPower *= 1.3;
                
            if(this.weaponRepository.Models.Any(x => x.GetType() == typeof(NuclearWeapon)))
                totalPower *= 1.45;

            return Math.Round(totalPower, 3);
        }
    }
}
