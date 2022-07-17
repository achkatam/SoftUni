using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that translates messages from Morse code to English (capital letters). Use this page to help you (without the numbers). The words will be separated by a space (' '). There will be a '|' character which you should replace with ' ' (space).


            Dictionary<char, string> morseCodeAlphabet = new Dictionary<char, string>
            {
                ['A'] = ".-",
                ['B'] = "-...",
                ['C'] = "-.-.",
                ['D'] = "-..",
                ['E'] = ".", ['F'] = "..-.", ['G'] = "--.", ['H'] = "....", ['I'] = "..", ['J'] =".---", ['K'] = "-.-",
                ['L'] = ".-..", ['M'] = "--", ['N'] = "-.", ['O'] = "---", ['P'] = ".--.", ['Q'] = "--.-", ['R'] = ".-.",
                ['S'] = "...", ['T'] = "-", ['U'] = "..-", ['V'] = "...-", ['W'] = ".--", ['X'] = "-..-", ['Y'] = "-.--", ['Z'] = "--.."
            };

            var input = Console.ReadLine().Split('|');

            StringBuilder decryptMessage = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var morseCode = input[i].Split();

                foreach (var letter in morseCode)
                {
                    decryptMessage.Append(morseCodeAlphabet.FirstOrDefault(x => x.Value == letter).Key);
                }

                decryptMessage.Append(' ');

            }

            Console.WriteLine(decryptMessage);
        }
    }
}
