using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {

            //You know the judge system, right?! Your job is to create a program similar to the Judge system. 
            //You will receive several input lines in one of the following formats:
            //"{username} -> {contest} -> {points}"
            //The constestName and username are strings, the given points will be an integer number.You need to keep track of every contest and individual statistics of every user. 
            //

            //Create two dictionaries - one for contest and one for points
            var contests = new Dictionary<string, Dictionary<string, int>>();

            var totalPoints = new Dictionary<string, int>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" -> "
                    , StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "no more time") break;
                //      username - contest, points
                //Create variables for the fore aforementioned inputs
                string username = command[0];
                string contestName = command[1];
                int points = int.Parse(command[2]);

                //You should check if such a contest already exists, and if not, add it, otherwise, check if the current user Is participating in the contest, if he is participating take the higher score, otherwise, just add it.
                //Also, you need to keep individual statistics for each user -the total points of all contests.

                //Nested If statements
                if (contests.ContainsKey(contestName))
                {
                    if (contests[contestName].Keys.Contains(username))
                    {
                        if (contests[contestName][username] < points)
                        {
                            contests[contestName][username] = points;
                        }
                    }
                    else
                    {
                        contests[contestName].Add(username, points);
                    }
                }
                else
                {
                    contests[contestName] = new Dictionary<string, int> { { username, points } };
                }
            }

            //At that point, you should print each contest in order of input, for each contest print the participants ordered by points in descending order, then ordered by name in ascending order.
            //•	The output format for the contests is:
            //"{constestName}: {participants.Count} participants"
            //"{position}. {username} <::> {points}"
            //•	After you print all contests, print the individual statistics for every participant.
            //•	The output format is:
            

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Keys.Count} participants");

                //create variables for positioncounter. It increases after each contest get printed
                int counter = 1;
                foreach (var participants in contest.Value.OrderByDescending(s => s.Value).ThenBy(name => name.Key))
                {
                    Console.WriteLine($"{counter}. {participants.Key} <::> {participants.Value}");
                    counter++;
                }
            }
            //After that, you should print individual statistics for every participant ordered by total points in descending order, and then by alphabetical order.

            foreach (var contest in contests)
            {
                foreach (var participant in contest.Value)
                {
                    if (!totalPoints.ContainsKey(participant.Key))
                    {
                        totalPoints[participant.Key] = 0;
                    }
                    totalPoints[participant.Key] += participant.Value;
                }
            }
            //"Individual standings:"
            //"{position}. {username} -> {totalPoints}"
            Console.WriteLine("Individual standings:");
            int counterPosition = 1;
            foreach (var user in totalPoints.OrderByDescending(s=>s.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{counterPosition}. {user.Key} -> {user.Value}");
                counterPosition++;
            }
        }
    }
}
