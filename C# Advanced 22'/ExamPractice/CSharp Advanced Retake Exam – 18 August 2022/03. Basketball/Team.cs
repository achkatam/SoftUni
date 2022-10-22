using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            Players = new List<Player>();
        }
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }

        public int Count => Players.Count;

        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }

            if (OpenPositions == 0)
            {
                return "There are no more open positions.";
            }

            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }

            Players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            Player player = Players.FirstOrDefault(x => x.Name == name);
            if (player != null)
            {
                OpenPositions++;
                Players.Remove(player);

                return true;
            }

            return false;
        }

        public int RemovePlayerByPosition(string position)
        {
            int count = Players.RemoveAll(x => x.Position == position);

            OpenPositions += count;
            return count;
        }

        public Player RetirePlayer(string name)
        {
            foreach (var player in Players.Where(x => x.Name == name))
            {
                player.Retired = true;

                return player;
            }

            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> list = Players.FindAll(x => x.Games >= games).ToList();

            return list;
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");

            foreach (var player in Players.FindAll(x => x.Retired == false))
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().Trim();
        }

    }
}
