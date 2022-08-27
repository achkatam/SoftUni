using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {

            //You will be receiving lines in the following format: "{username}-{language}-{points}", until you receive "exam finished". You should store each username and his submissions and points. 
            //You can receive a command to ban a user for cheating in the following format: "{username}-banned".In that case, you should remove the user from the contest, but preserve his submissions in the total count of submissions for each language.

            //                    Dictinary<name, int>()
            var usernames = new Dictionary<string, int>();
            var submissionsLanguage = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (command != "exam finished")
            {
                var tokens = command.Split("-"
                    , StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string language = tokens[1];

                if (language == "banned")
                {
                    if (usernames.ContainsKey(username))
                    {
                        usernames.Remove(username);
                    }
                }
                else
                {
                    int points = int.Parse(tokens[2]);

                    if (!usernames.ContainsKey(username))
                    {
                        usernames[username] = points;
                    }
                    else if (usernames[username] < points)
                    {
                        usernames[username] = points;
                    }

                    if (!submissionsLanguage.ContainsKey(language))
                    {
                        submissionsLanguage.Add(language, 0);
                    }

                    submissionsLanguage[language]++;
                }

                command = Console.ReadLine();
            }

            //•	Print the exam results for each participant, ordered descending by max points and then by username, in the following format: 
            //"Results:"
            //"{username} | {points}"

            Console.WriteLine("Results:");
            foreach (var username in usernames.OrderByDescending(x =>x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{username.Key} | {username.Value}");
            }

            //•	After that print each language, ordered descending by total submissions and then by language name, in the following format:
            //"Submissions:"
            //"{language} – {submissionsCount}"
            Console.WriteLine("Submissions:");
            foreach (var lang in submissionsLanguage.OrderByDescending(x =>x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }

        }
    }
}
