using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using NUnit.Framework;

namespace FootballTeam.Tests
{
    public class Tests
    {
        private FootballTeam team;
        List<FootballPlayer> playerList;
        private FootballPlayer player;
        [SetUp]
        public void Setup()
        {
            team = new FootballTeam("Loko", 25);
            playerList = new List<FootballPlayer>();
            player = new FootballPlayer("Angel", 12, "Midfielder");
        }

        [Test]
        public void Test1()
        {

            string expectedName = "Loko";
            int expectedCapacity = 25;

            Assert.AreEqual(expectedName, team.Name);
            Assert.AreEqual(expectedCapacity, team.Capacity);
        }

        [Test]
        public void TestPlayer()
        {
            string expectedName = "Angel";
            string expectedPos = "Midfielder";
            int expectedNumber = 12;

            Assert.AreEqual(expectedName, player.Name);
            Assert.AreEqual(expectedPos, player.Position);
            Assert.AreEqual(expectedNumber, player.PlayerNumber);
        }

        [TestCase(null)]
        [TestCase("")]
        public void TestPlayerName(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                player = new FootballPlayer(name, 24, "Midfielder");
            });
        }

        [TestCase(0)]
        [TestCase(1293)]
        public void TestPlayerNum(int number)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                player = new FootballPlayer("Angel", number, "Midfielder");
            });
        }

        [TestCase("golie")]
        [TestCase("center")]
        public void TestPlayerPos(string pos)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                player = new FootballPlayer("Angel", 14, pos);
            });
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test2(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                team = new FootballTeam(name, 25);
            });
        }


        [TestCase(12)]
        [TestCase(14)]
        [TestCase(2)]
        public void Test3(int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                team = new FootballTeam("Loko", capacity);
            });
        }


        [Test]
        public void Test4()
        {
            Assert.AreEqual(team.Players.Count, playerList.Count);
        }

        [Test]
        public void TestAddNewPlayer()
        {
            FootballPlayer player = new FootballPlayer("name", 14, "Midfielder");

            team.AddNewPlayer(player);


            string exp = $"Added player name in position Midfielder with number 14";

            Assert.AreEqual(exp, team.AddNewPlayer(player));
        }

        [Test]
        public void Test2AddNewPlayer()
        {
            team = new FootballTeam("None", 15);

            for (int i = 0; i <= 15; i++)
            {
                team.AddNewPlayer(new FootballPlayer("name" + i.ToString(), 1 + i, "Midfielder"));

            }

            string expected = "No more positions available!";


            Assert.AreEqual(expected, team.AddNewPlayer(new FootballPlayer("Angel", 18, "Midfielder")));
        }

        

        [Test]
        public void TestPickPlayer()
        {
            FootballPlayer player = new FootballPlayer("name", 14, "Midfielder");

            team.AddNewPlayer(player);

            var expected = player;

            Assert.AreEqual(expected, team.PickPlayer("name"));
        }

        [Test]
        public void PlayerScore()
        {
            team.AddNewPlayer(new FootballPlayer("name", 14, "Midfielder"));


            //FootballPlayer player = this.team.Players.FirstOrDefault(p => p.PlayerNumber == 14);
           // team.PlayerScore(14);
            //player.Score();

            int exp1 = 1;
           // Assert.AreEqual(exp1, player.ScoredGoals);
            string exp = $"name scored and now has 1 for this season!";

            Assert.AreEqual(exp, team.PlayerScore(14));
        }
    }
}