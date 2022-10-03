using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                cars = GetCars(cars);
            }

            string command = Console.ReadLine();



            switch (command)
            {
                case "flammable":
                    PrintFlammable(cars);
                    break;
                case "fragile":
                    PrintFragile(cars);
                    break;
            }

        }

        static void PrintFragile(List<Car> cars)
        {
            var fragile =
                 cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Pressure < 1))
                 .Select(x => x.Model).ToArray();

            Console.WriteLine(string.Join("\n", fragile));
        }

        static void PrintFlammable(List<Car> cars)
        {
            var flammable =
                  cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250)
                  .Select(x => x.Model).ToList();

            Console.WriteLine(string.Join("\n", flammable));
        }

        static List<Car> GetCars(List<Car> cars)
        {
            var tokens = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = tokens[0];
            //Data for the engine
            int speed = int.Parse(tokens[1]);
            int power = int.Parse(tokens[2]);
            Engine engine = new Engine(speed, power);

            //Data for the cargo
            int weight = int.Parse(tokens[3]);
            string type = tokens[4];
            Cargo cargo = new Cargo(type, weight);

            //Data for the tires
            var tires = new Tires[]
            {
                new Tires(double.Parse(tokens[5]), int.Parse(tokens[6])),
                new Tires(double.Parse(tokens[7]), int.Parse(tokens[8])),
                new Tires(double.Parse(tokens[9]), int.Parse(tokens[10])),
                new Tires(double.Parse(tokens[11]), int.Parse(tokens[12])),
            };
            Car car = new Car(model, engine, cargo, tires);

            cars.Add(car);


            return cars;
        }
    }
}
