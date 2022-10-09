using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;
        private string name;
        private int capacity;

        public List<Animal> Animals { get; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Zoo(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Animals = new List<Animal>();
        }

        public string AddAnimal(Animal animal)
        {
            //	If the animal species is null or whitespace, return "Invalid animal species."
            //	If the animal’s diet is different from "herbivore" or "carnivore", return "Invalid animal diet."
            //	If the zoo is full(there is no room for more animals), return "The zoo is full."
            //	Otherwise, return: "Successfully added {animal species} to the zoo."
            if (Animals.Count < Capacity)
            {
                if (string.IsNullOrWhiteSpace(animal.Species))
                {
                    return "Invalid animal species.";
                }
                else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
                {
                    return "Invalid animal diet.";
                }
                else
                {
                    Animals.Add(animal);
                    return $"Successfully added {animal.Species} to the zoo.";
                }
            }
            else
            {
                return "The zoo is full.";
            }
        }

        public int RemoveAnimals(string species)
        {
            int count = Animals.RemoveAll(x => x.Species == species);

            return count;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            return Animals.FindAll(x => x.Diet == diet).ToList();
        }

        public Animal GetAnimalByWeight(double weight) //– return the first animal, with the given weight.
        {
            return Animals.First(x => x.Weight == weight);
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            //search of all animals which has a length between the given (inclusively). As a result return the following format: "There are {count} animals with a length between {minimum length} and {maximum length} meters."
            int count = Animals.FindAll(x => x.Length >= minimumLength && x.Length <= maximumLength).Count();

            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
