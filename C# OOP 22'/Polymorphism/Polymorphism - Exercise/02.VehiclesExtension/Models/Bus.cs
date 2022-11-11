namespace Vehicles.Models
{
    using Vehicles.Enums;


    public class Bus : Vehicle
    {
        private const double FuelConsumptionIncrement = 1.4;
        private AirConditioner ac;


        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            ac = AirConditioner.IsOn;
        }

        public override string Drive(double distance)
        {
            if (ac == AirConditioner.IsOn)
            {
                this.FuelConsumption += FuelConsumptionIncrement;
                ac = AirConditioner.IsOff;
            }

            return base.Drive(distance);
        }

        public string DriveEmpty(double distance)
        {
            if (ac == AirConditioner.IsOff)
            {
                this.FuelConsumption -= FuelConsumptionIncrement;
                ac = AirConditioner.IsOn;
            }


            return base.Drive(distance);
        }
    }
}
