using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Until you receive the "End" command, you will be receiving lines of input in the following format:
            //"{typeOfVehicle} {model} {color} {horsepower}"

            string[] command = Console.ReadLine().Split();

            //Create list of vehicles
            var vehicles = new List<Vehicle>();

            //While loop
            while (command[0] != "End")
            {
                //Check using boolean if the parse of VehicleType is successfull. If it has any other type, different from Car or Truck, it'll return an error
                VehicleType type;

                bool isSuccessfull = Enum.TryParse(command[0], true, out type);

                //If the boolean is true we can start adding new vehicles
                if (isSuccessfull)
                {
                    string model = command[1], color = command[2];
                    int hp = int.Parse(command[3]);

                    var vehicle = new Vehicle(type, model, color, hp);
                    vehicles.Add(vehicle);
                }
                command = Console.ReadLine().Split();
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue") break;
                //"Type: {typeOfVehicle}
                //Model: { modelOfVehicle}
                //Color: { colorOfVehicle}
                //Horsepower: { horsepowerOfVehicle"

                //Create a variable for a model of a vehicle that you want to see the current information
                var vehicleToCheck = vehicles.FirstOrDefault(x => x.Model == input);
                //Print out the info
                Console.WriteLine(vehicleToCheck);
            }

            //When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the average horsepower of the trucks in the format
            //The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by the total count of all vehicles from that type.Format the answer to the second digit after the decimal point.

            //Create two lists for cars and trucks. Find them in the vehicles list using LINQ
            var cars = vehicles.Where(x => x.Type == VehicleType.Car).ToList();
            var trucks = vehicles.Where(t => t.Type == VehicleType.Truck).ToList();

            //Create variables for average hp fo each vehicle type if type's count is > 0
            //using ternary operator
            var carsAvgHp = cars.Count > 0 ? cars.Average(hp => hp.Horsepower) : 0.00;
            var trucksAvgHp = trucks.Count > 0 ? trucks.Average(hp => hp.Horsepower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHp:f2}.");

        }
    }
    enum VehicleType
    {
        Car,
        Truck
    }
    class Vehicle
    {
        public Vehicle(VehicleType type, string model, string color, int hp)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = hp;
        }
        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public override string ToString()
        {
            //Create new stingbuilder to read eveything at one, less coding in the Main method
            var output = new StringBuilder();
            output.AppendLine($"Type: {Type}");
            output.AppendLine($"Model: {Model}");
            output.AppendLine($"Color: {Color}");
            output.AppendLine($"Horsepower: {Horsepower}");
            return output.ToString().TrimEnd();

        }
    }
}
