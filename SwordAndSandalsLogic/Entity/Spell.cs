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
        public int Speed { get; set; } 
        public int Heal { get; set; }
        public string DisplayText => $"{Name} LVL:{Level} ${Price} Type:{Type} Mana:{Mana}";
        public int Price { get; set; }
        public Spell() { }

        public Spell(int id, string name, string description, SpellEnum type, int mana, int damage, int speed, int heal, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Mana = mana;
            Damage = damage;
            Speed = speed;
            Heal = heal;
            Price = price;
        }

        public Spell(int id, string name, string description, SpellEnum type, int mana, int damage, int speed, int heal, int price, int level)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Mana = mana;
            Damage = damage;
            Speed = speed;
            Heal = heal;
            Price = price;
            Level = level;
        }

        public override string? ToString()
        {
            return $"{Name} = {Type} = {Price}";
        }
    }
}
