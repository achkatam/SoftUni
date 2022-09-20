using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace _08._SoftUni_Party
{
    internal class Program
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

            string guest = Console.ReadLine();

            while (guest != "PARTY")
            {
                if (guest.Length == 8)
                {
                    guests.Add(guest);
                }

                guest = Console.ReadLine();
            }

            while (guest != "END")
            {
                //remove guests from the list
                guests.Remove(guest);

                guest = Console.ReadLine();
            }

            //VIPs start with a digit

            Console.WriteLine(guests.Count);
            Console.WriteLine(String.Join("\n", guests
                .OrderByDescending(x => char.IsDigit(x[0]))));

        }
    }
}
