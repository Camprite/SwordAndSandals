using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SwordAndSandals
{
    public static class BotFactory
    {
        private static Random random = new Random();


        public static bool CheckIfBossFight(Warrior Player)
        {
            return Player.WinsCounter > 0 && Player.WinsCounter % 2 == 0;
        }

        public static Warrior GenerateBot(Warrior Player)
        {
            bool isBossFight = CheckIfBossFight(Player); 
            if (isBossFight)
            {
                return GenerateBoss(Player);
            }
            else
            {
                return GenerateRegularBot(Player);
            }
        }

        private static Warrior GenerateRegularBot(Warrior Player)
        {
            var name = NameRepository.GetNames()[random.Next(NameRepository.GetNames().Count)];
            int strength = RandomizeStat(Player.Strenght, 0.4, 0.5);
            int agility = RandomizeStat(Player.Agility, 0.4, 0.5);
            int inteligence = RandomizeStat(Player.Int, 0.4, 0.5);
            int vitality = RandomizeStat(Player.Vitality, 0.4, 0.5);

            var weapon = GetRandomWeapon(Player.Level);
            Warrior bot = new Warrior(name, strength, agility, inteligence, vitality, CharacterEnum.Bot);
            bot.Weapon = weapon;

            return bot;
        }

        private static Warrior GenerateBoss(Warrior Player)
        {
            var name = "Boss " + NameRepository.GetNames()[random.Next(NameRepository.GetNames().Count)];
            int strength = RandomizeStat(Player.Strenght, 0.7, 1.0);
            int agility = RandomizeStat(Player.Agility, 0.7, 1.0);
            int inteligence = RandomizeStat(Player.Int, 0.7, 1.0);
            int vitality = RandomizeStat(Player.Vitality, 0.7, 1.0);

            var weapon = GetRandomWeapon(Player.Level + 1); 
            Warrior boss = new Warrior(name, strength, agility, inteligence, vitality, CharacterEnum.Bot);
            boss.Weapon = weapon;

            return boss;
        }

        private static int RandomizeStat(int value, double minMultiplier, double maxMultiplier)
        {
            double multiplier = minMultiplier + random.NextDouble() * (maxMultiplier - minMultiplier);
            int randomizedValue = (int)(value * multiplier);
            return Math.Max(1, randomizedValue);
        }

        private static Weapon GetRandomWeapon(int level)
        {
            var allWeapons = WeaponRepository.GetWeapons();
            var viableWeapons = allWeapons.Where(w => w.Lvl <= level).ToList();

            if (viableWeapons.Count == 0)
            {
                viableWeapons = allWeapons;
            }
            return viableWeapons[random.Next(viableWeapons.Count)];
        }


        /*
         * private static int RandomizeStat(int value)
        {
            double[] multipliers = { 0.5, 0.6, 0.7};
            double multiplier = multipliers[random.Next(multipliers.Length)];
            int randomizedValue = (int)(value * multiplier);
            return Math.Max(1, randomizedValue);
        }
         * */

        

    }



}
