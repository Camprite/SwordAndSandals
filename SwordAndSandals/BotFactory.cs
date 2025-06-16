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
         
            return GenerateRegularBot(Player);
        }

        private static Warrior GenerateRegularBot(Warrior Player)
        {
            var name = NameRepository.GetNames()[random.Next(NameRepository.GetNames().Count)];
            int strength = RandomizeStat(Player.Strenght, 0.7, 0.8);
            int agility = RandomizeStat(Player.Agility, 0.7, 0.8);
            int inteligence = RandomizeStat(Player.Int, 0.7, 0.8);
            int vitality = RandomizeStat(Player.Vitality, 0.7, 0.8);

            Warrior bot = new Warrior(name, strength, agility, inteligence, vitality, CharacterEnum.Bot);

            bot.Weapon = GetRandomWeapon(Player.Level);

            
            EquipRandomArmour(bot, Player.Level, 0.75); 

            return bot;
        }

        private static Warrior GenerateBoss(Warrior Player)
        {
            var name = "Boss " + NameRepository.GetNames()[random.Next(NameRepository.GetNames().Count)];
            int strength = RandomizeStat(Player.Strenght, 1.0, 1.5);
            int agility = RandomizeStat(Player.Agility, 1.0, 1.5);
            int inteligence = RandomizeStat(Player.Int, 1.0, 1.5);
            int vitality = RandomizeStat(Player.Vitality, 1.0, 1.5);

            Warrior boss = new Warrior(name, strength, agility, inteligence, vitality, CharacterEnum.Bot);

            boss.Weapon = GetRandomWeapon(Player.Level + 1);

           
            EquipRandomArmour(boss, Player.Level + 1, 1.0);

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
                if (viableWeapons.Count == 0) return null;
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
                if (viableBoots.Count == 0) return null;
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

      
        private static void EquipRandomArmour(Warrior bot, int level, double chanceToEquip)
        {
           
            List<ArmourEnum> armourTypes = new List<ArmourEnum>
            {
                ArmourEnum.Helmet,
                ArmourEnum.Chestplate,
                ArmourEnum.Shield,
                ArmourEnum.Boots
              
            };

            foreach (var armourType in armourTypes)
            {
                if (random.NextDouble() < chanceToEquip)
                {
                    Armour randomArmour = null;

                    switch (armourType)
                    {
                        case ArmourEnum.Helmet:
                            randomArmour = GetRandomHelmet(level);
                            break;
                        case ArmourEnum.Chestplate:
                            randomArmour = GetRandomChestplate(level);
                            break;
                        case ArmourEnum.Shield:
                            randomArmour = GetRandomShield(level);
                            break;
                        case ArmourEnum.Boots:
                            randomArmour = GetRandomBoot(level);
                            break;
                        
                        default:
                            break; 
                    }

                    if (randomArmour != null)
                    {
                        
                        switch (armourType)
                        {
                            case ArmourEnum.Helmet:
                                bot.Helmet = randomArmour;
                                break;
                            case ArmourEnum.Chestplate:
                                bot.Chestplate = randomArmour;
                                break;
                            case ArmourEnum.Shield:
                                bot.Shield = randomArmour;
                                break;
                            case ArmourEnum.Boots:
                                bot.Boots = randomArmour;
                                break;
                           
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }


}
