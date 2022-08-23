using System;
using System.Collections.Generic;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive n lines.On those lines, you will receive one of the following:
            //•	Opening bracket – “(“,
            //•	Closing bracket – “)” or
            //•	Random string
            //Your task is to find out if the brackets are balanced.That means after every closing bracket should follow an opening one.Nested parentheses are not valid, and if two consecutive opening brackets exist, the expression should be marked as unbalanced.

            //input
            int n = int.Parse(Console.ReadLine());
            //add-ons
            bool isOpeninBracketFirst = false, isUnabalanced = false;
            //Solution first
            List<string> openingBrackets = new List<string>();
            List<string> closingBrackets = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    isOpeninBracketFirst = true;
                    openingBrackets.Add(input);
                }
                else if (input == ")")
                {
                    if (!isOpeninBracketFirst) isUnabalanced = true;

                    isOpeninBracketFirst = false;
                    closingBrackets.Add(input);
                }
            }
            if (openingBrackets.Count == closingBrackets.Count && !isUnabalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
