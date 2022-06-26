using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a string with even integers, separated by a "@" - this is our neighborhood. After that, a series of Jump commands will follow until you receive "Love!".Every house in the neighborhood needs a certain number of hearts delivered by Cupid so it can celebrate Valentine's day. The integers in the neighborhood indicate those needed hearts.
            //and must jump by a given length.The jump commands will be in this format: "Jump {length}".
            //Every time he jumps from one house to another, the needed hearts for the visited house are decreased by 2: 
            //•	If the needed hearts for a certain house become equal to 0, print on the console "Place {house_index} has Valentine's day." 
            //•	If Cupid jumps to a house where the needed hearts are already 0, print on the console "Place {house_index} already had Valentine's day."
            //•	Keep in mind that Cupid can have a larger jump length than the size of the neighborhood, and if he does jump outside of it, he should start from the first house again(index 0)

            var numbers = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            //Cupid starts at the position of the first house(index 0)
            int position = 0;

            string command = Console.ReadLine();
            while (command != "Love!")
            {
                string[] tokens = command.Split();
                int jump = int.Parse(tokens[1]);

                /*•	Keep in mind that Cupid can have a larger jump length than the size of the neighborhood, and if he does jump outside of it, he should start from the first house again (index 0)*/
                if (jump + position > numbers.Count - 1)
                {
                    position = 0;

                    CheckPosition(numbers, position);
                }
                else
                {
                    position += jump;
                    CheckPosition(numbers, position);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {position}.");

            //Ternary operator
            Console.WriteLine(numbers.Any(x=>x>0)? $"Cupid has failed {numbers.Where(x => x > 0).Count()} places.":
                 $"Mission was successful.");

        }


        private static void CheckPosition(List<int> numbers, int currPosition)
        {
            /*•	If Cupid jumps to a house where the needed hearts are already 0, print on the console "Place {house_index} already had Valentine's day."*/
            if (numbers[currPosition] == 0)
            {
                Console.WriteLine($"Place {currPosition} already had Valentine's day.");
            }
            else
            {
                /*•	If the needed hearts for a certain house become equal to 0, print on the console "Place {house_index} has Valentine's day." */
                numbers[currPosition] -= 2;
                if (numbers[currPosition] == 0)
                {
                    Console.WriteLine($"Place {currPosition} has Valentine's day.");
                }
            }
        }
    }
}
