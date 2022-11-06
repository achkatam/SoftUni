namespace ExplicitInterfaces.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using ExplicitInterfaces.Core.Contracts;
    using ExplicitInterfaces.IO.Contracts;
    using ExplicitInterfaces.Models;
    using ExplicitInterfaces.Models.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly List<IPerson> people;
        private readonly List<IResident> residents;

        public Engine()
        {
            this.people = new List<IPerson>();
            this.residents = new List<IResident>();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command = this.reader.ReadLine();

            while (command != "End")
            {
                var tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string country = tokens[1];
                int age = int.Parse(tokens[2]);

                IPerson person = new Citizen(name, country, age);

                //people.Add(person);
                person.GetName();

                IResident resident = new Citizen(name, country, age);
                resident.GetName();
                //residents.Add(resident);

                command = this.reader.ReadLine();
            }
        }
    }
}
