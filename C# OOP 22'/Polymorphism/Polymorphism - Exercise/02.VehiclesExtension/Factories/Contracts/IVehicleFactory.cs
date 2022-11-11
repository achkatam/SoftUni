namespace Vehicles.Factories.Contracts
{

    using Models.Contracts;

    public interface IVehicleFactory
    {
        //same parameters and same varibale type
        IVehicle CreateVehicle(string type, double fuelQnty, double fuelConsumption, double tankCapacity);
    }
}
