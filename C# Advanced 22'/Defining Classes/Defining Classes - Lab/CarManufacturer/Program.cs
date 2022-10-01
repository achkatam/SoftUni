using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "748i",
                Year = 2001,
                FuelConsumption = 0.9,
                FuelQuantity = 100
            };

            while (true)
            {
                Console.WriteLine($"Where to go?");
                car.Drive(int.Parse(Console.ReadLine()));

                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
