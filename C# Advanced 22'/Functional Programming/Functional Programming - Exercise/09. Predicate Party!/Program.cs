using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you receive a list of all the people that are coming. On the next lines, until you get the "Party!" command, you may be asked to double or remove all the people that apply to the given criteria. There are three different criteria: 
            //•	Everyone that has his name starting with a given string
            //•	Everyone that has a name ending with a given string
            //•	Everyone that has a name with a given length
            //Finally, print all the guests who are going to the party separated by ", " and then add the ending "are going to the party!".If no guests are going to the party print "Nobody is going to the party!".

            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                var tokens = command.Split();

                var cmd = tokens[0];

                if (cmd == "Remove")
                {
                    guests.RemoveAll(GetFunc(tokens));
                }
                else if (cmd == "Double")
                {
                    guests = DoubleGuestList(tokens, guests);
                }

                command = Console.ReadLine();
            }

            Action<List<string>> printer = name => Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");

            if (guests.Any())
            {
                printer(guests);

                return;
            }

            Console.WriteLine("Nobody is going to the party!");
        }

        static List<string> DoubleGuestList(string[] tokens, List<string> guests)
        {
            var cmd = tokens[0];
            var filter = tokens[1];
            var value = tokens[2];

            Predicate<string> predicate = GetFunc(tokens);

            //create new list and add the people in there
            List<string> newList = new List<string>();

            foreach (var guest in guests)
            {
                if (predicate(guest)) newList.Add(guest);
                newList.Add(guest);
            }

            return newList;
        }

        static Predicate<string> GetFunc(string[] tokens)
        {
            var cmd = tokens[0];
            var filter = tokens[1];
            var value = tokens[2];

            Predicate<string> predicate = name => true;

            switch (filter)
            {
                case "StartsWith":
                    return name => name.StartsWith(value);
                    break;
                case "EndsWith":
                    return name => name.EndsWith(value);
                    break;
                case "Length":
                    return name => name.Length == int.Parse(value);
                    break;
            }

            return predicate;
        }
    }
}
