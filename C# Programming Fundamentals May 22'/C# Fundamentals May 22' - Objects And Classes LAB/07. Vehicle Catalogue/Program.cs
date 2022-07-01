using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your task is to create a Vehicle catalog, which contains only Trucks and Cars.

            //You must read the input until you receive the "end" command.It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"

            string command = Console.ReadLine();

            //
            Catalog catalog = new Catalog();


            while (command != "end")
            {
                string[] tokens = command.Split("/");
                string typeVehicle = tokens[0];

                switch (typeVehicle)
                {
                    case "Car":
                        Car car = new Car
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            HorsePower = int.Parse(tokens[3])
                        };
                        catalog.Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            Weight = int.Parse(tokens[3])
                        };
                        catalog.Trucks.Add(truck);
                        break;
                }
                command = Console.ReadLine();
            }
            //In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
            //"Cars:{Brand}: {Model} - {HorsePower} 
            //Trucks:
            //{Brand}: {Model} - {Weight}kg

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach(var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(t => t.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
    class Car
    {
        //Define a class Car with the following properties: Brand, Model, and Horse Power
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
    //Define a class Truck with the following properties: Brand, Model, and Weight.
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    //Define a class Catalog with the following properties: Collections of Trucks and Cars.
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        //Create lists for trucks and cars so we can add them up
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}

