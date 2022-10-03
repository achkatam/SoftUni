using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _06.Speed_Racing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           var cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //"{model} {fuelAmount} {fuelConsumptionFor1km}"
                var carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKm = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKm);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = tokens[1];
                double distance = double.Parse(tokens[2]);

                Car car = cars.Find(x => x.Model == model);

                car.Drive(distance);

                command = Console.ReadLine();
            }

            cars.ForEach(car => Console.WriteLine(car));

        }
    }
}
