using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //1 Fields
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        //2. Properties
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                this.year = value;
            }
        }


        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        //3. Constructors
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }


        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        //4. Methods
        public void Drive(double distance)
        {
            double fuelNeeded = FuelConsumption * distance / 100;

            if (fuelNeeded >= FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= fuelNeeded;
            }
        }

        public override string ToString() => $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nHorsePowers: {this.Engine.HorsePower}\nFuelQuantity: {this.FuelQuantity}";


        //public string WhoAmI()
        //{
        //    return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
        //}
    }
}
