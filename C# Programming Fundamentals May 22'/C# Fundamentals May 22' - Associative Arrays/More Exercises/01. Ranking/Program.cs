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

            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                string[] tokens = command.Split(":",
                    StringSplitOptions.RemoveEmptyEntries);

                string contestName = tokens[0];
                string contestPassword = tokens[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = contestPassword;
                }

                command = Console.ReadLine();
            }


            //"{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions"
            string info = Console.ReadLine();

            //New dictionary for studentsInfo
            var studentsInfo = new Dictionary<string, Dictionary<string, int>>();

            while (info != "end of submissions")
            {
                string[] tokens = info.Split("=>",
                    StringSplitOptions.RemoveEmptyEntries);
                string contestName = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.ContainsKey(contestName) && contests.ContainsValue(password))
                {
                    if (studentsInfo.ContainsKey(username))
                    {
                        if (studentsInfo[username].ContainsKey(contestName))
                        {
                            if (studentsInfo[username][contestName] < points) studentsInfo[username][contestName] = points;
                        }
                        else
                        {
                            studentsInfo[username].Add(contestName, points);
                        }
                    }
                    else
                    {
                        studentsInfo[username] = new Dictionary<string, int>() { { contestName, points } };
                    }
                }

                info = Console.ReadLine();
            }
            BestStudent(studentsInfo);
            //After that print all students ordered by their names. For each user print each contest with the points in descending order
            AllStudents(studentsInfo);

        }

        static void AllStudents(Dictionary<string, Dictionary<string, int>> studentsInfo)
        {
            foreach (var student in studentsInfo.OrderBy(s => s.Key))
            {
                //"{user1 name}"
                //"#  {contest1} -> {points}"
                //"#  {contest2} -> {points}"
                Console.WriteLine($"{student.Key}");
                Console.WriteLine(string.Join("\n", student.Value.OrderByDescending(s=>s.Value)
                    .Select(s=>$"#  {s.Key} -> {s.Value}")));

                //foreach (var contest in student.Value.OrderByDescending(s => s.Value))
                //{
                //    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                //}
            }
        }

        static void BestStudent(Dictionary<string, Dictionary<string, int>> studentsInfo)
        {
            //Create variables for bestStudent and bestScore
            string bestStudent = string.Empty;
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
        }
    }
}
