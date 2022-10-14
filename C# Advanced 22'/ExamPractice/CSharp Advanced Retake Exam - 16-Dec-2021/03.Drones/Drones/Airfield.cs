using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }

        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }


        public int Count
        {
            get
            {
                return Drones.Count;
            }
        }

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand)
                || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }
            else if (Count == Capacity)
            {
                return "Airfield is full.";
            }
            else
            {
                Drones.Add(drone);

                return $"Successfully added {drone.Name} to the airfield.";
            }
        }

        //•	bool RemoveDrone(string name) - removes a drone by given name, if such exists return true, otherwise false
        public bool RemoveDrone(string name)
        {
            //if it does not exist will return false;
            return Drones.Remove(Drones.Find(x => x.Name == name));
        }

        //•	int RemoveDroneByBrand(string brand) - removes all drones by the given brand, if such exists, return how many drones were removed, otherwise 0.
        public int RemoveDroneByBrand(string brand)
        {
            int count = Drones.RemoveAll(x => x.Brand == brand);

            return count;
        }

        //•	Drone FlyDrone(string name) method – fly (set its available property to false without removing it from the collection) the drone with the given name if exists. As a result return the drone, or null if does not exist.
        public Drone FlyDrone(string name)
        {
            var drone = Drones.Find(x => x.Name == name);

            if (drone != null)
            {
                drone.Available = false;
            }

            return drone;

        }

        //•	List<Drone> FlyDronesByRange(int range) method - fly and returns all drones which have a range equal or bigger to the given. Return a list of all drones which have been flown. The range will always be valid.

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = Drones.FindAll(x => x.Range >= range).ToList();

            foreach (var drone in drones)
            {
                //use the method above, so it will change its availability to false
                FlyDrone(drone.Name);
            }

            return drones;
        }

        //•	Report() - returns information about the airfield and drones which are not in flight in the following format:
        public string Report()
        {
            var drones = Drones.FindAll(x => x.Available == true);

            return $"Drones available at {Name}:" + Environment.NewLine +
                $"{string.Join(Environment.NewLine, drones)}";
        }
    }
}
