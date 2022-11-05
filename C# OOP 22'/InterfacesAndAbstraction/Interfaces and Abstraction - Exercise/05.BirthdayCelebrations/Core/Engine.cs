namespace BorderControl.IO
{
    using System;

    using BorderControl.IO.Interfaces;
    using System.Collections.Generic;

    using BorderControl.Models.Interfaces;
    using BirthdayCelebrations.Models.Interfaces;
    using BorderControl.Models;
    using BirthdayCelebrations.Models;
    using System.Linq;
    using BirthdayCelebrations.IO.Interfaces;

    public class Engine : IEngine
    {
        private List<IBirthable> birthables;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine()
        {
            this.birthables = new List<IBirthable>();
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
                string cmd = tokens[0];
                string name = tokens[1];

                switch (cmd)
                {
                    case "Citizen":
                        {
                            int age = int.Parse(tokens[2]);
                            string id = tokens[3];
                            string birthdate = tokens[4];

                            IBirthable citizen = new Citizen(name, age, id, birthdate);

                            birthables.Add(citizen);
                        }
                        break;
                    case "Pet":
                        {
                            string birthdate = tokens[2];

                            IBirthable pet = new Pet(name, birthdate);

                            birthables.Add(pet);
                        }
                        break;
                    case "Robot":
                        {
                            string id = tokens[2];

                            IIdentifiable robot = new Robot(name, id);
                        }
                        break;
                }

                  command = this.reader.ReadLine();

            }

            string birthDate = this.reader.ReadLine();

            var myList = birthables.Where(x => x.Birthdate.EndsWith(birthDate)).ToList();

            if (myList.Any())
                this.writer.WriteLine(String.Join(Environment.NewLine, myList.Select(x => x.Birthdate)));
            
        }
    }
}
