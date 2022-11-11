namespace Vehicles
{
    using Vehicles.Core;
    using Vehicles.Core.Contracts;
    using Vehicles.Factories;
    using Vehicles.Factories.Contracts;
    using Vehicles.IO;
    using Vehicles.IO.Contracts;

    public class StartUp
    {
        static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            IVehicleFactory vehicleFactory = new VehicleFactory();

            IEngine engine = new Engine(reader, writer, vehicleFactory);
            engine.Run();
        }
    }
}
