namespace Vehicles.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Exceptions;

    using Contracts;
    using Factories.Contracts;
    using IO.Contracts;
    using Models.Contracts;
    using System.IO;
    using Vehicles.Models;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVehicleFactory vehicleFactory;

        private readonly ICollection<IVehicle> vehicles;

        private Engine()
        {
            this.vehicles = new HashSet<IVehicle>();
        }

        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }

        public void Run()
        {
            this.vehicles.Add(this.BuildVehicleUsingFactory());
            this.vehicles.Add(this.BuildVehicleUsingFactory());
            this.vehicles.Add(this.BuildVehicleUsingFactory());

            int n = int.Parse(this.reader.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    this.ProcessCommand();
                }
                catch (InsufficientFuelException ife)
                {
                    this.writer.WriteLine(ife.Message);
                }
                catch (InvalidVehicleTypeException ivte)
                {
                    this.writer.WriteLine(ivte.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            this.PrintAllVehicles();
        }

        private IVehicle BuildVehicleUsingFactory()
        {
            string[] vehicleArgs = this.reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string vehicleType = vehicleArgs[0];
            double vehicleFuelQty = double.Parse(vehicleArgs[1]);
            double vehicleFuelConsumption = double.Parse(vehicleArgs[2]);
            double tankCapacity = double.Parse(vehicleArgs[3]);

            IVehicle vehicle =
                this.vehicleFactory.CreateVehicle(vehicleType, vehicleFuelQty, vehicleFuelConsumption, tankCapacity);
            return vehicle;
        }

        private void ProcessCommand()
        {
            string[] cmdArgs = this.reader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string cmdType = cmdArgs[0];
            string vehicleType = cmdArgs[1];
            double arg = double.Parse(cmdArgs[2]);
            try
            {
                IVehicle vehicleToProcess = this.vehicles
                .FirstOrDefault(v => v.GetType().Name == vehicleType);

                if (vehicleToProcess == null)
                {
                    throw new InvalidVehicleTypeException();
                }

                if (cmdType == "Drive")
                {
                    this.writer.WriteLine(vehicleToProcess.Drive(arg));
                }
                else if (cmdType == "DriveEmpty")
                {
                    this.writer.WriteLine((vehicleToProcess as Bus).DriveEmpty(arg));
                }
                else if (cmdType == "Refuel")
                {
                    vehicleToProcess.Refuel(arg);
                }
            }
            catch (WrongFuelInput wfi)
            {
                Console.WriteLine(wfi.Message);
            }
            catch (OverfillingTheTank oft)
            {
                Console.WriteLine(oft.Message);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void PrintAllVehicles()
        {
            foreach (IVehicle vehicle in this.vehicles)
            {
                this.writer.WriteLine(vehicle.ToString());
            }
        }
    }
}