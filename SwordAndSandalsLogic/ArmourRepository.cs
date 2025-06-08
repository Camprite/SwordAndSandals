using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class ArmourRepository
    {


        public static List<Armour> GetHelmets()
        {
            var helmets = new List<Armour>();

            helmets.Add(new Armour(1, 0, "Leather Cap", "A basic leather helmet.", ArmourEnum.Helmet, 1, 8));
            helmets.Add(new Armour(6, 2, "Rough Leather Helmet", "Offers slightly more protection.", ArmourEnum.Helmet, 2, 20));
            helmets.Add(new Armour(10, 3, "Reinforced Coif", "A padded hood with leather strips.", ArmourEnum.Helmet, 3, 35));
            helmets.Add(new Armour(14, 4, "Chainmail Coif", "Covers the head in steel rings.", ArmourEnum.Helmet, 4, 55));
            helmets.Add(new Armour(18, 5, "Steel Helmet", "A common helmet for guardsmen.", ArmourEnum.Helmet, 6, 75));
            helmets.Add(new Armour(22, 6, "Visored Helmet", "A helmet with a movable visor.", ArmourEnum.Helmet, 8, 95));
            helmets.Add(new Armour(26, 7, "Great Helm", "Fully encloses the head.", ArmourEnum.Helmet, 10, 120));
            helmets.Add(new Armour(30, 8, "Royal Guard Helmet", "Adorned with intricate designs.", ArmourEnum.Helmet, 12, 145));
            helmets.Add(new Armour(34, 9, "Horned Helmet", "A fearsome looking helmet.", ArmourEnum.Helmet, 14, 170));
            helmets.Add(new Armour(38, 10, "Crown of the Ancients", "A helm blessed by forgotten deities.", ArmourEnum.Helmet, 16, 195));

            return helmets;
        }

        public static List<Armour> GetShields()
        {
            var shields = new List<Armour>();
            shields.Add(new Armour(3, 0, "Wooden Buckler", "A small, wooden shield.", ArmourEnum.Shield, 1, 12));
            shields.Add(new Armour(7, 2, "Small Wooden Shield", "A sturdy small shield.", ArmourEnum.Shield, 2, 28));
            shields.Add(new Armour(11, 3, "Iron-rimmed Shield", "A shield with a metal edge.", ArmourEnum.Shield, 3, 45));
            shields.Add(new Armour(15, 4, "Round Iron Shield", "A classic, reliable shield.", ArmourEnum.Shield, 4, 65));
            shields.Add(new Armour(19, 5, "Tower Shield", "Large and offers great coverage.", ArmourEnum.Shield, 6, 85));
            shields.Add(new Armour(23, 6, "Kite Shield", "Designed for cavalry, but effective on foot.", ArmourEnum.Shield, 8, 105));
            shields.Add(new Armour(27, 7, "Heater Shield", "A classic shield for knights.", ArmourEnum.Shield, 10, 130));
            shields.Add(new Armour(31, 8, "Guardian's Aegis", "A heavy, reinforced shield.", ArmourEnum.Shield, 12, 155));
            shields.Add(new Armour(35, 9, "Vanguard's Shield", "A shield for those leading the charge.", ArmourEnum.Shield, 14, 180));
            shields.Add(new Armour(39, 10, "Bulwark of Heroes", "A massive shield, near impenetrable.", ArmourEnum.Shield, 16, 210));

            return shields;
        }

        public static List<Armour> GetBoots()
        {
            var boots = new List<Armour>();
            boots.Add(new Armour(4, 0, "Worn Boots", "Simple, scuffed boots.", ArmourEnum.Boots, 1, 7));
            boots.Add(new Armour(8, 2, "Leather Boots", "Comfortable and light.", ArmourEnum.Boots, 2, 18));
            boots.Add(new Armour(12, 3, "Reinforced Leather Boots", "Sturdy boots for adventurers.", ArmourEnum.Boots, 3, 32));
            boots.Add(new Armour(16, 4, "Iron-plated Boots", "Heavy but protective.", ArmourEnum.Boots, 3, 48));
            boots.Add(new Armour(20, 5, "Heavy Steel Boots", "Provides solid protection to feet.", ArmourEnum.Boots, 5, 70));
            boots.Add(new Armour(24, 6, "Greaves and Sabatons", "Protection for shins and feet.", ArmourEnum.Boots, 7, 90));
            boots.Add(new Armour(28, 7, "Crusader's Boots", "Strong and durable for long journeys.", ArmourEnum.Boots, 9, 115));
            boots.Add(new Armour(32, 8, "Boots of Fortitude", "Imbued with minor protective spells.", ArmourEnum.Boots, 11, 140));
            boots.Add(new Armour(36, 9, "Adept's Footguards", "Allows for quick movement.", ArmourEnum.Boots, 13, 165));
            boots.Add(new Armour(40, 10, "Boots of the Trailblazer", "Increases movement speed slightly.", ArmourEnum.Boots, 15, 190));

            return boots;
        }

        public static List<Armour> GetChestplates()
        {
            var chestplates = new List<Armour>();
            chestplates.Add(new Armour(1, 0, "Ragged Tunic", "A simple, worn tunic.", ArmourEnum.Chestplate, 1, 10));
            chestplates.Add(new Armour(5, 2, "Padded Vest", "Provides light protection.", ArmourEnum.Chestplate, 2, 25));
            chestplates.Add(new Armour(9, 3, "Hardened Leather Chestplate", "Good protection for its weight.", ArmourEnum.Chestplate, 3, 40));
            chestplates.Add(new Armour(13, 4, "Chainmail Hauberk", "Links of steel provide defense.", ArmourEnum.Chestplate, 5, 60));
            chestplates.Add(new Armour(17, 5, "Splint Mail Chestplate", "Strips of metal riveted to leather.", ArmourEnum.Chestplate, 7, 80));
            chestplates.Add(new Armour(21, 6, "Plate Cuirass", "A solid piece of forged steel.", ArmourEnum.Chestplate, 9, 100));
            chestplates.Add(new Armour(25, 7, "Knight's Chestplate", "Polished and expertly crafted.", ArmourEnum.Chestplate, 11, 125));
            chestplates.Add(new Armour(29, 8, "Tempered Steel Plate", "Heat-treated for superior defense.", ArmourEnum.Chestplate, 13, 150));
            chestplates.Add(new Armour(33, 9, "Dragonscale Vest", "Light yet incredibly strong.", ArmourEnum.Chestplate, 15, 175));
            chestplates.Add(new Armour(37, 10, "Mythril Chainmail", "Lightweight and immensely strong.", ArmourEnum.Chestplate, 18, 200));

            return chestplates;
        }
    }
}


