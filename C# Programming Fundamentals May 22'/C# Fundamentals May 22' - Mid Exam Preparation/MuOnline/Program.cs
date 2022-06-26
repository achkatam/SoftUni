using System;
using System.Collections.Generic;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have initial health 100 and initial bitcoins 0.You will be given a string representing the dungeon's rooms. Each room is separated with ' | ' (vertical bar): "room1|room2|room3…"
            //Each room contains a command and a number, separated by space. The command can be:

            var room = Console.ReadLine().Split('|').ToList();
            //Variables for hp and BTC
            int health = 100;
            int bitcoin = 0;

            //For loop to iterate thru all the rooms 
            for (int i = 0; i < room.Count; i++)
            {
                string[] command = room[i].Split();

                string cmd = command[0];
                switch (cmd)
                {
                    case "potion":
                        //You are healed with the number in the second part.But your health cannot exceed your initial health(100).
                        //o First print: "You healed for {amount} hp."
                        //o After that, print your current health: "Current health: {health} hp."
                        int currentHealth = health;
                        int tempHealth = health;
                        currentHealth += int.Parse(command[1]);
                        if (currentHealth > 100)
                        {
                            int difference = 100 - tempHealth;
                            health = 100;
                            Console.WriteLine($"You healed for {difference} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            health += int.Parse(command[1]);
                            Console.WriteLine($"You healed for {command[1]} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        break;

                    case "chest":
                        bitcoin += int.Parse(command[1]);
                        Console.WriteLine($"You found {int.Parse(command[1])} bitcoins.");
                        break;
                    /*o	If you are not dead (health <= 0), you've slain the monster, and you should print: "You slayed {monster}."
o	If you've died, print "You died! Killed by {monster}." and your quest is over. Print the best room you've manage to reach: "Best room: {room}"*/

                    default:
                        health -= int.Parse(command[1]);
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {command[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {command[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        break;
                }
            }
            /*"You've made it!"
         "Bitcoins: {bitcoins}"
         "Health: {health}"*/

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {health}");

        }

    }
}
