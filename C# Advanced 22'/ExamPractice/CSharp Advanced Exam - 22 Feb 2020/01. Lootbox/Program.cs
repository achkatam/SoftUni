using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    public class Program
    {
        static void Main(string[] args)
        {

            Queue<int> firstBox = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());


            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray());

            var collectedItems = new Stack<int>();

            while (firstBox.Any() && secondBox.Any())
            {
                int sum = firstBox.Peek() + secondBox.Peek();

                if (sum % 2 == 0)
                {
                    collectedItems.Push(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    var myList = firstBox.ToList();
                    myList.Insert(myList.Count - 1, secondBox.Pop());

                    firstBox = new Queue<int>(myList);
                }

                if (!firstBox.Any())
                {
                    Console.WriteLine($"First lootbox is empty");

                    break;
                }

                if (!secondBox.Any())
                {
                    Console.WriteLine($"Second lootbox is empty");

                    break;
                }

            }

            if (collectedItems.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collectedItems.Sum()}");

                return;
            }

            Console.WriteLine($"Your loot was poor... Value: {collectedItems.Sum()}");
        }
    }
}
