namespace NavalVessels.Models
{
    using NavalVessels.Models.Contracts;
    using System.Text;

    public class Battleship : Vessel, IBattleship
    {
        private const int ARMORTHICKNESS = 300;
        public Battleship(string name, double mainWeaponCaliber, double speed)
            : base(name, mainWeaponCaliber, speed, ARMORTHICKNESS)
        {
            this.SonarMode = false;
        }

        public bool SonarMode { get; private set; }

        public void ToggleSonarMode()
        {
            if (!this.SonarMode)
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 5;
            }
            else
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 5;
            }

            this.SonarMode = !this.SonarMode;
        }

        public override void RepairVessel() => this.ArmorThickness = ARMORTHICKNESS;

        public override string ToString()
        {
            var sb = new StringBuilder();

            string sonarOutput = this.SonarMode == false ? "OFF" : "ON";
            sb.AppendLine(sonarOutput);
            sb.AppendLine(base.ToString());

            return sb.ToString().Trim();
        }
    }
}
