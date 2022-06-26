using System;
using System.Collections.Generic;
using System.Linq;

namespace Counter___Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps track of every won battle against an enemy.You will receive initial energy.Afterward, you will start receiving the distance you need to reach an enemy until the "End of battle" command is given, or you run out of energy.
            //The energy you need for reaching an enemy is equal to the distance you receive.Each time you reach an enemy, you win a battle, and your energy is reduced.Otherwise, if you don't have enough energy to reach an enemy, end the program and print: "Not enough energy! Game ends with {count} won battles and {energy} energy".
            //Every third won battle increases your energy with the value of your current count of won battles.
            //Upon receiving the "End of battle" command, print the count of won battles in the following format:
            //"Won battles: {count}. Energy left: {energy}"

            // variables for energy, counter for won battles 
            int energy = int.Parse(Console.ReadLine());

            int counter = 0;

            string command = Console.ReadLine();
            //While loop
            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");

                    return;
                }
                energy -= distance;
                counter++;

                //Every third won battle increases your energy with the value of your current count of won battles.
                if (counter % 3 == 0)
                {
                    energy += counter;
                }
                command = Console.ReadLine();
            }
            if (energy >= 0)
            {
                Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");
            }
        }
    }
}
