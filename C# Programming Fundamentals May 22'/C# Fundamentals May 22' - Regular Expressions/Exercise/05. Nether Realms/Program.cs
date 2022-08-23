using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string lettersPattern = @"[^0-9+\-*\/\.]";
            string digitPattern = @"[+|-]?\d+\.?\d*";
            string operations = @"[*/]";
            string splitPattern = @"[\s]*[,]{1}[\s]*";


            string input = Console.ReadLine();
            var demons = Regex.Split(input, splitPattern).ToArray();

            List<Demon> demonsList = new List<Demon>();

            foreach (string demon in demons)
            {
                int health = GetHealth(demon, lettersPattern);
                double damage = GetDamage(demon, digitPattern, operations);

                demonsList.Add(new Demon(demon, health, damage));
            }

            foreach (Demon demon in demonsList.OrderBy(x => x.Name))
            {
                Console.WriteLine(demon);
            }
        }

        public static double GetDamage(string demon, string digitPattern, string operations)
        {
            var digitMatches = Regex.Matches(demon, digitPattern).ToArray();
            double damage = 0;

            foreach (var number in digitMatches)
            {
                damage += double.Parse(number.Value);
            }

            var operationMatched = Regex.Matches(demon, operations).ToArray();

            foreach (var operation in operationMatched)
            {
                if (operation.Value == "*")
                {
                    damage *= 2;
                }
                else if (operation.Value == "/")
                {
                    damage /= 2;
                }
            }

            return damage;
        }

        public static int GetHealth(string demon, string lettersPattern)
        {
            var lettersMatched = Regex.Matches(demon, lettersPattern).ToArray();
            int health = 0;

            foreach (var letter in lettersMatched)
            {
                health += char.Parse(letter.Value);
            }

            return health;
        }
    }
    class Demon
    {
        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
        public override string ToString() => $"{Name} - {Health} health, {Damage:f2} damage";
        
    }
}