using System;

namespace Print_Part_Of_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints part of the ASCII table of characters at the console.  On the first line of input, you will receive the char index you should start with, and on the second line -the index of the last character you should print.

            //int num = 65;
            //char ch = (char)(num);
            //Console.WriteLine(ch);

            //input
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            //Attempt solution
            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
