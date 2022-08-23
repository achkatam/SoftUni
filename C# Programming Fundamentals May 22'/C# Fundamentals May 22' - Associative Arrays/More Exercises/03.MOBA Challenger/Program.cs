using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peter is a pro-MOBA player, he is struggling to become а master of the Challenger tier. So he watches carefully the statistics in the tier.
            //You will receive several input lines in one of the following formats:
            //"{player} -> {position} -> {skill}"
            //"{player} vs {player}"
            //The player and position are strings, the given skill will be an integer number.You need to keep track of every player. 
            //When you receive a player and his position and skill, add him to the player pool, if he isn`t present, else add his position and skill or update his skill, only if the current position skill is lower than the new value.
            //If you receive "{player} vs {player}" and both players exist in the tier, they duel with the following rules:
            //Compare their positions, if they got at least one in common, the player with better total skill points wins and the other is demoted from the tier -> remove him. If they have the same total skill points, the duel is a tie and they both continue in the Season.
            //If they don`t have positions in common, the duel isn't happening and both continue in the Season.
            //You should end your program when you receive the command "Season end".At that point, you should print the players, ordered by total skill in descending order, then ordered by player name in ascending order. Foreach player prints their position and skill ordered descending by skill, then ordered by position name in ascending order.


            //Create new dictionary - player name, position and skill(integer)
            var players = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Season end")
            {
                var tokens = command.Split(new string[] { " -> ", " vs " }, StringSplitOptions.None);
                if (tokens.Length == 3)
                {
                    string playerName = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);
                    //When you receive a player and his position and skill, add him to the player pool, if he isn`t present, else add his position and skill or update his skill, only if the current position skill is lower than the new value.
                    AddPlayer(players, playerName, position, skill);

                }
                else if (tokens.Length == 2)
                {
                    //Compare their positions, if they got at least one in common, the player with better total skill points wins and the other is demoted from the tier -> remove him. If they have the same total skill points, the duel is a tie and they both continue in the Season.
                    //If they don`t have positions in common, the duel isn't happening and both continue in the Season.

                    string playerOne = tokens[0];
                    string playerTwo = tokens[1];

                    ComparePlayers(players, playerOne, playerTwo);
                }
                command = Console.ReadLine();
            }

            // At that point, you should print the players, ordered by total skill in descending order, then ordered by player name in ascending order. Foreach player prints their position and skill ordered descending by skill, then ordered by position name in ascending order

            //•	The output format for each player is:
            //"{player}: {totalSkill} skill"
            //"- {position} <::> {skill}"

            PrintResult(players);

        }

        private static void ComparePlayers(Dictionary<string, Dictionary<string, int>> players, string playerOne, string playerTwo)
        {
            if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
            {
                if (CommonPosition(players[playerOne], players[playerTwo]))
                {
                    //variables for each player skill points
                    int firstPlayerPoints = players[playerOne].Values.Sum();
                    int secondPlayerPoints = players[playerTwo].Values.Sum();

                    if (firstPlayerPoints > secondPlayerPoints)
                    {
                        players.Remove(playerTwo);
                    }
                    else if (firstPlayerPoints < secondPlayerPoints)
                    {
                        players.Remove(playerOne);
                    }
                }
            }
        }

        private static void AddPlayer(Dictionary<string, Dictionary<string, int>> players, string playerName, string position, int skill)
        {
            if (players.ContainsKey(playerName))
            {
                if (players[playerName].ContainsKey(position))
                {
                    if (players[playerName][position] < skill)
                    {
                        players[playerName][position] = skill;
                    }
                }
                else
                {
                    players[playerName].Add(position, skill);
                }
            }
            else
            {
                players[playerName] = new Dictionary<string, int>() { { position, skill } };
            }
        }

        static void PrintResult(Dictionary<string, Dictionary<string, int>> players)
        {
            foreach (var player in players.OrderByDescending(s => s.Value.Values.Sum()).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                Console.WriteLine(string.Join("\n", player.Value.OrderByDescending(s => s.Value)
                    .ThenBy(name => name.Key).Select(x => $"- {x.Key} <::> {x.Value}")));

                //foreach (var person in player.Value.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                //{
                //    Console.WriteLine($"- {person.Key} <::> {person.Value}");
                //}
            }
        }

        public static bool CommonPosition(Dictionary<string, int> playerOne, Dictionary<string, int> playerTwo)
        {
            foreach (var firstPlayer in playerOne)
            {
                foreach (var secondPlayer in playerTwo)
                {
                    if (firstPlayer.Key == secondPlayer.Key) return true;

                }
            }
            return false;
        }
    }
}
