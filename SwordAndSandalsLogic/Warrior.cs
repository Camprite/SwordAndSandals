﻿using SwordAndSandalsLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class Warrior : Entity
    {
        
        public String Name { get; set; }
        public int Money {  get; set; }
        public Weapon Weapon { get; set; }
        public Armour Helmet { get; set; }
        public Armour Chestplate { get; set; }
        public Armour Shield { get; set; }
        public Armour Boots { get; set; }
        public Armour Shoulderguard { get; set; }
        public Armour Gauntlests { get; set; }
        public Armour Greaves { get; set; }
        public Armour Shinguards { get; set; }
        public CharacterEnum Character { get; set; }

        public Warrior(string name, int money, Weapon weapon, Armour helmet, Armour chestplate,
            Armour shield, Armour boots, Armour shoulderguard, Armour gauntlests,
            Armour greaves, Armour shinguards, CharacterEnum character, int strenght, int agility,int Int, int vitality) 
            : base(1, 0, false, 100, 100, 50, 50, strenght, agility, Int, vitality)
        {
            Name = name;
            Money = money;
            Weapon = weapon;
            Helmet = helmet;
            Chestplate = chestplate;
            Shield = shield;
            Boots = boots;
            Shoulderguard = shoulderguard;
            Gauntlests = gauntlests;
            Greaves = greaves;
            Shinguards = shinguards;
            Character = character;
        }

        public Warrior()
        {
        }

        public Warrior(string name, int strenght, int agility, int inteligence, int vitality)
        {
            if (name == null || name == "" || name.Length>30) throw new WarriorBuilderException("Niepoprawna nazwa");
            this.Name = name;
            this.Strenght = strenght;
            this.Agility = agility;
            this.Int = inteligence;
            this.Vitality = vitality;

        }

        public override int Damage()
        {
            int baseDamage = base.Damage(); // Strength
            int weaponBonus = Weapon != null ? Weapon.Damage: 0;
            return baseDamage + weaponBonus;
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
        }

    }


}
