using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class Entity
    {
        public int Id { get; set; }
        public int XPos { get; set; }
        public bool ArenaSide { get; set; } //false = left, true = right
        public int MaxHealth { get; set; }
        public int ActualHealth {  get; set; }
        public int MaxStamina { get; set; }
        public int ActualStamina { get; set; }
        public int Int { get; set; }
        public int Strenght { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }

        public virtual int Damage()
        {
            return Strenght;
        }

        public Entity(int id, int xPos, bool arenaSide, int maxhealth, int actualhealth, int maxstamina, int actualstamina, int @int, int strenght, int agility, int vitality)
        {
            Id = id;
            XPos = xPos;
            ArenaSide = arenaSide;
            MaxHealth = maxhealth;
            ActualHealth = actualhealth;
            MaxStamina = maxstamina;
            ActualStamina = actualstamina;
            Int = @int;
            Strenght = strenght;
            Agility = agility;
            Vitality = vitality;
        }

        public virtual void TakeDamage(int damage)
        {
            int realDamage = Math.Max(damage, 0);
            ActualHealth = Math.Max(ActualHealth - realDamage, 0);
        }

        public bool IsDead => ActualHealth <= 0;

    }
}
