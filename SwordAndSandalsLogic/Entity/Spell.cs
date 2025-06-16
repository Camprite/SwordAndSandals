using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class Spell
    {
        public int Id {  get; set; }
        public int Level {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SpellEnum Type { get; set; }
        public int Mana {  get; set; }
        public int Damage { get; set; }
        public int Defence { get; set; } 
        public int Heal { get; set; }
        public string DisplayText => $"{Name}\t [LVL]:{Level}\t [$]{Price}\t [M]:{Mana}\t {this.shopText()}";
        public string BattleText => $"{comboBoxText()}";
        public int Price { get; set; }
        public Spell() { }

        public Spell(int id, string name, string description, SpellEnum type, int mana, int damage, int defence, int heal, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Mana = mana;
            Damage = damage;
            Defence = defence;
            Heal = heal;
            Price = price;
        }

        public Spell(int id, string name, string description, SpellEnum type, int mana, int damage, int defence, int heal, int price, int level)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Mana = mana;
            Damage = damage;
            Defence = defence;
            Heal = heal;
            Price = price;
            Level = level;
        }
        public string comboBoxText()
        {
            switch (this.Type)
            {
                case SpellEnum.Defensive:
                    return $"[D]{Name}\t [M]{Mana}\t [DEF] {Defence}";
                case SpellEnum.Offensive:
                    return $"[O]{Name}\t [M]{Mana}\t [DMG] {Damage}";
                case SpellEnum.Healing:
                    return $"[H]{Name}\t [M]{Mana}\t [HP] {Heal}";
            }

            return $"Error with id {Id}";
        }
        public string shopText()
        {
            switch (this.Type)
            {
                case SpellEnum.Defensive:
                    return $"[DEF] {Defence}";
                case SpellEnum.Offensive:
                    return $"[DMG] {Damage}";
                case SpellEnum.Healing:
                    return $"[HP] {Heal}";
            }

            return $"Error with id {Id}";
        }
        public override string? ToString()
        {
            return $"{Name} = {Type} = {Price}";
        }
    }
}
