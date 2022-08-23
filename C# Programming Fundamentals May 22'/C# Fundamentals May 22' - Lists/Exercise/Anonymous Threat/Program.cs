using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string cmd = commands[0];
                if (cmd == "3:1") break;

                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                string concatedWord = "";

                if (endIndex > myList.Count - 1 || endIndex < 0)
                {
                    endIndex = myList.Count - 1;
                }

                if (startIndex > myList.Count - 1 || startIndex < 0)
                {
                    startIndex = 0;
                }

                if (cmd == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concatedWord += myList[i];
                    }
                    myList.RemoveRange(startIndex, endIndex - startIndex + 1);

                    myList.Insert(startIndex, concatedWord);
                }
                else if (cmd == "divide")
                {
                    var dividedList = new List<string>();
                    int partitions = int.Parse(commands[2]);
                    string word = myList[startIndex];
                    myList.RemoveAt(startIndex);
                    int parts = word.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            dividedList.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            dividedList.Add(word.Substring(i * parts, parts));
                        }
                    }

                    myList.InsertRange(startIndex, dividedList);
                }

            }
            Console.WriteLine(string.Join(' ', myList));
        }
    }
}
