namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            //Write a program that reads a list of words from a given file (e. g. words.txt) and finds how many times each of the words occurs in another file (e. g. text.txt). Matching should be case-insensitive. The result should be written to an output text file (e. g. output.txt). Sort the words by frequency in descending order.

            //create usings for each file
            using var words = new StreamReader(wordsFilePath);
            using var text = new StreamReader(textFilePath);
            using var writer = new StreamWriter(outputFilePath);

            //words are located in wordsFile. Store them in a dictionary<word, occurencies> 
            //Swap it as an array and then add the words into the dictionary
            var wordsToBeCounted = words.ReadLine().Split();

            var wordCounter = new Dictionary<string, int>()
            {
                {wordsToBeCounted[0], 0 },
                {wordsToBeCounted[1], 0 },
                {wordsToBeCounted[2],0 }
            };

            while (!text.EndOfStream)
            {
                string[] line = text.ReadLine().Split(new string[] { ".", "-", ", ", " " }, StringSplitOptions.RemoveEmptyEntries);

                //foreach to iterate thru each word and add it in the dict.
                foreach (var word in line)
                {
                    if (wordCounter.ContainsKey(word.ToLower()))
                    {
                        //increase word's occurence 
                        wordCounter[word.ToLower()]++;
                    }
                }
            }

            //PrintOutput
            PrintOutput(wordCounter, writer);

        }

        static void PrintOutput(Dictionary<string, int> wordCounter, StreamWriter writer)
        {
            foreach (var (word, occurence) in wordCounter.OrderByDescending(x => x.Value))
            {
                writer.WriteLine($"{word} - {occurence}");
            }
        }
    }
}
