namespace MilitaryElite.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MilitaryElite.Core.Contracts;
    using MilitaryElite.IO.Contracts;
    using MilitaryElite.Models;
    using MilitaryElite.Models.Contracts;
    using MilitaryElite.Models.Enums;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly ICollection<ISoldier> soldiers;

        private Engine()
        {
            this.soldiers = new HashSet<ISoldier>();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            this.CreateSoldier();

            this.PrintSoldiers();
        }

        private void PrintSoldiers()
        {
            foreach (ISoldier soldier in this.soldiers)
            {
                this.writer.WriteLine(soldier.ToString());
            }
        }

        private void CreateSoldier()
        {
            string command = this.reader.ReadLine();

            while (command != "End")
            {
                var tokens = command
                    .Split(" ");

                string type = tokens[0];
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];

                ISoldier soldier;

                switch (type)
                {
                    case "Private":
                        {
                            decimal salary = decimal.Parse(tokens[4]);

                            soldier = new Private(id, firstName, lastName, salary);
                        }
                        break;

                    case "LieutenantGeneral":
                        {
                            decimal salary = decimal.Parse(tokens[4]);

                            ICollection<IPrivate> privates = FindPrivates(tokens);

                            soldier = new LieutenantGeneral(id, firstName, lastName, salary, privates);
                        }
                        break;

                    case "Engineer":
                        {
                            decimal salary = decimal.Parse(tokens[4]);
                            string corpsText = tokens[5];

                            bool isCorpsValid = Enum.TryParse(corpsText, false, out Corps corps);
                            if (!isCorpsValid)
                            {
                                command = this.reader.ReadLine();

                                continue;
                            }
                            ICollection<IRepair> repairs = this.CreateRepairs(tokens);

                            soldier = new Engineer(id, firstName, lastName, salary, corps, repairs);
                        }
                        break;

                    case "Commando":
                        {
                            decimal salary = decimal.Parse(tokens[4]);
                            string corpsText = tokens[5];

                            bool isCorpsValid = Enum.TryParse(corpsText, false, out Corps corps);
                            if (!isCorpsValid)
                            {
                                command = this.reader.ReadLine();

                                continue;
                            }
                            ICollection<IMission> missions = this.CreateMissions(tokens);

                            soldier = new Commando(id, firstName, lastName, salary, corps, missions);
                        }
                        break;

                    case "Spy":
                        {
                            int codeNumber = int.Parse(tokens[4]);

                            soldier = new Spy(id, firstName, lastName, codeNumber);
                        }
                        break;

                    default:
                        command = this.reader.ReadLine();

                        continue;
                        break;
                }

                

                this.soldiers.Add(soldier);

                command = this.reader.ReadLine();
            }
        }

        private ICollection<IPrivate> FindPrivates(string[] tokens)
        {
            int[] privatesId = tokens.Skip(5)
                .Select(int.Parse).ToArray();

            ICollection<IPrivate> privates = new HashSet<IPrivate>();

            foreach (int privateId in privatesId)
            {
                IPrivate currPrivate = (IPrivate)this.soldiers
                    .FirstOrDefault(s => s.Id == privateId);

                privates.Add(currPrivate);
            }

            return privates;
        }

        private ICollection<IRepair> CreateRepairs(string[] tokens)
        {
            ICollection<IRepair> repairs = new HashSet<IRepair>();

            string[] repairsInfo = tokens.Skip(6)
                .ToArray();

            for (int i = 0; i < repairsInfo.Length; i += 2)
            {
                string partName = repairsInfo[i];
                int hoursWorked = int.Parse(repairsInfo[i + 1]);

                IRepair repair = new Repair(partName, hoursWorked);

                repairs.Add(repair);
            }

            return repairs;
        }

        private ICollection<IMission> CreateMissions(string[] tokens)
        {
            ICollection<IMission> missions = new HashSet<IMission>();

            string[] missionsInfo = tokens.Skip(6)
                .ToArray();

            for (int i = 0; i < missionsInfo.Length; i +=2)
            {
                string codeName = missionsInfo[i];

                string stateText = missionsInfo[i + 1];

                bool isStateValid = Enum.TryParse(stateText, false, out State state);
                if (!isStateValid)
                {
                    continue;
                }

                IMission mission = new Mission(codeName, state);

                missions.Add(mission);
            }

            return missions;
        }

       
    }
}
