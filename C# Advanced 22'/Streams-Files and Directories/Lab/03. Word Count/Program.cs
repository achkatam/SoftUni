using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\words.txt";
            string textPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            //Write a program that reads a list of words from a given file (e. g. words.txt) and finds how many times each of the words occurs in another file (e. g. text.txt). Matching should be case-insensitive. The result should be written to an output text file (e. g. output.txt). Sort the words by frequency in descending order.

            //Create usings 
            using var words = new StreamReader(wordsFilePath);
            using var reader = new StreamReader(textFilePath);
            using var writer = new StreamWriter(outputFilePath);

            //Words we have to count
            var wordsToBeCounted = words.ReadLine().Split();

            var dictWord = new Dictionary<string, int>();

            foreach (var word in wordsToBeCounted)
            {
                dictWord.Add(word, 0);
            }

            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(new string[] { ".", "-", ", ", " " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in line)
                {
                    if (dictWord.ContainsKey(word.ToLower()))
                    {
                        dictWord[word.ToLower()]++;
                    }
                }
            }

            //PrintOutput
            PrintOutput(dictWord, writer);

        }

        static void PrintOutput(Dictionary<string, int> dictWord, StreamWriter writer)
        {
            foreach (var (word, occ) in dictWord.OrderByDescending(x =>x.Value))
            {
                writer.WriteLine($"{word} - {occ}");
            }
        }
    }
}
