using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {


        static void Main(string[] args)
        {
            //Create a program that ranks candidate-interns, depending on the points from the interview tasks and their exam results in SoftUni. You will receive some lines of input in the format "{contest}:{password for contest}" until you receive "end of contests". Save that data because you will need it later. After that you will receive another type of inputs in the format "{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions". Here is what you need to do:
            //•	Check if the contest is valid(if you received it in the first type of input).
            //•	Check if the password is correct for the given contest.
            //•	Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest.If you receive the same contest and the same user, update the points only if the new ones are more than the older ones.
            //At the end you have to print the info for the user with the most points in the format:


            //                          nameOfcontest and password
            var contests = new Dictionary<string, string>();

            //                             username, contestName, points
            var candidates = new Dictionary<string, Dictionary<string, int>>();


            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                var tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "end of submissions")
            {
                var tokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (ValidContest(contest, password, contests))
                {
                    AddStudents(candidates, contest, username, points);
                }

                command = Console.ReadLine();
            }
            //vairable for the best student
            var bestStudent = candidates.OrderByDescending(x => x.Value.Values.Sum()).First().Key;
            //variable for max points
            var bestpoints = candidates[bestStudent].Values.Sum();

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestpoints} points.");

            Console.WriteLine($"Ranking:");

            //print all students ordered by their names. For each user, print each contest with the points in descending order 
            foreach (var student in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key}");

                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }

        static void AddStudents(Dictionary<string, Dictionary<string, int>> candidates, string contest, string username, int points)
        {
            if (!candidates.ContainsKey(username))
            {
                candidates.Add(username, new Dictionary<string, int>());
            }

            if (!candidates[username].ContainsKey(contest))
            {
                candidates[username].Add(contest, 0);
            }

            if (candidates[username][contest] < points)
            {
                candidates[username][contest] = points;
            }
        }

        static bool ValidContest(string contest, string password, Dictionary<string, string> contests)
        {
            return
                contests.ContainsKey(contest) && contests[contest] == password;
        }
    }
}
