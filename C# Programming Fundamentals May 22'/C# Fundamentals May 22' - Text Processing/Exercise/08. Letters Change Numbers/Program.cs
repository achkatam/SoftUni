using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nakov likes Math. But he also likes the English alphabet. He invented a game with numbers and letters from the English alphabet. The game was simple. You get a string consisting of a number between two letters. Depending on whether the letter was in front of the number or after it you would perform different mathematical operations on the number to achieve the result.

       
            //But the game became too easy for Nakov.He decided to complicate it a bit by doing the same but with multiple strings keeping track of only the total sum of all results.Once he started to solve this with more strings and bigger numbers it became quite hard to do it only in his mind.So he kindly asks you to write a program that calculates the sum of all numbers after the operations on each number have been done.

            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var symbol in input)
            {
                char firstLetter = symbol[0];
                char lastLetter = symbol[symbol.Length - 1];

                //variable for the number in the input substrings starting from the symbol on index 1 and 1 index before the last letter
                double number = double.Parse(symbol.Substring(1, symbol.Length - 2));

                double result = 0;

                //First, you start with the letter before the number. 
                //•	If it's uppercase you divide the number by the letter's position in the alphabet. 
                //•	If it's lowercase you multiply the number with the letter's position in the alphabet. 
                if (char.IsUpper(firstLetter))
                {
                    //First letter position in the alphabet
                    //In ASCII table 'A' == 64
                    int position = firstLetter - 64;
                    result = number / position;
                }
                else
                {
                    //In ASCII table 'a' == 97
                    int position = firstLetter - 96;
                    result = number * position;
                }
                //Then you move to the letter after the number. - lastLetter
                //•	If it's uppercase you subtract its position from the resulted number.
                //•	If it's lowercase you add its position to the resulted number.
                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    sum += result - position;
                }
                else
                {
                    int position = lastLetter - 96;
                    sum += result + position;
                }
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
