namespace _05.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Team
    {
        private string name;
        private List<Player> playersList;

        private Team()
        {
            this.playersList = new List<Player>();
        }

        public Team(string name) : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameCannotBeWhiteSpaceOrNull);
                }

                this.name = value;
            }
        }

        public int Rating
            => this.playersList.Any() ? (int)Math.Round(this.playersList.Average(x => x.OverallRating), 0) : 0;

        public void AddPlayer(Player player)
        {
            this.playersList.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = playersList.FirstOrDefault(p => p.Name == playerName);

            if (playerToRemove == null)
            {
                throw new InvalidOperationException
                    (string.Format(ExceptionMessages.MissingPlayer, playerName, this.Name));
            }

            this.playersList.Remove(playerToRemove);
        }

        public override string ToString() => $"{this.Name} - {this.Rating}";
    }
}
