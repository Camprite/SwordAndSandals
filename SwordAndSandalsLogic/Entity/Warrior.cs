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
            /*
            Int = inteligence;
            Strenght = strenght;
            Agility = agility;
            Vitality = vitality;
            */
            Character = character;
            Level = 0;
            XP = 0;

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

    }


}
