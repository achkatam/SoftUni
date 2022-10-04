using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace _08.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = GetEngineInfo();

            List<Car> cars = GetCarIngo(engines);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        static List<Car> GetCarIngo(List<Engine> engines)
        {
            List<Car> cars = new List<Car>();

            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = tokens[0];
                Engine engine = engines.Find(x => x.Model == tokens[1]);


                //if length == 2 create and add car only with model and engine
                if (tokens.Length == 2)
                {
                    cars.Add(new Car(model, engine));
                }
                //if length == 3 create and add car with weight/color - depends if it start with digit or not
                else if (tokens.Length == 3)
                {
                    //if it's digit add model, engine and weight
                    if (int.TryParse(tokens[2], out int value))
                    {
                        int weight = value;

                        cars.Add(new Car(model, engine, weight));
                    }
                    //if it's string add with model, engine and color
                    else
                    {
                        string color = tokens[2];

                        cars.Add(new Car(model, engine, color));
                    }
                }
                //if length == 4 create and add engine with  model, engine, weight and color
                else if (tokens.Length == 4)
                {
                    int weight = int.Parse(tokens[2]);
                    string color = tokens[3];

                    cars.Add(new Car(model, engine, weight, color));
                }

            }

            return cars;
        }

        static List<Engine> GetEngineInfo()
        {
            List<Engine> engines = new List<Engine>();

            int numOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfEngines; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = tokens[0];
                int power = int.Parse(tokens[1]);

                //if length == 2 create and add engine only with model and power
                if (tokens.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                //if length == 3 create and add engine with displacement/efficiency - depends if it start with digit or not
                else if (tokens.Length == 3)
                {
                    //if it's digit add model, power and displacement
                    if (int.TryParse(tokens[2], out int value))
                    {
                        int displacement = value;

                        engines.Add(new Engine(model, power, displacement));
                    }
                    //if it's string add with model, power and efficiency
                    else
                    {
                        string efficiency = tokens[2];

                        engines.Add(new Engine(model, power, efficiency));
                    }
                }
                //if length == 4 create and add engine with model, power, displacement and efficiency
                else if (tokens.Length == 4)
                {
                    int displacement = int.Parse(tokens[2]);
                    string efficiency = tokens[3];

                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
            }

            return engines;
        }
    }
}

