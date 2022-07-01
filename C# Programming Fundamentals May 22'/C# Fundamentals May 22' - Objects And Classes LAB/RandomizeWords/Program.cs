using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            //Create random
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);

                string currWord = words[i];

                words[i] = words[randomIndex];
                words[randomIndex] = currWord;
            }
            //output
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
