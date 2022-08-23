using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of input, you will receive a number N – the number of cars you have. On each of the next N lines, you will receive the following information about a car: "<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>", where the speed, power and weight are all integers. 

            //Create list of cars
            var cars = new List<Car>();

            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                //<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>
                string[] tokens = Console.ReadLine().Split();

                //Create new car
                var car = new Car(tokens);
                cars.Add(car);
            }

            //After the N lines, you will receive a single line with one of 2 commands: "fragile" or "flamable". . If the command is "flamable" print all of the cars whose Cargo Type is "flamable" and has Engine Power > 250. The cars should be printed in order of appearing in the input.

            string command = Console.ReadLine();

            //Switch case of command
            switch (command)
            {
                case "fragile":
                    //If the command is "fragile" print all cars, whose Cargo Type is "fragile" with cargo, whose weight  < 1000
                    //Create a new list of fragile cargo
                    var fragile = cars.Where(x => x.Cargo.Weight < 1000).ToList();
                    Console.WriteLine(String.Join(Environment.NewLine, fragile.Select(x => x.Model)));
                    break;
                case "flamable":
                    //If the command is "flamable" print all of the cars whose Cargo Type is "flamable" and has Engine Power > 250
                    var flamable = cars.Where(x => x.Engine.Power > 250).ToList();
                    Console.WriteLine(String.Join(Environment.NewLine, flamable.Select(x => x.Model)));
                    break;
            }
        }
    }
    class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Car
    {
        public Car(string[] carInfo)
        {
            //    [0]          [1]        [2]          [3]           [4]
            //"<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>"
            Model = carInfo[0];
            Engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            Cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
        }
        public Cargo Cargo { get; set; }
        public Engine Engine { get; set; }
        public string Model { get; set; }
    }
}
