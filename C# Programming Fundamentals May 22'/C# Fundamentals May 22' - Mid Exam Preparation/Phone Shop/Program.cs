using System;
using System.Collections.Generic;
using System.Linq;

namespace Phone_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of phones
            var phones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            //variable for command
            string command = Console.ReadLine();

            //while until "End"
            while (command!= "End")
            {
                string[] tokens = command.Split();
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Add":
                        Add(phones, tokens[2]);
                        break;
                    case "Remove":
                        Remove(phones, tokens[2]);
                        break;
                    case "Bonus":
                        string[] commands = tokens[3].Split(":");
                        string oldPhone = commands[0];
                        string newPhone = commands[1];
                        Bonus(phones, oldPhone, newPhone);
                        break;
                    case "Last":
                        Last(phones, tokens[2]);
                        break;
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", phones));

        }

        private static void Last(List<string> phones, string phoneToSwitch)
        {
            if (phones.Contains(phoneToSwitch))
            {
                phones.Remove(phoneToSwitch);
                phones.Add(phoneToSwitch);
            }

            return;
        }

        private static void Bonus(List<string> phones, string oldPhone, string newPhone)
        {
            if (phones.Contains(oldPhone))
            {
                int index = phones.IndexOf(oldPhone);
                phones.Insert(index + 1, newPhone);
            }

            return;
        }

        private static void Remove(List<string> phones, string phoneToRemove)
        {
            if (phones.Contains(phoneToRemove)) phones.Remove(phoneToRemove);

            return;
        }

        private static void Add(List<string> phones, string phoneToAdd)
        {
            if (!phones.Contains(phoneToAdd)) phones.Add(phoneToAdd);

            return;
        }
    }
}
