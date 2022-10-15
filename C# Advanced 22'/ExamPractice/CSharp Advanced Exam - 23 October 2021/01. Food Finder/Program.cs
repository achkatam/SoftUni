using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    public class Program
    {
        static void Main(string[] args)
        {
            //•	"pear"
            //•	"flour"
            //•	"pork"
            //•	"olive"
            var words = new Dictionary<string, HashSet<char>>
            {
                { "pear", new HashSet<char>()},
                { "flour", new HashSet<char>()},
                { "pork", new HashSet<char>()},
                { "olive", new HashSet<char>()},
            };

            var vowelsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();

            var vowels = new Queue<char>(vowelsInput);

            var consonantInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(char.Parse).ToArray();

            var consonants = new Stack<char>(consonantInput);

            while (consonants.Any())
            {
                //•	"pear"
                //•	"flour"
                //•	"pork"
                //•	"olive"

                var vowel = vowels.Peek();
                var consonant = consonants.Peek();

                foreach (var word in words)
                {
                    if (word.Key.Contains(vowel))
                    {
                        word.Value.Add(vowel);
                    }
                    if (word.Key.Contains(consonant))
                    {
                        word.Value.Add(consonant);
                    }
                }

                vowels.Enqueue(vowels.Dequeue());
                consonants.Pop();
            }

            var filtered = words.Where(word => word.Key.Length == word.Value.Count).Select(word => word.Key).ToList();

            Console.WriteLine($"Words found: {filtered.Count}");
            foreach (var word in filtered)
            {
                Console.WriteLine(word);
            }
        }
    }
}
