using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            //The war is at its peak, but you, young Padawan, can turn the tides with your programming skills. You are tasked to create a program to decrypt the messages of The Order and prevent the death of hundreds of lives. 
            //You will receive several messages, which are encrypted using the legendary star enigma. You should decrypt the messages, following these rules:
            //To properly decrypt a message, you should count all the letters[s, t, a, r] – case insensitive and remove the count from the current ASCII value of each symbol of the encrypted message.
            //After decryption:
            //Each message should have a planet name, population, attack type('A', as an attack or 'D', as destruction), and soldier count.
            //The planet name starts after '@' and contains only letters from the Latin alphabet.
            //The planet population starts after ':' and is an Integer;
            //The attack type may be "A"(attack) or "D"(destruction) and must be surrounded by "!"(exclamation mark).
            //The soldier count starts after "->" and should be an Integer.
            //The order in the message should be: planet name -> planet population -> attack type -> soldier count. Each part can be separated from the others by any character except: '@', '-', '!', ':' and '>'.
            string pattern = @"[^@\-!:>]*@(?<planetName>[A-Z][a-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(?<soldierCount>[\d]+)";

            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            int numOfPlanets = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPlanets; i++)
            {
                string message = Console.ReadLine();

                //count of ohw many times the message contains s, t, a, r
                int sum = message.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');

                string decryptedMessage = "";
                foreach (var charr in message)
                {
                    decryptedMessage += (char)(charr - sum);
                }

                Match matches = Regex.Match(decryptedMessage, pattern, RegexOptions.IgnoreCase);

                if (matches.Success)
                {
                    string planetName = matches.Groups["planetName"].Value;
                    string type = matches.Groups["type"].Value;

                    if (type == "A") attackedPlanets.Add(planetName);
                    else destroyedPlanets.Add(planetName);

                }

            }
            //First print the attacked planets, then the destroyed planets.
            //  "Attacked planets: {attackedPlanetsCount}"
            //"-> {planetName}"
            //"Destroyed planets: {destroyedPlanetsCount}"
            //"-> {planetName}"
            //The planets should be ordered by name alphabetically.

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count()}");
            attackedPlanets.OrderBy(x => x).ToList().ForEach(planetName
                => Console.WriteLine($"-> {planetName}"));
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count()}");
            destroyedPlanets.OrderBy(x => x).ToList().ForEach(planetName
                => Console.WriteLine($"-> {planetName}"));



        }
    }
}