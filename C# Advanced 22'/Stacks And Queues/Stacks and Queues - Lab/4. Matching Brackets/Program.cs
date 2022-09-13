﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string expression = Console.ReadLine();

            //create the stack
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }

                if (expression[i] == ')')
                {
                    int startIndex = indexes.Pop();

                    Console.WriteLine(expression.Substring(startIndex, i - startIndex +1));
                }
            }
        }
    }
}
