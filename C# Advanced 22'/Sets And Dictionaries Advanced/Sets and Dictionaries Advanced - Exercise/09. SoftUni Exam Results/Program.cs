using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take all the submissions and analyze them properly. You should collect all the submissions and print the final results and statistics about each language that the participants submitted their solutions in.
            //You will be receiving lines in the following format: "{username}-{language}-{points}", until you receive "exam finished".You should store each username and his submissions and points.
            //You can receive a command to ban a user for cheating in the following format: "{username}-banned".In that case, you should remove the user from the contest, but preserve his submissions in the total count of submissions for each language.
            //                             username points
            var students = new Dictionary<string, int>();
            //                                lang    - submissions
            var languaegStats = new Dictionary<string, int>();


            string command = Console.ReadLine();

            while (command != "exam finished")
            {
                var tokens = command
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];

                if (tokens[1] == "banned")
                {
                    students.Remove(username);

                    command = Console.ReadLine();
                    continue;
                }

                string language = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!students.ContainsKey(username))
                {
                    students.Add(username, 0);
                }

                if (students[username] < points)
                {
                    students[username] = points;
                }

                if (!languaegStats.ContainsKey(language))
                {
                    languaegStats[language] = 0;
                }

                languaegStats[language]++;

                command = Console.ReadLine();
            }

            Console.WriteLine($"Results:");

            foreach (var student in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine($"Submissions:");
            foreach (var language in languaegStats.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }

        }
    }
}
