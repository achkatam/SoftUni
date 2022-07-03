using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            var teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var currTeamInfo = Console.ReadLine().Split('-');
                var creator = currTeamInfo[0];
                var teamName = currTeamInfo[1];

                //•	If а user tries to create a team more than once, a message should be displayed: 
                if (teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                //•	A creator of a team cannot create another team – the following message should be thrown: 
                //-"{user} cannot create another team!"
                else if (teams.Any(c => c.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            var command = Console.ReadLine();

            while (command != "end of assignment")
            {
                var membersInfo = command.Split(new string[] { "->" }
                , StringSplitOptions.RemoveEmptyEntries);

                var memberName = membersInfo[0];
                var teamToJoin = membersInfo[1];
                //•	If а user tries to join a non-existent team, a message should be displayed: 
                //
                //•	A member of a team cannot join another team – the following message should be thrown:
                //-


                if (teams.Any(team => team.Members.Contains(memberName) || teams.Any(c => c.Creator == memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else if (teams.All(t => t.Name != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var currTeam = teams.Find(x => x.Name == teamToJoin);
                    currTeam.Members.Add(memberName);
                }

                command = Console.ReadLine();
            }

            var validTeams = teams.Where(x => x.Members.Count > 0);

            var disbandTeams = teams.Where(team => team.Members.Count == 0);

            foreach (var team in validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");


            foreach (var team in disbandTeams.OrderBy(x => x.Name))
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
