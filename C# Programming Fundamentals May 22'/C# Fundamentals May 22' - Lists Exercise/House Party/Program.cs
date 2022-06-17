using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //First count  of commands
            int cmdCnt = int.Parse(Console.ReadLine());

            //Create list
            var guestList = new List<string>();

            for (int i = 0; i < cmdCnt; i++)
            {
                var command = Console.ReadLine().Split();
                string currName = command[0];

                if (guestList.Contains(currName) && command[2] == "going!")
                {
                    Console.WriteLine($"{currName} is already in the list!");
                }
                else if (guestList.Contains(currName) && command[2] == "not")
                {
                    guestList.Remove(currName);
                }
                else if (!guestList.Contains(currName) && command[2] == "not")
                {
                    Console.WriteLine($"{currName} is not in the list!");
                }
                else
                {
                    guestList.Add(currName);
                }
            }
            //Output
            foreach (var currName in guestList)
            {
                Console.WriteLine(currName);
            }
        }
    }
}
