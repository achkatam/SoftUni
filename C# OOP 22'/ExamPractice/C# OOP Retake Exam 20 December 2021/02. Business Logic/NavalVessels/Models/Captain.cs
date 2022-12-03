namespace NavalVessels.Models.Contracts
{
    using NavalVessels.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Captain : ICaptain
    {
        private string fullName;
        private List<IVessel> vessels;
        private int increasingCombatExp = 10;

        private Captain()
        {
            this.vessels = new List<IVessel>();
            this.CombatExperience = 0;
        }
        public Captain(string fullName) : this()
        {
            this.FullName = fullName;
        }
        public string FullName
        {
            get => this.fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(ExceptionMessages.InvalidCaptainName);

                this.fullName = value;
            }
        }

        public int CombatExperience { get; private set; }

        public ICollection<IVessel> Vessels => this.vessels;

        public void AddVessel(IVessel vessel)
        {
            if (vessel == null) throw new NullReferenceException(ExceptionMessages.InvalidVesselForCaptain);

            this.vessels.Add(vessel);
        }

        public void IncreaseCombatExperience() => this.CombatExperience += increasingCombatExp;

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.FullName} has {this.CombatExperience} combat experience and commands {this.vessels.Count} vessels.");

            if (this.vessels.Any())
            {
                foreach (var vessel in vessels)
                {
                    sb.AppendLine(vessel.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
