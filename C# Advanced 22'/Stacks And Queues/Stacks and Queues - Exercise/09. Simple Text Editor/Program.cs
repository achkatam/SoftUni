using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //You are given an empty text. Your task is to implement 4 commands related to manipulating the text
            //•	1 someString - appends someString to the end of the text
            //•	2 count - erases the last count elements from the text
            //•	3 index - returns the element at position index from the text
            //•	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation

            //count of operations
            int n = int.Parse(Console.ReadLine());

            //create StringBuilder
            var text = new StringBuilder();

            //Stack
            var memory = new Stack<string>();
            memory.Push(string.Empty);

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                string cmd = tokens[0];

                if (cmd == "1")
                {
                    string arg = tokens[1];

                    text.Append(arg);
                    memory.Push(text.ToString());
                }
                else if (cmd == "2")
                {
                    //chars to be removed
                    int chars = int.Parse(tokens[1]);

                    text = text.Remove(text.Length - chars, chars);
                    memory.Push(text.ToString());
                }
                else if (cmd == "3")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index <= text.Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (cmd == "4")
                {
                    memory.Pop();
                    //variable for previous version of the text
                    string newText = memory.Peek();

                    text = new StringBuilder(newText);
                }
            }
        }
    }
}
