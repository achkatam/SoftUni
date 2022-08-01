using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the standard input, you will receive an integer n – the number of heroes that you can choose for your party. On the next n lines, the heroes themselves will follow with their hit points and mana points separated by a single space in the following format: 
            //  "{hero name} {HP} {MP}"
            //  - HP stands for hit points and MP for mana points
            //-a hero can have a maximum of 100 HP and 200 MP
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            int numOfHeroes = int.Parse(Console.ReadLine());

            const int MAX_HP = 100;
            const int MAX_MP = 200;

            for (int i = 0; i < numOfHeroes; i++)
            {
                //variable for heroes data
                var data = Console.ReadLine().Split(" "
                    , StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                int hp = int.Parse(data[1]);
                int mp = int.Parse(data[2]);

                heroes[name] = new Hero(name, hp, mp);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split(" - "
                    , StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];
                string name = tokens[1];

                switch (cmd)
                {
                    case "CastSpell":
                        CastSpell(heroes, tokens, name);
                        break;
                    case "TakeDamage":
                        TakeDamage(heroes, tokens, name);
                        break;
                    case "Recharge":
                        Recharge(heroes, tokens, name, MAX_MP);
                        break;
                    case "Heal":
                        Heal(heroes, tokens, name, MAX_HP);
                        break;
                }

                command = Console.ReadLine();
            }
            //"{hero name}
            //HP: { current HP}
            //MP: { current MP}

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"HP: {hero.Value.HP}");
                Console.WriteLine($"MP: {hero.Value.MP}");
            }
        }

        public static void Heal(Dictionary<string, Hero> heroes, string[] tokens, string name, int mAX_HP)
        {
            //"Heal – {hero name} – {amount}"
            //•	The hero increases his HP.If a command is given that would bring the HP of the hero above the maximum value(100), HP is increased to 100(the HP can't go over the maximum value).
            //•	 Print the following message:
            //o   "{hero name} healed for {amount recovered} HP!"
            mAX_HP = 100;
            int hpHealed = int.Parse(tokens[2]);

            if (hpHealed + heroes[name].HP > mAX_HP)
            {
                hpHealed = mAX_HP - heroes[name].HP;
            }

            heroes[name].HP += hpHealed;

            Console.WriteLine($"{name} healed for {hpHealed} HP!");
        }

        public static void Recharge(Dictionary<string, Hero> heroes, string[] tokens, string name, int MAX_MP)
        {
            //•	The hero increases his MP. If it brings the MP of the hero above the maximum value (200), MP is increased to 200. (the MP can't go over the maximum value).
            //•	 Print the following message:
            //o   "{hero name} recharged for {amount recovered} MP!"
            MAX_MP = 200;

            int mpRecharged = int.Parse(tokens[2]);

            if (mpRecharged + heroes[name].MP > MAX_MP)
            {
                mpRecharged = MAX_MP - heroes[name].MP;
            }

            heroes[name].MP += mpRecharged;

            Console.WriteLine($"{name} recharged for {mpRecharged} MP!");
        }

        public static void TakeDamage(Dictionary<string, Hero> heroes, string[] tokens, string name)
        {
            //"TakeDamage – {hero name} – {damage} – {attacker}"
            //•	Reduce the hero HP by the given damage amount.If the hero is still alive (his HP is greater than 0) print:
            //o   "{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"
            //•	If the hero has died, remove him from your party and print:
            //"{hero name} has been killed by {attacker}!"
            int damage = int.Parse(tokens[2]);
            string attacker = tokens[3];

            heroes[name].HP -= damage;

            if (heroes[name].HP > 0)
            {
                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name].HP} HP left!");
            }
            else
            {
                Console.WriteLine($"{name} has been killed by {attacker}!");
                heroes.Remove(name);
            }
        }

        public static void CastSpell(Dictionary<string, Hero> heroes, string[] tokens, string name)
        {
            //"CastSpell – {hero name} – {MP needed} – {spell name}"
            //•	If the hero has the required MP, he casts the spell, thus reducing his MP.Print this message:
            //"{hero name} has successfully cast {spell name} and now has {mana points left} MP!"
            //•	If the hero is unable to cast the spell print:
            //"{hero name} does not have enough MP to cast {spell name}!"
            int mpUsed = int.Parse(tokens[2]);
            string spellName = tokens[3];

            if (mpUsed > heroes[name].MP)
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
            }
            else
            {
                heroes[name].MP -= mpUsed;

                Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name].MP} MP!");
            }


        }
    }
    class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
