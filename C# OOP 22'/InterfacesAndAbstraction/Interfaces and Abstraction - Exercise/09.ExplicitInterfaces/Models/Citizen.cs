namespace ExplicitInterfaces.Models
{
    using System;
    using System.Collections.Generic;

    using ExplicitInterfaces.Models.Contracts;

    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name { get; set; }

        public string Country { get; set; }

        public int Age { get; set; }

        public ICollection<IPerson> People { get; set; }

        public ICollection<IResident> Residents { get; set; }


        void IPerson.GetName() => Console.WriteLine($"{this.Name}");

        void IResident.GetName() => Console.WriteLine($"Mr/Ms/Mrs {this.Name}");
    }
}
