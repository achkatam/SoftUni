using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //There is a party in SoftUni. Many guests are invited and there are two types of them: VIP and Regular. When a guest comes, check if he/she exists in any of the two reservation lists.
            //All reservation numbers will be with the length of 8 chars.
            //All VIP numbers start with a digit.
            //First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:
            //•	"PARTY" – After this command, you will begin receiving the reservation numbers of the people, who came to the party.
            //•	"END" – The party is over and you have to stop the program and print the appropriate output.
            //In the end, print the count of the guests who didn't come to the party, and afterward, print their reservation numbers. the VIP guests must be first.

            var guests = new HashSet<string>();

            //invided guests
            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (input.Length == 8)
                {
                    guests.Add(input);
                }

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                guests.Remove(input);

                input = Console.ReadLine();
            }


            //Output
            Console.WriteLine(guests.Count);
            foreach (var guest in guests.OrderBy(x => char.IsLetter(x[0])))
            {
                Console.WriteLine(guest);
            }
        }
    }
}
