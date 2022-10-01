using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;

        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

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

        public void Drive(double distance)
        {
            double leftFuel = fuelQuantity - (distance * fuelConsumption);

            if (leftFuel < 0)
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");

                return;
            }

            fuelQuantity = leftFuel;
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
        }
    }
}
