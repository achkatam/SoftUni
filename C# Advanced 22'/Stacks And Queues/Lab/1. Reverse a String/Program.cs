﻿using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToReverse = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var symbol in stringToReverse)
            {
                stack.Push(symbol);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
