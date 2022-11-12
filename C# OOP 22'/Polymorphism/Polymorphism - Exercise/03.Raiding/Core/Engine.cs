namespace Raiding.Core
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Raiding.Exceptions;
    using Raiding.Factories.Contracts;
    using Raiding.IO.Contracts;
    using Raiding.Models;
    using Raiding.Models.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IBaseHeroFactory baseHeroFactory;

        private readonly ICollection<IBaseHero> heroes;

        private Engine()
        {
            this.heroes = new List<IBaseHero>();
        }

        public Engine(IReader reader, IWriter writer, IBaseHeroFactory baseHeroFactory)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.baseHeroFactory = baseHeroFactory;
        }

        public void Run()
        {
            this.CreateHeroes();

            this.DefeatTheBoss();
        }

        private void DefeatTheBoss()
        {
            int bossHp = int.Parse(this.reader.ReadLine());

            Boss boss = new Boss(bossHp);


            foreach (IBaseHero hero in this.heroes)
            {
                this.writer.WriteLine(hero.CastAbility());

                boss.Hp -= hero.Power;
            }

            this.writer.WriteLine(boss.Hp <= 0 ? "Victory!" : "Defeat...");
        }

        private void CreateHeroes()
        {
            int n = int.Parse(this.reader.ReadLine());
//add counter.. By constraints the loop should last until full set of heores is created
            int validHeroes = 0;

            while (validHeroes != n)
            {
                try
                {
                    this.heroes.Add(this.BuildHerosUsingFactory());

                    validHeroes++;
                }
                catch (InvalidHeroType iht)
                {
                    this.writer.WriteLine(iht.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private IBaseHero BuildHerosUsingFactory()
        {
            string heroName = this.reader.ReadLine();
            string heroType = this.reader.ReadLine();

            IBaseHero hero = this.baseHeroFactory.CreateHero(heroName, heroType);

            return hero;
        }
    }
}
