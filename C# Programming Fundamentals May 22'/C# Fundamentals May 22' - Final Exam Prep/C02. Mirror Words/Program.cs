using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the input, you will be given a text string.To win the competition, you have to find all hidden word pairs, read them, and mark the ones that are mirror images of each other.
            //First of all, you have to extract the hidden word pairs. Hidden word pairs are:
            //•	Surrounded by "@" or "#"(only one of the two) in the following pattern #wordOne##wordTwo# or @wordOne@@wordTwo@
            //•	At least 3 characters long each(without the surrounding symbols)
            //•	Made up of letters only
            //If the second word, spelled backward, is the same as the first word and vice versa(casing matters!), they are a match, and you have to store them somewhere. Examples of mirror words: 
            //#Part##traP# @leveL@@Level@ #sAw##wAs#
            //•	If you don`t find any valid pairs, print: "No word pairs found!"
            //•	If you find valid pairs print their count: "{valid pairs count} word pairs found!"
            //•	If there are no mirror words, print: "No mirror words!"
            //•	If there are mirror words print:
            //"The mirror words are:
            //{ wordOne} <=> { wordtwo}, { wordOne} <=> { wordtwo}, … { wordOne} <=> { wordtwo}

            string pattern =
                @"(\@{1,2}|\#{1,2})(?<word>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            string input = Console.ReadLine();

            var matchWords = Regex.Matches(input, pattern);

            var mirrorWords = new List<string[]>();

            if (matchWords.Count > 0)
            {
                Console.WriteLine($"{matchWords.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            foreach (Match match in matchWords)
            {
                string firstWord = match.Groups["word"].Value;
                string secondWord = match.Groups["word2"].Value;

                string reversedWord = string.Join("", secondWord.Reverse());

                if (firstWord == reversedWord)
                {
                    mirrorWords.Add(new string[] { firstWord, secondWord });
                }
            }

            if (mirrorWords.Count > 0)
            {
                Console.WriteLine($"The mirror words are:");

                var mirrorPairs = mirrorWords.Select(x => $"{x[0]} <=> {x[1]}").ToArray();
                Console.WriteLine(string.Join(", ", mirrorPairs));
            }
            else
            {
                Console.WriteLine($"No mirror words!");
            }
        }
    }
}
