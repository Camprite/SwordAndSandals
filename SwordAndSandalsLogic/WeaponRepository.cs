using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public static class WeaponRepository
    {
      
     
        public static List<Weapon> GetWeapons() {
            var weapons = new List<Weapon>();

            // Level 1-5 Weapons
            weapons.Add(new Weapon() { Id = 1, Lvl = 0, Name = "Cracked Dagger", Price = 8, Damage = 4, WeaponEnum = WeaponEnum.Daggers });
            weapons.Add(new Weapon() { Id = 2, Lvl = 1, Name = "Rough Cudgel", Price = 10, Damage = 6, WeaponEnum = WeaponEnum.Mele });
            weapons.Add(new Weapon() { Id = 3, Lvl = 2, Name = "Rusty Shortsword", Price = 20, Damage = 9, WeaponEnum = WeaponEnum.Sword });
            weapons.Add(new Weapon() { Id = 4, Lvl = 2, Name = "Chipped Hand Axe", Price = 22, Damage = 10, WeaponEnum = WeaponEnum.Axe });
            weapons.Add(new Weapon() { Id = 5, Lvl = 3, Name = "Basic Knuckles", Price = 15, Damage = 7, WeaponEnum = WeaponEnum.Box });
            weapons.Add(new Weapon() { Id = 6, Lvl = 3, Name = "Honed Daggers", Price = 30, Damage = 12, WeaponEnum = WeaponEnum.Daggers });
            weapons.Add(new Weapon() { Id = 7, Lvl = 4, Name = "Adventurer's Mace", Price = 35, Damage = 14, WeaponEnum = WeaponEnum.Mele });
            weapons.Add(new Weapon() { Id = 8, Lvl = 4, Name = "Soldier's Broadsword", Price = 45, Damage = 16, WeaponEnum = WeaponEnum.Sword });
            weapons.Add(new Weapon() { Id = 9, Lvl = 5, Name = "Sturdy Battle Axe", Price = 50, Damage = 18, WeaponEnum = WeaponEnum.Axe });
            weapons.Add(new Weapon() { Id = 10, Lvl = 5, Name = "Steel Gauntlets", Price = 40, Damage = 15, WeaponEnum = WeaponEnum.Box });

            // Level 6-10 Weapons
            weapons.Add(new Weapon() { Id = 11, Lvl = 6, Name = "Swift Stilettos", Price = 60, Damage = 20, WeaponEnum = WeaponEnum.Daggers });
            weapons.Add(new Weapon() { Id = 12, Lvl = 6, Name = "Warrior's Hammer", Price = 65, Damage = 22, WeaponEnum = WeaponEnum.Mele });
            weapons.Add(new Weapon() { Id = 13, Lvl = 7, Name = "Knight's Longsword", Price = 80, Damage = 25, WeaponEnum = WeaponEnum.Sword });
            weapons.Add(new Weapon() { Id = 14, Lvl = 7, Name = "Viking Handaxe", Price = 85, Damage = 27, WeaponEnum = WeaponEnum.Axe });
            weapons.Add(new Weapon() { Id = 15, Lvl = 8, Name = "Spiked Cestus", Price = 70, Damage = 23, WeaponEnum = WeaponEnum.Box });
            weapons.Add(new Weapon() { Id = 16, Lvl = 8, Name = "Shadowstrike Daggers", Price = 90, Damage = 26, WeaponEnum = WeaponEnum.Daggers });
            weapons.Add(new Weapon() { Id = 17, Lvl = 9, Name = "Templar's Flail", Price = 95, Damage = 28, WeaponEnum = WeaponEnum.Mele });
            weapons.Add(new Weapon() { Id = 18, Lvl = 9, Name = "Greatsword of Valor", Price = 110, Damage = 30, WeaponEnum = WeaponEnum.Sword });
            weapons.Add(new Weapon() { Id = 19, Lvl = 10, Name = "Berserker's Greataxe", Price = 120, Damage = 33, WeaponEnum = WeaponEnum.Axe });
            weapons.Add(new Weapon() { Id = 20, Lvl = 10, Name = "Ornate Gauntlets", Price = 100, Damage = 29, WeaponEnum = WeaponEnum.Box });

            // Level 11-15 Weapons
            weapons.Add(new Weapon() { Id = 21, Lvl = 11, Name = "Blades of the Assassin", Price = 130, Damage = 35, WeaponEnum = WeaponEnum.Daggers });
            weapons.Add(new Weapon() { Id = 22, Lvl = 11, Name = "Crushing Warclub", Price = 135, Damage = 37, WeaponEnum = WeaponEnum.Mele });
            weapons.Add(new Weapon() { Id = 23, Lvl = 12, Name = "Rune-etched Blade", Price = 150, Damage = 40, WeaponEnum = WeaponEnum.Sword });
            weapons.Add(new Weapon() { Id = 24, Lvl = 12, Name = "Obsidian Chopper", Price = 160, Damage = 42, WeaponEnum = WeaponEnum.Axe });
            weapons.Add(new Weapon() { Id = 25, Lvl = 13, Name = "Titan's Fists", Price = 140, Damage = 38, WeaponEnum = WeaponEnum.Box });
            weapons.Add(new Weapon() { Id = 26, Lvl = 13, Name = "Poisoned Daggers", Price = 170, Damage = 40, WeaponEnum = WeaponEnum.Daggers });
            weapons.Add(new Weapon() { Id = 27, Lvl = 14, Name = "Celestial Warhammer", Price = 180, Damage = 45, WeaponEnum = WeaponEnum.Mele });
            weapons.Add(new Weapon() { Id = 28, Lvl = 14, Name = "Sunstone Greatsword", Price = 200, Damage = 48, WeaponEnum = WeaponEnum.Sword });
            weapons.Add(new Weapon() { Id = 29, Lvl = 15, Name = "Inferno Axe", Price = 210, Damage = 50, WeaponEnum = WeaponEnum.Axe });
            weapons.Add(new Weapon() { Id = 30, Lvl = 15, Name = "Dragonhide Gauntlets", Price = 190, Damage = 46, WeaponEnum = WeaponEnum.Box });

            // Level 16-20 Weapons
            weapons.Add(new Weapon() { Id = 31, Lvl = 16, Name = "Soulshaper Daggers", Price = 220, Damage = 52, WeaponEnum = WeaponEnum.Daggers });
            weapons.Add(new Weapon() { Id = 32, Lvl = 16, Name = "Grave Smasher", Price = 230, Damage = 55, WeaponEnum = WeaponEnum.Mele });
            weapons.Add(new Weapon() { Id = 33, Lvl = 17, Name = "Blade of the Ancients", Price = 250, Damage = 58, WeaponEnum = WeaponEnum.Sword });
            weapons.Add(new Weapon() { Id = 34, Lvl = 17, Name = "Worldbreaker Axe", Price = 260, Damage = 60, WeaponEnum = WeaponEnum.Axe });
            weapons.Add(new Weapon() { Id = 35, Lvl = 18, Name = "Unbreakable Fists", Price = 240, Damage = 56, WeaponEnum = WeaponEnum.Box });
            weapons.Add(new Weapon() { Id = 36, Lvl = 18, Name = "Whisperwind Daggers", Price = 270, Damage = 62, WeaponEnum = WeaponEnum.Daggers });
            weapons.Add(new Weapon() { Id = 37, Lvl = 19, Name = "Thunderclap Hammer", Price = 280, Damage = 65, WeaponEnum = WeaponEnum.Mele });
            weapons.Add(new Weapon() { Id = 38, Lvl = 19, Name = "Starforged Longsword", Price = 300, Damage = 68, WeaponEnum = WeaponEnum.Sword });
            weapons.Add(new Weapon() { Id = 39, Lvl = 20, Name = "Axe of the Apocalypse", Price = 320, Damage = 70, WeaponEnum = WeaponEnum.Axe });
            weapons.Add(new Weapon() { Id = 40, Lvl = 20, Name = "Fists of Fury", Price = 300, Damage = 65, WeaponEnum = WeaponEnum.Box });


            return weapons;
        }
    }
}
