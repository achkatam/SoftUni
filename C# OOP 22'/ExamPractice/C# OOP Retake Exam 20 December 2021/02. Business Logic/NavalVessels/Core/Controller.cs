namespace NavalVessels.Core
{
    using NavalVessels.Core.Contracts;
    using NavalVessels.Models;
    using NavalVessels.Models.Contracts;
    using NavalVessels.Repositories;
    using NavalVessels.Repositories.Contracts;
    using NavalVessels.Utilities.Messages;
    using System.Collections.Generic;
    using System.Linq;

    public class Controller : IController
    {
        private const double UNARMOREDVESSEL = 0;
        private VesselRepository vesselRepository;
        private ICollection<ICaptain> captains;

        public Controller()
        {
            this.vesselRepository = new VesselRepository();
            this.captains = new HashSet<ICaptain>();
        }

        public string HireCaptain(string fullName)
        {
            if (this.captains.Any(x => x.FullName == fullName))
            {
                return string.Format(OutputMessages.CaptainIsAlreadyHired, fullName);
            }

            ICaptain captain = new Captain(fullName);

            this.captains.Add(captain);

            return string.Format(OutputMessages.SuccessfullyAddedCaptain, fullName);
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            IVessel existingVessel = this.vesselRepository.FindByName(name);

            if (existingVessel != null)
                return string.Format(OutputMessages.VesselIsAlreadyManufactured, vesselType, name);

            IVessel vessel = null;
            switch (vesselType)
            {
                case "Submarine":
                    vessel = new Submarine(name, mainWeaponCaliber, speed);
                    break;
                case "Battleship":
                    vessel = new Battleship(name, mainWeaponCaliber, speed);
                    break;
                default:
                    return OutputMessages.InvalidVesselType;
            }

            this.vesselRepository.Add(vessel);

            return
                string.Format(OutputMessages.SuccessfullyCreateVessel, vesselType, name, mainWeaponCaliber, speed);
        }

        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            if (!this.captains.Any(x => x.FullName == selectedCaptainName))
                return string.Format(OutputMessages.CaptainNotFound, selectedCaptainName);

            if (this.vesselRepository.FindByName(selectedVesselName) == null)
                return string.Format(OutputMessages.VesselNotFound, selectedVesselName);

            IVessel vessel = this.vesselRepository.FindByName(selectedVesselName);

            ICaptain captain = this.captains.First(x => x.FullName == selectedCaptainName);

            if (vessel.Captain != null)
                return string.Format(OutputMessages.VesselOccupied, selectedVesselName);

            vessel.Captain = captain;
            captain.AddVessel(vessel);

            return
                string.Format(OutputMessages.SuccessfullyAssignCaptain, selectedCaptainName, selectedVesselName);
        }

        //may not exist
        public string CaptainReport(string captainFullName)
        {
            ICaptain captain = this.captains.FirstOrDefault(x => x.FullName == captainFullName);

            return captain?.Report();
        }

        //may not exist
        public string VesselReport(string vesselName)
        {
            IVessel vessel = this.vesselRepository.FindByName(vesselName);

            return vessel?.ToString();
        }

        public string ToggleSpecialMode(string vesselName)
        {
            IVessel vessel = this.vesselRepository.FindByName(vesselName);

            if (vessel == null)
                return string.Format(OutputMessages.VesselNotFound, vesselName);

            if (vessel.GetType() == typeof(Battleship) && vessel != null)
            {
                Battleship battleship = (Battleship)vessel;

                battleship.ToggleSonarMode();

                return string.Format(OutputMessages.ToggleBattleshipSonarMode, vesselName);
            }
            else if (vessel.GetType() == typeof(Submarine) && vessel != null)
            {
                Submarine submarine = (Submarine)vessel;

                submarine.ToggleSubmergeMode();

                return string.Format(OutputMessages.ToggleSubmarineSubmergeMode, vesselName);
            }

            return null;
        }

        public string ServiceVessel(string vesselName)
        {

            IVessel vessel = this.vesselRepository.FindByName(vesselName);

            if (vessel == null)
            {
                return string.Format(OutputMessages.VesselNotFound, vesselName);
            }
            else
            {
                vessel.RepairVessel();
                return string.Format(OutputMessages.SuccessfullyRepairVessel, vesselName);
            }
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            IVessel attacking = this.vesselRepository.FindByName(attackingVesselName);
            IVessel defending = this.vesselRepository.FindByName(defendingVesselName);

            if (attacking == null)
            {
                return string.Format(OutputMessages.VesselNotFound, attackingVesselName);
            }

            if (defending == null)
            {
                return string.Format(OutputMessages.VesselNotFound, defendingVesselName);
            }

            if (attacking.ArmorThickness == UNARMOREDVESSEL)
            {
                return string.Format(OutputMessages.AttackVesselArmorThicknessZero, attackingVesselName);
            }

            if (defending.ArmorThickness == UNARMOREDVESSEL)
            {
                return string.Format(OutputMessages.AttackVesselArmorThicknessZero, defendingVesselName);
            }

            attacking.Attack(defending);

            return string.Format(OutputMessages.SuccessfullyAttackVessel, defendingVesselName, attackingVesselName, defending.ArmorThickness);
        }
    }
}
