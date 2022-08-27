using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that ranks candidate-interns, depending on the points from the interview tasks and their exam results in SoftUni. You will receive some lines of input in the format "{contest}:{password for contest}" until you receive "end of contests". Save that data because you will need it later. 

            //dictionary for contestsData <contestName, password>
            var contests = new Dictionary<string, string>();

            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                var input = command.Split(":"
                    , StringSplitOptions.RemoveEmptyEntries);

                string contest = input[0];
                string password = input[1];

                contests.Add(contest, password);

                command = Console.ReadLine();
            }

            //After that you will receive another type of inputs in the format "{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions". Here is what you need to do:

            command = Console.ReadLine();
            var students = new Dictionary<string, Dictionary<string, int>>();

            while (command != "end of submissions")
            {
                //"{contest}=>{password}=>{username}=>{points}"
                var tokens = command.Split("=>"
                    , StringSplitOptions.RemoveEmptyEntries);

                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                var points = int.Parse(tokens[3]);

                bool validContest = isValidContest(contest, password, contests);

                if (validContest)
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                        students[username].Add(contest, points);
                    }
                    else
                    {
                        //•	Check if the contest is valid(if you received it in the first type of input).
                        //•	Check if the password is correct for the given contest.
                        //•	Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest.If you receive the same contest and the same user, update the points only if the new ones are more than the older ones.

                        if (students[username].ContainsKey(contest))
                        {
                            if (students[username][contest] < points)
                            {
                                students[username][contest] = points;
                            }
                        }
                        else
                        {
                            students[username].Add(contest, points);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            //At the end you have to print the info for the user with the most points in the format:
            
            //"{user1 name}
            //#  {contest1} -> {points}
            //#  {contest2} -> {points}
            //{ user2 name}

            string bestStudent = string.Empty;
            int highestPoints = 0;

            foreach (var student in students)
            {
                //variable sum of points
                int sum = 0;
                foreach (var item in student.Value)
                {
                    sum += item.Value;
                }

                if (sum > highestPoints)
                {
                    bestStudent = student.Key;
                    highestPoints = sum;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {highestPoints} points.");
            //.". After that print all students ordered by their names. For each user, print each contest with the points in descending order in the following format:

            students = students.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"Ranking:");

            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                foreach (var item in student.Value.OrderByDescending(x =>x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

        }

        static bool isValidContest(string contest, string password, Dictionary<string, string> contests)
        {
            if (contests.ContainsKey(contest))
            {
                if (contests[contest].Contains(password)) return true;
            }

            return false;
        }
    }
}
