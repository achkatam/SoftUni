﻿namespace Vehicles.Models
{

    using Contracts;
    using Exceptions;


    public abstract class Vehicle : IVehicle
    {

        protected Vehicle(double fuelQuantity, double fuelConsumption,  double tankCapacity)
        {

            this.FuelQuantity = fuelQuantity;
            //the counsumption increses coused by using the AC
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;

            if (this.FuelQuantity > this.TankCapacity)
                this.FuelQuantity = 0;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; private set; }

        public virtual string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;

            if (neededFuel > this.FuelQuantity)
            {
                //not enough fuel
                throw new InsufficientFuelException
                    (string.Format(ExceptionMessage.InsufficientFuelExceptionMessage, this.GetType().Name));
            }

            this.FuelQuantity -= neededFuel;

            return $"{this.GetType().Name} travelled {distance} km";
        }

        //public string DriveEmpty(double distance)
        //{
        //    double neededFuel = distance * this.FuelConsumption;

        //    if (neededFuel > this.FuelQuantity)
        //    {
        //        //not enough fuel
        //        throw new InsufficientFuelException
        //            (string.Format(ExceptionMessage.InsufficientFuelExceptionMessage, this.GetType().Name));
        //    }

        //    this.FuelQuantity -= neededFuel;

        //    return $"{this.GetType().Name} travelled {distance} km";
        //}

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new WrongFuelInput(ExceptionMessage.WRONG_FUEL_INPUT);
            }

            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new OverfillingTheTank(
                    string.Format(ExceptionMessage.OVERFILLING_THE_TANK, liters));
            }

            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
