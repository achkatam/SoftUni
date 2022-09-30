using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You need to implement a filtering module to a party reservation software. First, the Party Reservation Filter Module (PRFM for short) has been passed a list with invitations. Next, the PRFM receives a sequence of commands that specify whether you need to add or remove a given filter.
            //Each PRFM command is in the given format:
            //"{command;filter type;filter parameter}"
            //You can receive the following PRFM commands:
            //•	"Add filter"
            //•	"Remove filter"
            //•	"Print"
            //The possible PRFM filter types are: 
            //•	"Starts with"
            //•	"Ends with"
            //•	"Length"
            //•	"Contains"

            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            var filters = new Dictionary<string, Predicate<string>>();

            string command = Console.ReadLine();

            while (command != "Print")
            {
                var tokens = command.Split(";");

                var cmd = tokens[0];
                var filter = tokens[1];
                var value = tokens[2];

                if (cmd == "Add filter")
                {
                    filters.Add(filter + value, GetPredicate(filter, value));
                }
                else
                {
                    filters.Remove(filter + value);
                }

                command = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                //the value is the predicate
                guests.RemoveAll(filter.Value);
            }

            Console.WriteLine(String.Join(" ", guests));
        }

        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return s => s.StartsWith(value);
                case "Ends with":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                case "Contains":
                    return s => s.Contains(value);
                default:
                    return default(Predicate<string>);
            }
        }
    }
}
