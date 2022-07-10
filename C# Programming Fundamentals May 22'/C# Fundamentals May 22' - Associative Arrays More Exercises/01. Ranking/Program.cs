using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here comes the final and the most interesting part – the Final ranking of the candidate-interns. The final ranking is determined by the points of the interview tasks and from the exams in SoftUni. Here is your final task. You will receive some lines of input in the format "{contest}:{password for contest}" until you receive "end of contests". Save that data because you will need it later. After that, you will receive another type of inputs in the format "{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions". Here is what you need to do. 


            //In the end, you have to print the info for the user with the most points in the format "Best candidate is {user} with total {total points} points.".After that print all students ordered by their names.For each user print each contest with the points in descending order.See the examples

            //Create two dictionaries for contestInfo and student submission, which will be dictionary in dictionary
            //  contestName and password = string, string
            var contests = new Dictionary<string, string>();
            // studentName and points
            var studentsInfo = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(":"
                    , StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "end of contests") break;
                //"{contest}:{password for contest}"
                string contest = command[0];
                string contestPassword = command[1];

                contests[contest] = contestPassword;
            }

            //"{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions"
            while (true)
            {
                string[] cmds = Console.ReadLine().Split("=>",
                    StringSplitOptions.RemoveEmptyEntries);

                if (cmds[0] == "end of submissions") break;

                string contestName = cmds[0];
                string password = cmds[1];
                string username = cmds[2];
                int points = int.Parse(cmds[3]);

                //Nested if statements
                //•	Check if the contest is valid(if you received it in the first type of input)
                if (contests.ContainsKey(contestName))
                {
                    //•	Check if the password is correct for the given contest
                    if (contests.ContainsValue(password))
                    {
                        //•	Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest.If you receive the same contest and the same user updates the points only if the new ones are more than the older ones.
                        if (studentsInfo.ContainsKey(username))
                        {
                            if (studentsInfo[username].ContainsKey(contestName))
                            {
                                if (studentsInfo[username][contestName] < points)
                                {
                                    studentsInfo[username][contestName] = points;
                                }
                            }
                            else
                            {
                                studentsInfo[username].Add(contestName, points);
                            }
                        }
                        else
                        {
                            studentsInfo[username] = new Dictionary<string, int> { { contestName, points } };
                        }
                    }
                }
            }
            string bestStudent = " ";
            int bestScore = 0;

            foreach (var student in studentsInfo)
            {
                if (studentsInfo[student.Key].Values.Sum() > bestScore)
                {
                    bestStudent = student.Key;
                    bestScore = studentsInfo[student.Key].Values.Sum();
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestScore} points.");
            Console.WriteLine("Ranking: ");

            foreach (var user in studentsInfo.OrderBy(n=>n.Key))
            {
                //.". After that print all students ordered by their names. For each user print each contest with the points in descending order. 
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
