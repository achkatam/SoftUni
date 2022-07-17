using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will be given a string containing all of your stops. Until you receive the command "Travel", you will be given some commands to manipulate that initial string. The commands can be:



            //Note: After each command, print the current state of the string
            //After the "Travel" command, print the following: "Ready for world tour! Planned stops: {string}"

            //•	An index is valid if it is between the first and the last element index (inclusive) in the sequence.
            string destination = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] token = command.Split(':'
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = token[0];

                switch (cmd)
                {
                    case "Add Stop":
                        //"Add Stop:{index}:{string}":
                        //o Insert the given string at that index only if the index is valid
                        if (IsValidIndex(int.Parse(token[1]), destination))
                        {
                            destination = destination.Insert(int.Parse(token[1]), token[2]);
                        }
                        break;
                    case "Remove Stop":
                        //"Remove Stop:{start_index}:{end_index}":
                        //Remove the elements of the string from the starting index to the end index(inclusive) if both indices are valid
                        if (IsValidIndex(int.Parse(token[1]), destination) && IsValidIndex(int.Parse(token[2]), destination))
                        {
                            destination = destination.Remove(int.Parse(token[1]), int.Parse(token[2]) - int.Parse(token[1]) + 1);
                        }
                        break;
                    case "Switch":
                        //•	"Switch:{old_string}:{new_string}":
                        //o If the old string is in the initial string, replace it with the new one(all occurrences)
                        if (destination.Contains(token[1]))
                        {
                            destination = destination.Replace(token[1], token[2]);
                        }
                        break;

                }
                Console.WriteLine(destination);

                command = Console.ReadLine();
            }
            //"Ready for world tour! Planned stops: {string}"
            Console.WriteLine($"Ready for world tour! Planned stops: {destination}");
        }
        static bool IsValidIndex(int index, string destination) => index >= 0 && index < destination.Length;

    }
}
