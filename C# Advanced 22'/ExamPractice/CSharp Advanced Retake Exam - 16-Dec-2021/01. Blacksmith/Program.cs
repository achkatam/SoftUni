using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    public class Program
    {
        static void Main(string[] args)
        {
            var steelInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var steel = new Queue<int>(steelInfo);

            var carbonInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var carbon = new Stack<int>(carbonInfo);

            var swords = new Dictionary<string, int>
            {
                {"Gladius", 0 },
                {"Shamshir", 0 },
                {"Katana", 0 },
                {"Sabre", 0 },
                {"Broadsword", 0 },
            };

                int forgedSwords = 0;

            while (steel.Any() && carbon.Any())
            {
                int mixSum = steel.Peek() + carbon.Peek();


                switch (mixSum)
                {
                    case 70:
                        steel.Dequeue();
                        carbon.Pop();
                        swords["Gladius"]++;
                        forgedSwords++;
                        break;
                    case 80:
                        steel.Dequeue();
                        carbon.Pop();
                        forgedSwords++;
                        swords["Shamshir"]++;
                        break;
                    case 90:
                        steel.Dequeue();
                        carbon.Pop();
                        forgedSwords++;
                        swords["Katana"]++;
                        break;
                    case 110:
                        steel.Dequeue();
                        carbon.Pop();
                        forgedSwords++;
                        swords["Sabre"]++;
                        break;
                    case 150:
                        steel.Dequeue();
                        forgedSwords++;
                        carbon.Pop();
                        swords["Broadsword"]++;
                        break;
                    default:
                        steel.Dequeue();
                        int toAdd = carbon.Pop() + 5;
                        carbon.Push(toAdd);
                        break;
                }
                //Gladius	70
                //Shamshir    80
                //Katana  90
                //Sabre   110
                //Broadsword  150


            }
            PrintOutput(carbon, steel, swords , forgedSwords);
        }

        public static void PrintOutput(Stack<int> carbon, Queue<int> steel, Dictionary<string, int> swords, int forgedSwords)
        {
            //o	If at least one sword was forged: "You have forged {totalNumberOfSwords} swords."
            //o If no sword was forged: "You did not have enough resources to forge a sword."
            Console.WriteLine(forgedSwords > 0? $"You have forged {forgedSwords} swords." : $"You did not have enough resources to forge a sword.");

            //o	If there are no steel: "Steel left: none"
            //o If there are steel: "Steel left: {steel1}, {steel2}, {steel3}, (…)"
            Console.WriteLine(steel.Any() ? $"Steel left: {string.Join(", ", steel)}" : "Steel left: none");

            Console.WriteLine(carbon.Any() ? $"Carbon left: {string.Join(", ", carbon)}" : "Carbon left: none");

            //only the swords that you manage to forge and how many of them, ordered alphabetically:
            foreach (var sword in swords.Where(x => x.Value > 0).OrderBy(x => x.Key))
            {
                Console.WriteLine($"{sword.Key}: {sword.Value}");
            }

        }
    }
}
