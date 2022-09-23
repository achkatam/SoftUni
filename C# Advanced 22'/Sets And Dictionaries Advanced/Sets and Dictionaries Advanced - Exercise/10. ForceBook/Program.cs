using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //The force users are struggling to remember which side is the different forceUsers from, because they switch them too often. So you are tasked to create a web application to manage their profiles. You should store an information for every unique forceUser, registered in the application.
            //You will receive several input lines in one of the following formats:
            //{ forceSide} | { forceUser}
            //{ forceUser} -> { forceSide}
            //The forceUser and forceSide are strings, containing any character. 
            //If you receive forceSide | forceUser, you should check if such forceUser already exists, and if not, add him/ her to the corresponding side. 
            //If you receive a forceUser->forceSide, you should check if there is such a forceUser already and if so, change his/ her side.If there is no such forceUser, add him/ her to the corresponding forceSide, treating the command as a newly registered forceUser.
            //Then you should print on the console: "{forceUser} joins the {forceSide} side!".
            //Lumpawaroo
            //darkside    username, 
            var darkSide = new Dictionary<string, HashSet<string>>();

            string command = Console.ReadLine();

            while (command != "Lumpawaroo")
            {
                //separator

                
                if (command.Contains('|'))
                {
                    var tokens = command
                    .Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    var forceSide = tokens[0];
                    var user = tokens[1];

                    //check first if there's user with that name
                    if (!darkSide.Values.Any(x => x.Contains(user)))
                    {
                        AddUser(darkSide, forceSide, user);
                    }

                }
                else
                {
                    var tokens = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    var user = tokens[0];
                    var forceSide = tokens[1];

                    //Remove it from that side and move it in the another one
                    foreach (var side in darkSide)
                    {
                        if (side.Value.Contains(user))
                        {
                            side.Value.Remove(user);
                            break;
                        }
                    }

                   AddUser(darkSide, forceSide, user);

                    Console.WriteLine($"{user} joins the {forceSide} side!");
                }


                command = Console.ReadLine();
            }

            //•	As output for each forceSide, ordered descending by forceUsers count, then by name,  you must print all the forceUsers, ordered by name alphabetically.
            //•	The output format is:
            //"Side: {forceSide}, Members: {forceUsers.Count}"
            //"! {forceUser}"

            foreach (var side in darkSide.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    foreach (var user in side.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }


        }

        static void AddUser(Dictionary<string, HashSet<string>> darkSide, string forceSide, string user)
        {
            if (!darkSide.ContainsKey(forceSide))
            {
                darkSide.Add(forceSide, new HashSet<string>());
            }

            darkSide[forceSide].Add(user);
        }
    }
}
