using SwordAndSandalsLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class Warrior : Entity
    {
        public String Name { get; set; }
        public int Money {  get; set; }
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        public List<Armour> Armours { get; set; } = new List<Armour>();
        public List<Spell> Spells { get; set; } = new List<Spell>();

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

        public int XPThreshold => 100 * (Level + 1);

        public int WinsCounter { get; set; } = 0;

       
        

        public Warrior()
        {
        }

        public List<Armour> getArmourByType(ArmourEnum armourEnum)
        {
            return Armours.Where(e => e.ArmourType == armourEnum).ToList();
        }

        public Warrior(string name, int strenght, int agility, int inteligence, int vitality, CharacterEnum character)
        {
            if (name == null || name == "" || name.Length>30) throw new WarriorBuilderException("Niepoprawna nazwa");
            this.Name = name;
            this.Strenght = strenght;
            this.Agility = agility;
            this.Int = inteligence;
            this.Vitality = vitality;
            MaxHealth = 100;
            ActualHealth = 100;
            MaxStamina = 100;
            ActualStamina = 100;
            Money = 100;
            Character = character;
            Level = 0;
            XP = 0;
            UpdateStats();
        }

        public override int Damage()
        {
            int baseDamage = Strenght; // Strength
            int weaponBonus = Weapon != null ? Weapon.Damage: 0;
            return baseDamage + weaponBonus;
        }

        public override int TakeDamage(int damage)
        {
         
            if (TryDodge())
       
            {
                Console.WriteLine($"{Name} unika ataku!");
                return 0;
            }

            //int defence = TotalArmourDefence();
            //int reducedDamage = Math.Max(damage - defence, 1);


            return base.TakeDamage(damage);
        }

        private bool TryDodge()
        {
            Random rnd = new Random();
            double dodgeChance = Agility * 0.5;
            double maxDodgeChance = 75;
            dodgeChance = Math.Min(dodgeChance, maxDodgeChance);
            return rnd.Next(0,50) < dodgeChance;
        }

        public int TotalArmourDefence()
        {
            int total = 0;
            if (this.Helmet != null) total += Helmet.Defence;
            if (this.Chestplate != null) total += Chestplate.Defence;
            if (this.Shield != null) total += Shield.Defence;
            if (this.Boots != null) total += Boots.Defence;
            if (this.Shoulderguard != null) total += Shoulderguard.Defence;
            if (this.Gauntlests != null) total += Gauntlests.Defence;
            if (this.Greaves != null) total += Greaves.Defence;
            if (this.Shinguards != null) total += Shinguards.Defence;

            return total;
        }



        public bool CanLevelUp()
        {
            return XP >= XPThreshold;
        }

        public void LevelUp()
        {
            

            while (XP >= XPThreshold)
            {
                XP -= XPThreshold;
                Level++;
            }


        }

        public override void UpdateStats()
        {
            this.MaxHealth = 100 + (Vitality * 10);
            this.ActualHealth = MaxHealth;
            this.MaxStamina = 100 + (Int * 10);
            this.ActualStamina = MaxStamina;
        }
        

    }


}
