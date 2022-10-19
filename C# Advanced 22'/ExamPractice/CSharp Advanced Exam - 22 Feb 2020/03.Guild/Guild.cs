using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> _roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            _roster = new List<Player>();
        }

        public List<Player> Roster { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => _roster.Count;

        public void AddPlayer(Player player)
        {
            if (Count < Capacity)
            {
                _roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            return _roster.Remove(_roster.Find(x => x.Name == name));
        }

        public void PromotePlayer(string name)
        {
            Player player = _roster.Find(x => x.Name == name);

            if (player != null)
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = _roster.Find(x => x.Name == name);

            if (player != null)
            {
                player.Rank = "Trial";
            }

        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] kickedPlayers = _roster.FindAll(x => x.Class == @class).ToArray();

            _roster.RemoveAll(x => x.Class == @class);

            return kickedPlayers;
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in _roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
