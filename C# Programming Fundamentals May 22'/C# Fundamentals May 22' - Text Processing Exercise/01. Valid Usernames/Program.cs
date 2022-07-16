using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads user names on a single line (joined by ", ") and prints all valid usernames. 
            //A valid username:
            //•	Has length between 3 and 16 characters and
            //•	Contains only letters, numbers, hyphens, and underscores
            //Jeff, john45, ab, cd, peter-ivanov, @smith

            var usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            ValidUsernames(usernames);
        }

        static void ValidUsernames(List<string> usernames)
        {
            //var validNames = usernames.Where(user => user.All(x => char.IsLetterOrDigit(x) || x == '-' || x == '_'
            //&& user.Length >= 3 && user.Length <= 16)).ToList();

            Console.WriteLine(string.Join("\n", usernames.Where(user => user.All(x => char.IsLetterOrDigit(x) || x == '-' || x == '_')
            && user.Length >= 3 && user.Length <= 16)));
        }
    }
}
