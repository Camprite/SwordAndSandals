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

        public static Warrior GenerateBot(Warrior Player)
        {
            var name = NameRepository.GetNames()[random.Next(NameRepository.GetNames().Count)];
            int strength = RandomizeStat(Player.Strenght);
            int agility = RandomizeStat(Player.Agility);
            int inteligence = RandomizeStat(Player.Int);
            int vitality = RandomizeStat(Player.Vitality);

            var weapon = GetRandomWeapon(Player.Level);
            var bot = new Warrior(name, strength, agility, inteligence, vitality, CharacterEnum.Bot);
            
            bot.Weapon = weapon;

            return bot;
        
        }


        private static int RandomizeStat(int value, int deviation = 2)
        {
            return Math.Max(1, value + random.Next(-deviation, deviation + 1));
        }

        private static Weapon GetRandomWeapon(int level)
        {
            var allWeapons = WeaponRepository.GetWeapons();

            var viableWeapons = allWeapons.Where(w => w.Lvl <= level + 1).ToList();

            if (viableWeapons.Count == 0)
            {
                viableWeapons = allWeapons;
            }
            return viableWeapons[random.Next(viableWeapons.Count)];

        }

    }



}
