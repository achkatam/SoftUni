using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Zoo
{
    public class Animal
    {
        public Animal(string species, string diet, double weight, double length)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Length = length;
        }

        public string Species { get; }
        public string Diet { get; }
        public double Weight { get; }
        public double Length { get; }

        public override string ToString() => $"The {Species} is a {Diet} and weighs {Weight} kg.";
    }
}
