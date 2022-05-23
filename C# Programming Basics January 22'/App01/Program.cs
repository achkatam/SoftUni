using System;
using System.Collections;

namespace App01
{
    class Program
    {
        static void Main(string[] args)
        {
            // A R R A Y S L I S T
            ArrayList friends = new ArrayList();
            friends.Add("Oscar");
            friends.Add("Angela");
            friends.Add("Kevin");

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends.Contains("Oscar"));
            Console.WriteLine(friends.Count);

            Console.WriteLine();

            friends.Remove("Oscar");
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends.Contains("Oscar"));
            Console.WriteLine(friends.Count);


        }
    }
}
