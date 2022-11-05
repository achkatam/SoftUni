namespace BorderControl.IO
{
using System;

using BorderControl.IO.Interfaces;
using System.Collections.Generic;
using System.Text;
    using BorderControl.Models.Interfaces;
    using BorderControl.Models;

    public class Engine : IEngine
    {
        private List<IIdentifiable> identifiables;

        public Engine()
        {
            this.identifiables = new List<IIdentifiable>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];

                int length = tokens.Length;

                switch (length)
                {
                    case 3:
                        {
                            int age = int.Parse(tokens[1]);
                            string id = tokens[2];

                            IIdentifiable citizen = new Citizen(name, age, id);

                            this.identifiables.Add(citizen);
                        }
                        break;
                    case 2:
                        {
                            string id = tokens[1];

                            IIdentifiable robot = new Robot(name, id);

                            this.identifiables.Add(robot);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            string fakeId = Console.ReadLine();

            foreach (var id in identifiables)
            {
                id.CheckId(fakeId);
            }
        }
    }
}
