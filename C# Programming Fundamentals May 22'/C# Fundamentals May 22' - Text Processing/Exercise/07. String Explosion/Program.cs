using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explosions are marked with '>'. Immediately after the mark, there will be an integer, which signifies the strength of the explosion.
            //You should remove x characters(where x is the strength of the explosion), starting after the punched character('>').
            //If you find another explosion mark('>') while you’re deleting characters, you should add the strength to your previous explosion.
            //When all characters are processed, print the string without the deleted characters.
            //You should not delete the explosion character – '>', but you should delete the integers, which represent the strength.

            var input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int strength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                
                if (symbol != '>' && strength > 0)
                {
                    strength--;
                }
                else if (symbol == '>')
                {
                    sb.Append(symbol);
                    strength += int.Parse(input[i + 1].ToString());
                }
                else
                {
                    sb.Append(symbol);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
