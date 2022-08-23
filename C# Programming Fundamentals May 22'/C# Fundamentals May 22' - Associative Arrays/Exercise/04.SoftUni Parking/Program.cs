using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which validates a parking place for an online service. Users can register to park and unregister to leave.
            //The program receives 2 commands:
            //•	"register {username} {licensePlateNumber}":
            //o The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:


            //After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
            //•	"{username} => {licensePlateNumber}"

            //Create dictionary of user and licensePlate (nums and letters) - string, string
            var user = new Dictionary<string, string>();

            //count of users to register or unregister
            int pplCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pplCount; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string cmd = input[0];
                var userName = input[1];

                switch (cmd)
                {
                    case "register":
                        //o	The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
                        //"ERROR: already registered with plate number {licensePlateNumber}"
                        //o If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
                        //"{username} registered {licensePlateNumber} successfully"

                        var licensePlate = input[2];
                        if (IsNotExistingUser(user, userName))
                        {
                            user[userName] = licensePlate;
                            Console.WriteLine($"{userName} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        break;
                    case "unregister":
                        //•	"unregister {username}":
                        //If the user is not present in the database, the system should print:
                        //"ERROR: user {username} not found"
                        //o If the aforementioned check passes successfully, the system should print:
                        //"{username} unregistered successfully"
                        if (IsNotExistingUser(user, userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{userName} unregistered successfully");
                            user.Remove(userName);
                        }
                        break;
                }

            }

            PrintResult(user);

        }

        private static void PrintResult(Dictionary<string, string> user)
        {
            foreach (var person in user)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }
        }

        static bool IsNotExistingUser(Dictionary<string, string> user, string userName) => !user.ContainsKey(userName);

    }
}

