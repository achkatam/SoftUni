using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = GetTiresInfo();
            List<Engine> engines = GetEnginesInfo();
            List<Car> cars = GetCarsInfo(tires, engines);

            var specialCar = cars.FindAll(c => c.Year >= 2017
            && c.Engine.HorsePower > 330
            && c.Tires.Sum(x => x.Pressure) >= 9
            && c.Tires.Sum(x => x.Pressure) <= 10)
                .ToList();

            specialCar.ForEach(c => c.Drive(20));
            specialCar.ForEach(c => Console.WriteLine(c));


            //foreach (var car in specialCar)
            //{
            //    car.Drive(20);
            //    Console.WriteLine(car);
            //}
        }

        static List<Car> GetCarsInfo(List<Tire[]> tires, List<Engine> engines)
        {
            List<Car> cars = new List<Car>();

            string command = Console.ReadLine();

            while (command != "Show special")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                var engine = int.Parse(tokens[5]);
                var tire = int.Parse(tokens[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engine], tires[tire]);

                cars.Add(car);

                command = Console.ReadLine();
            }


            return cars;
        }

        static List<Engine> GetEnginesInfo()
        {
            List<Engine> engines = new List<Engine>();

            string command = Console.ReadLine();

            while (command != "Engines done")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsepower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                Engine engine = new Engine(horsepower, cubicCapacity);

                engines.Add(engine);

                command = Console.ReadLine();
            }

            return engines;
        }

        static List<Tire[]> GetTiresInfo()
        {
            List<Tire[]> tires = new List<Tire[]>();

            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] tire = new Tire[4]
                {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7])),
                };

                tires.Add(tire);

                command = Console.ReadLine();
            }

            return tires;
        }
    }
}
