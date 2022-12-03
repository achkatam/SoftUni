namespace NavalVessels.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NavalVessels.Models.Contracts;
    using NavalVessels.Utilities.Messages;

    public abstract class Vessel : IVessel
    {
        private string name;
        private double mainWeaponCaliber;
        private double speed;
        private double armorThickness;
        private ICaptain captain;
        private List<string> targets;

        private Vessel()
        {
            this.targets = new List<string>();
        }
        protected Vessel(string name, double mainWeaponCaliber, double speed, double armorThickness) : this()
        {
            this.Name = name;
            this.MainWeaponCaliber = mainWeaponCaliber;
            this.Speed = speed;
            this.ArmorThickness = armorThickness;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(ExceptionMessages.InvalidVesselName);

                this.name = value;
            }
        }

        public ICaptain Captain
        {
            get => this.captain;
            set
            {
                if (value == null)
                    throw new NullReferenceException(ExceptionMessages.InvalidCaptainToVessel);

                this.captain = value;
            }
        }
        public double ArmorThickness
        {
            get => this.armorThickness;
            set => this.armorThickness = value;
        }


        public double MainWeaponCaliber
        {
            get => this.mainWeaponCaliber;
            protected set { this.mainWeaponCaliber = value; }
        }

        public double Speed
        {
            get => this.speed;
            protected set
            {
                this.speed = value;
            }
        }

        public ICollection<string> Targets {get;private set; }


        public void Attack(IVessel target)
        {
            if (target == null)
                throw new NullReferenceException(ExceptionMessages.InvalidTarget);

            target.ArmorThickness -= this.MainWeaponCaliber;

            if (target.ArmorThickness < 0)
            {
                target.ArmorThickness = 0;
            }

            this.targets.Add(target.Name);

            target.Captain.IncreaseCombatExperience();
            this.Captain.IncreaseCombatExperience();
        }

        public abstract void RepairVessel();

        public override string ToString()
        {
            var sb = new StringBuilder();

            string targetOutput = this.targets.Any() ? $"{string.Join(", ", targets)}" : "None";

            sb
                .AppendLine($"- {this.Name}")
                .AppendLine($" *Type: {this.GetType().Name}")
                .AppendLine($" *Armor thickness: {this.ArmorThickness}")
                .AppendLine($" *Main weapon caliber: {this.MainWeaponCaliber}")
                .AppendLine($" *Speed: {this.Speed} knots")
                .AppendLine($" *Targets: {targetOutput}");

            return sb.ToString().Trim();
        }
    }
}
