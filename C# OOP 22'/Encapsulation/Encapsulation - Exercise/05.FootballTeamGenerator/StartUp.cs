namespace _05.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Team> teamList;

        static void Main(string[] args)
        {
            teamList = new List<Team>();

            RunEngine();
        }

        static void RunEngine()
        {

            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split(";");

                string cmd = tokens[0];
                string teamName = tokens[1];

                try
                {
                    switch (cmd)
                    {
                        case "Team":
                            AddNewTeam(teamName);
                            break;
                        case "Add":
                            AddPlayerToTeam(teamName, tokens);
                            break;
                        case "Remove":
                            string playerName = tokens[2];

                            RemovePlayerFromTeam(teamName, playerName);
                            break;
                        case "Rating":
                            RateTeam(teamName);
                            break;
                    }

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                command = Console.ReadLine();
            }
        }

        static void RateTeam(string teamName)
        {
            Team teamToRate = teamList.FirstOrDefault(x => x.Name == teamName);

            if (teamToRate == null)
            {
                throw new InvalidOperationException(String.Format
      (ExceptionMessages.NotExcistinTeam, teamName));
            }

            Console.WriteLine(teamToRate.ToString());
        }

        static void AddNewTeam(string teamName)
        {
            Team newTeam = new Team(teamName);
            teamList.Add(newTeam);
        }

        static void AddPlayerToTeam(string teamName, string[] tokens)
        {
            Team teamToAdd = teamList
                        .FirstOrDefault(x => x.Name == teamName);

            if (teamToAdd == null)
            {
                throw new InvalidOperationException(String.Format
                    (ExceptionMessages.NotExcistinTeam, teamName));
            }

            string playerName = tokens[2];

            int endurance = int.Parse(tokens[3]);
            int sprint = int.Parse(tokens[4]);
            int dribble = int.Parse(tokens[5]);
            int passing = int.Parse(tokens[6]);
            int shooting = int.Parse(tokens[7]);

            Player playerToAdd = new Player(playerName, endurance, sprint, dribble, passing, shooting);

            teamToAdd.AddPlayer(playerToAdd);
        }

        static void RemovePlayerFromTeam(string teamName, string playerName)
        {
            Team removingTeam = teamList.FirstOrDefault(x => x.Name == teamName);

            if (removingTeam == null)
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.NotExcistinTeam, teamName));
            }

            removingTeam.RemovePlayer(playerName);
        }
    }
}
