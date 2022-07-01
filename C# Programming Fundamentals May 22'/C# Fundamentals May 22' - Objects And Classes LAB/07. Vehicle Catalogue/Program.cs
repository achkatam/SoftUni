using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //You must read the input until you receive the "end" command.It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
            Catalogue catalogue = new Catalogue();

            string command = Console.ReadLine();

            while (command != "end")
            {
                //Pay attention to the way of separating
                string[] tokens = command.Split("/");
                string typeVehicle = tokens[0];

                //Switch case of type vehicle, create cars and trucks and add them in the catalogue list
                switch (typeVehicle)
                {
                    case "Car":
                        Car car = new Car
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            HorsePower = int.Parse(tokens[3])
                        };
                        catalogue.Cars.Add(car);
                        break;

                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            Weight = int.Parse(tokens[3])
                        };
                        catalogue.Trucks.Add(truck);
                        break;
                }
                command = Console.ReadLine();
            }
            //In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
            if (catalogue.Cars.Count > 0)
            {
                List<Car> orderedCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
                //"Cars:
                //{ Brand}: { Model} - {hp}hp
                Console.WriteLine($"Cars:");

                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{ car.Brand}: { car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogue.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalogue.Trucks.OrderBy(t => t.Brand).ToList();
                Console.WriteLine($"Trucks:");

                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        //Create two lists for car and truck so we can add them up after we create them
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
