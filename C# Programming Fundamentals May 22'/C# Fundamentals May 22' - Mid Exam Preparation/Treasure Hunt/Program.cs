using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a program that manages the state of the treasure chest along the way. On the first line, you will receive the initial loot of the treasure chest, which is a string of items separated by a "|".*/
            //Create the list
            var treasure = Console.ReadLine().Split('|').ToList();
            //variable for command
            string command = Console.ReadLine();
            //while loop until "Yohoho!
            while (command != "Yohoho!")
            {
                //string array of command[0]
                string[] tokens = command.Split();
                string cmd = tokens[0];
                //Switch case to check all the different commands
                switch (cmd)
                {
                    //"Loot {item1} {item2}…{itemn}":
                    //o Pick up treasure loot along the way. Insert the items at the beginning of the chest.
                    //o If an item is already contained, don't insert it.
                    case "Loot":
                        //For loop to iterate thru the end of the list
                        //start from 1 because 0 is the command "Loot"
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            if (!treasure.Contains(tokens[i]))
                            {
                                treasure.Insert(0, tokens[i]);
                            }
                        }
                        break;
                    //"Drop {index}":
                    //o Remove the loot at the given position and add it at the end of the treasure chest. 
                    //o If the index is invalid, skip the command.
                    case "Drop":
                        int index = int.Parse(tokens[1]);
                        //Use if statement to make sure index is in bounds(valid)
                        if (index > 0 && index < treasure.Count - 1)
                        {
                            string item = treasure[index];
                            treasure.RemoveAt(index);
                            treasure.Add(item);
                        }
                        break;
                    //Steal { count}:
                    //o Someone steals the last count loot items. If there are fewer items than the given count, remove as much as there are.
                    //o Print the stolen items separated by ", ":
                    //"{item1}, {item2}, {item3} … {itemn}"
                    case "Steal":
                        //Integer for count of stolen items
                        int count = int.Parse(tokens[1]);
                        //One new list for stolenItems
                        var stolenItem = new List<string>();
                        //For loop to the count
                        for (int i = 0; i < count; i++)
                        {
                            if (treasure.Count > 0)
                            {
                                stolenItem.Add(treasure[treasure.Count - 1]);
                                treasure.RemoveAt(treasure.Count - 1);
                            }
                        }
                        stolenItem.Reverse();
                        Console.WriteLine(string.Join(", ", stolenItem));
                        break;


                }
                command = Console.ReadLine();
            }
            //In the end, output the average treasure gain, which is the sum of all treasure items length divided by the count of all items inside the chest formatted to the second decimal point:
            //"Average treasure gain: {averageGain} pirate credits."
            //If the chest is empty, print the following message:
            //"Failed treasure hunt."
            if (treasure.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double average = treasure.Sum(x => x.Length / (double)treasure.Count);
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }

        }
    }
}
