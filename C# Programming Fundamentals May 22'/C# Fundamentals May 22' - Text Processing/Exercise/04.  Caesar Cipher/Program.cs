using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _04.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that returns an encrypted version of the same text. Encrypt the text by shifting each character with three positions forward. For example, A would be replaced by D, B would become E, and so on. Print the encrypted text.

            string input = Console.ReadLine();

            StringBuilder encrypted = new StringBuilder();

            foreach (var element in input)
            {
                encrypted.Append((char)(element + 3));
            }
            Console.WriteLine(encrypted);
        }
    }
}
