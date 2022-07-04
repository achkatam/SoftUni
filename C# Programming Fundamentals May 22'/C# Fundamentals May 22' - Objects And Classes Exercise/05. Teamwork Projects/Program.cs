using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //It's time for the teamwork projects and you are responsible for gathering the teams. First, you will receive an integer - the count of the teams you will have to register. You will be given a user and a team, separated with "-".  The user is the creator of the team. For every newly created team you should print a message: 


            //Integer of the count of teams to be registered
            int countOfTeams = int.Parse(Console.ReadLine());

            //List of teams
            List<Team> teams = new List<Team>();

            //For loop until counfOfTeams
            for (int i = 0; i < countOfTeams; i++)
            {
                //User and a team, separated with "-"
                string[] command = Console.ReadLine().Split("-");
                string creator = command[0];
                string teamName = command[1];

                //•	If а user tries to create a team more than once, a message should be displayed
                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                //•	A creator of a team cannot create another team – the following message should be thrown
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    //He can create a new team !
                    var team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
            //Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team. Upon receiving the command: "end of assignment", 

            var tokens = Console.ReadLine().Split("->").ToArray();

            while (tokens[0] != "end of assignment")
            {
                string user = tokens[0];
                string joinTheTeam = tokens[1];

                //•	If а user tries to join a non-existent team, a message should be displayed
                if (teams.All(x => x.Name != joinTheTeam))
                {
                    Console.WriteLine($"Team {joinTheTeam} does not exist!");
                }
                //•	A member of a team cannot join another team – the following message should be thrown
                //Also the creator cannot join another team
                else if (teams.Any(x => x.Members.Contains(user) || teams.Any(x => x.Creator == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {joinTheTeam}!");
                }
                else
                {
                    //Just join the team w/o printing anything
                    var team = teams.Find(x => x.Name == joinTheTeam);
                    team.Members.Add(user);
                }
                tokens = Console.ReadLine().Split("->");
            }
            //you should print every team, ordered by the count of its members (descending) and then by name (ascending). For each team, you have to print its members sorted by name (ascending)
            //•	In the end, teams with zero members (with only a creator) should disband and you have to print them ordered by name in ascending order. 
            //•	 Every valid team should be printed ordered by name(ascending) in the following format:
            var disbandTeam = teams.Where(s => s.Members.Count == 0);
            var validTeam = teams.Where(x => x.Members.Count > 0);

            foreach (var team in validTeam.OrderByDescending(x=>x.Members.Count).ThenBy(n =>n.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                //For each for all the members in the team order by
                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            //One more foreach loop for disband teams
            Console.WriteLine($"Teams to disband:");
            foreach (var team in disbandTeam.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{team.Name}");
            }


        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
