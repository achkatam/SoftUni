using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that processes information about a race. On the first line, you will be given a list of participants separated by ", ". On the next few lines until you receive a line "end of the race" you will be given some info which will be some alphanumeric characters. In between them, you could have some extra characters which you should ignore. For example: "G!32e%o7r#32g$235@!2e". The letters are the name of the person and the sum of the digits is the distance he ran. So here we have George who ran 29 km. Store the information about the person only if the list of racers contains the name of the person. If you receive the same person more than once just add the distance to his old distance. At the end print the top 3 racers in the format:

            //Create pattern for participants' names
            string namePattern = @"[A-Za-z]";
            string distancePattern = @"[\d]";

            //list of participants separated by ", "
            string[] participants = Console.ReadLine().Split(", "
                , StringSplitOptions.RemoveEmptyEntries);

            var racers = new Dictionary<string, int>();

            //add the participants in the dictionary
            foreach (var racer in participants)
            {
                racers[racer] = 0;
            }

            //command and while loop till' "end of race"
            string command = Console.ReadLine();

            while (command != "end of race")
            {
                MatchCollection letters = Regex.Matches(command, namePattern);
                MatchCollection digits = Regex.Matches(command, distancePattern);

                string name = string.Empty;
                foreach (var letter in letters)
                {
                    name += letter;
                }

                if (racers.ContainsKey(name))
                {
                    int distance = digits.Select(x => int.Parse(x.Value)).Sum();
                    racers[name] += distance;
                }

                command = Console.ReadLine();
            }

            var winners = racers.OrderByDescending(x => x.Value).Take(3)
                .ToDictionary(x=>x.Key, x=> x.Value);

            //counter for winners
            int counter = 1;
            foreach (var winner in winners)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {winner.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {winner.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {winner.Key}");
                }

                counter++;
            }
        }
    }
}
