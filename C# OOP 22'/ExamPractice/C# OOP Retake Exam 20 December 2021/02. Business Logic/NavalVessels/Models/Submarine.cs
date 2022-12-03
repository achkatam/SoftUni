namespace NavalVessels.Models
{
    using NavalVessels.Models.Contracts;
    using System.Text;

    public class Submarine : Vessel, ISubmarine
    {
        private const double ARMORTHICKNESS = 200;

        public Submarine(string name, double mainWeaponCaliber, double speed)
            : base(name, mainWeaponCaliber, speed, ARMORTHICKNESS)
        {
            this.SubmergeMode = false;
        }

        public bool SubmergeMode { get; private set; }

        public void ToggleSubmergeMode()
        {
            if (!this.SubmergeMode)
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 4;
            }
            else
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 4;
            }

            this.SubmergeMode = !this.SubmergeMode;
        }
        public override void RepairVessel() => this.ArmorThickness = ARMORTHICKNESS;

        public override string ToString()
        {
            var sb = new StringBuilder();

            string submergeOutput = this.SubmergeMode == false ? "OFF" : "ON";

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Submerge mode: {submergeOutput}");

            return sb.ToString().Trim();
        }
    }
}
