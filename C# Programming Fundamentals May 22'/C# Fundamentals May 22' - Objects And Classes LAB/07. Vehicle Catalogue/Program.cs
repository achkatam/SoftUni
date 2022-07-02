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
            //Define a class Truck with the following properties: Brand, Model, and Weight.
            //Define a class Car with the following properties: Brand, Model, and Horse Power.
            //Define a class Catalog with the following properties: Collections of Trucks and Cars.
            //You must read the input until you receive the "end" command.It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"

            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string[] cmd = Console.ReadLine().Split('/');

                if (cmd[0] == "end") break;
                switch (cmd[0])
                {
                    case "Car":
                        var car = new Car
                        {
                            Brand = cmd[1],
                            Model = cmd[2],
                            HorsePower = int.Parse(cmd[3])
                        };
                        catalogue.Cars.Add(car);
                        break;

                    case "Truck":
                        var truck = new Truck
                        {
                            Brand = cmd[1],
                            Model = cmd[2],
                            Weight = int.Parse(cmd[3])
                        };
                        catalogue.Trucks.Add(truck);
                        break;
                }
            }
            //In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
            //            "Cars:
            //{ Brand}: { Model} - { Horse Power}hp
            //Trucks:
            //{ Brand}: { Model} - { Weight}kg
            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                catalogue.Cars.OrderBy(brand => brand.Brand).ToList().ForEach(car => Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp"));
            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                catalogue.Trucks.OrderBy(brand => brand.Brand).ToList().ForEach(truck => Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg"));
            }
        }
    }
    class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
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
}
