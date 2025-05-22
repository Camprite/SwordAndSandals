using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    internal class Entity
    {
        public int Id { get; set; }
        public int XPos { get; set; }
        public bool ArenaSide { get; set; } //false = left, true = right
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Int { get; set; }
        public int Strenght { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }

        public virtual int Damage()
        {
            return Strenght;
        }

        public Entity(int id, int xPos, bool arenaSide, int health, int stamina, int @int, int strenght, int agility, int vitality)
        {
            Id = id;
            XPos = xPos;
            ArenaSide = arenaSide;
            Health = health;
            Stamina = stamina;
            Int = @int;
            Strenght = strenght;
            Agility = agility;
            Vitality = vitality;
        }

        public virtual void LevelUp()
        {
            
        }
    }
}
