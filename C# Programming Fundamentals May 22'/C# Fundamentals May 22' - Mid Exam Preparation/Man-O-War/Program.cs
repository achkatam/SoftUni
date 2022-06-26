using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that tracks the battle and either chooses a winner or prints a stalemate. On the first line, you will receive the status of the pirate ship, which is a string representing integer sections separated by ">".On the second line, you will receive the same type of status, but for the warship: 

            //List for the pirateship and warship
            var pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            var warship = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            //Variable for max health recovery
            int maxHealth = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Retire")
            {
                string[] tokens = command.Split();
                string cmd = tokens[0];


                switch (cmd)
                {
                    /*"Fire {index} {damage}"*/
                    case "Fire":
                        Fire(warship, int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    /*Defend {startIndex} {endIndex} {damage}" */
                    case "Defend":
                        Defend(pirateShip, int.Parse(tokens[1]), int.Parse(tokens[2]), int.Parse(tokens[3]));
                        break;
                    /*"Repair {index} {health}" */
                    case "Repair":
                        Repair(pirateShip, int.Parse(tokens[1]), int.Parse(tokens[2]), maxHealth);
                        break;
                    case "Status":
                        Status(pirateShip, maxHealth);
                        break;
                }
                command = Console.ReadLine();
            }
            //If any element == 0 the ship has sunken
            if (pirateShip.Any(x => x <= 0))
            {
                Console.WriteLine($"You lost! The pirate ship has sunken.");
                return;
            }
            if (warship.Any(x => x <= 0))
            {
                Console.WriteLine($"You won! The enemy ship has sunken.");
                return;
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }

        private static void Status(List<int> pirateShip, int maxHealth)
        {
            //•	"Status" - prints the count of all sections of the pirate ship that need repair soon, which are all sections that are lower than 20 % of the maximum health capacity. Print the following:
            //"{count} sections need repair."
            //Counter for elements that need to be fixed
            int count = pirateShip.Where(x => x < 0.2 * maxHealth).Count();

            Console.WriteLine($"{count} sections need repair.");
        }

        private static void Repair(List<int> pirateShip, int index, int health, int maxHealth)
        {
            if (index >= 0 && index <= pirateShip.Count - 1)
            {
                //This way we make sure health is not greater than the maxHealth
                pirateShip[index] = Math.Min(pirateShip[index] + health, maxHealth);
            }
        }

        private static void Defend(List<int> pirateShip, int startIndex, int endIndex, int damage)
        {
            /*•	"Defend {startIndex} {endIndex} {damage}" - the warship attacks the pirate ship with the given damage at that range (indexes are inclusive). Check if both indexes are valid and if not, skip the command. If the section breaks (health <= 0) the pirate ship sinks, print the following and stop the program:
                "You lost! The pirate ship has sunken."*/

            if (startIndex >= 0 && startIndex <= pirateShip.Count - 1
                && endIndex >= 0 && endIndex <= pirateShip.Count - 1)
            {
                //For loop to iterate thru the pirateship elements
                for (int i = startIndex; i <= endIndex; i++)
                {
                    pirateShip[i] -= damage;
                }
            }

        }

        private static void Fire(List<int> warship, int index, int damage)
        {
            /*•	"Fire {index} {damage}" - the pirate ship attacks the warship with the given damage at that section. Check if the index is valid and if not, skip the command. If the section breaks (health <= 0) the warship sinks, print the following and stop the program: "You won! The enemy ship has sunken."*/
            if (index >= 0 && index <= warship.Count - 1)
            {
                warship[index] -= damage;
            }
        }
    }
}
