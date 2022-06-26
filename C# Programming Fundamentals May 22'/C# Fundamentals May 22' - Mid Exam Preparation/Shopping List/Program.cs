using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive an initial list with groceries separated by an exclamation mark "!".
            var shoppingList = Console.ReadLine().Split('!').ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] tokens = command.Split();
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Urgent":
                        if (!shoppingList.Contains(tokens[1]))
                        {
                            shoppingList.Insert(0, tokens[1]);
                        }
                        break;
                    case "Unnecessary":
                        shoppingList.Remove(tokens[1]);
                        break;
                    case "Correct":
                        if (shoppingList.Contains(tokens[1]))
                        {
                            int index = shoppingList.IndexOf(tokens[1]);
                            shoppingList.RemoveAt(index);
                            shoppingList.Insert(index, tokens[2]);
                        }
                        break;
                    case "Rearrange":
                        if (shoppingList.Contains(tokens[1]))
                        {
                            shoppingList.Remove(tokens[1]);
                            shoppingList.Add(tokens[1]);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }

    }
}
