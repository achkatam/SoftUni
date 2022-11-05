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
    using FoodShortage.Models.Interfaces;
    using FoodShortage.Models;
    using Microsoft.VisualBasic;
    using System.Reflection.Metadata.Ecma335;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private List<IBuyer> buyers;

        public Engine()
        {
            this.buyers = new List<IBuyer>();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            int line = int.Parse(this.reader.ReadLine());

            for (int i = 0; i < line; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                int length = input.Length;

                switch (length)
                {
                    case 4:
                        {
                            string id = input[2];
                            string birthdate = input[3];

                            IBuyer citizen = new Citizen(name, age, id, birthdate);

                            buyers.Add(citizen);
                        }
                        break;
                    case 3:
                        {
                            string group = input[2];

                            IBuyer rebel = new Rebel(name, age, group);

                            buyers.Add(rebel);
                        }
                        break;
                }

            }

            string command = this.reader.ReadLine();

            while (command != "End")
            {
                string name = command;

                IBuyer buyer = buyers.FirstOrDefault(x => x.Name == name);

                if (buyer != null)
                    buyer.BuyFood();

                command = this.reader.ReadLine();
            }

            this.writer.WriteLine(buyers.Sum(f => f.Food).ToString());
        }
    }
}
