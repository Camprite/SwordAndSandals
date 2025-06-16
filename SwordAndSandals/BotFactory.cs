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



            Warrior bot = new Warrior(name, strength, agility, inteligence, vitality, CharacterEnum.Bot);
            bot.Weapon = GetRandomWeapon(Player.Level);
            bot.Boots = GetRandomBoot(Player.Level);
            bot.Helmet = GetRandomHelmet(Player.Level);
            bot.Chestplate = GetRandomChestplate(Player.Level);
            bot.Shield = GetRandomShield(Player.Level);

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

        private static Armour GetRandomBoot(int level)
        {
            var allBoots = ArmourRepository.GetBoots();
            var viableBoots = allBoots.Where(b => b.Level <= level).ToList();
            if (viableBoots.Count == 0)
            {
                viableBoots = allBoots;
            }
            return viableBoots[random.Next(viableBoots.Count)];
        }

        private static Armour GetRandomHelmet(int level)
        {
            var allHelmets = ArmourRepository.GetHelmets();
            var viableHelmets = allHelmets.Where(h => h.Level <= level).ToList();
            if (viableHelmets.Count == 0)
            {
                viableHelmets = allHelmets;
                if (viableHelmets.Count == 0) return null;
            }
            return viableHelmets[random.Next(viableHelmets.Count)];
        }

        private static Armour GetRandomChestplate(int level)
        {
            var allChestplates = ArmourRepository.GetChestplates();
            var viableChestplates = allChestplates.Where(c => c.Level <= level).ToList();
            if (viableChestplates.Count == 0)
            {
                viableChestplates = allChestplates;
                if (viableChestplates.Count == 0) return null;
            }
            return viableChestplates[random.Next(viableChestplates.Count)];
        }

        private static Armour GetRandomShield(int level)
        {
            var allShields = ArmourRepository.GetShields();
            var viableShields = allShields.Where(s => s.Level <= level).ToList();
            if (viableShields.Count == 0)
            {
                viableShields = allShields;
                if (viableShields.Count == 0) return null;
            }
            return viableShields[random.Next(viableShields.Count)];
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
