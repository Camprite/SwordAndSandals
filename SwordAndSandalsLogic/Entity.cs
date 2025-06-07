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
        public int Level { get; set; }
        public int XP { get; set; }
        public bool ArenaSide { get; set; } //false = left, true = right
        public int MaxHealth { get; set; }
        public int ActualHealth {  get; set; }
        public int MaxStamina { get; set; }
        public int ActualStamina { get; set; }
        public int Int{ get; set; }
        public int Strenght { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public int baseStatisticPoints { get; set; }

        public virtual int Damage()
        {
            return Strenght+1;
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

        public Entity()
        {
            

        }
        public void addPoint(StatisticsEnum stat ){
            if (this.getAvaiablePoints() > 0)
            {
                switch (stat)
                {
                    case StatisticsEnum.Strenght:
                        this.Strenght++;
                        break;
                    case StatisticsEnum.Vitality:
                        this.Vitality++;
                        break;
                    case StatisticsEnum.Agility:
                        this.Agility++;
                        break;
                    case StatisticsEnum.Inteligence:
                        this.Int++;
                        break;
                }
            }
        }

        public virtual void TakeDamage(int damage)
        {
            int realDamage = Math.Max(damage, 0);
            ActualHealth = Math.Max(ActualHealth - realDamage, 0);
        }
        public int getAvaiablePoints()
        {
            int sum = Int + Strenght + Agility + Vitality;

            return baseStatisticPoints + Level - sum;
        }

        public bool IsDead => ActualHealth <= 0;

    }
}
