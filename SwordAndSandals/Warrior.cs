using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    internal class Warrior : Entity
    {
        

        public String Name { get; set; }
        public Weapon Weapon { get; set; }
        public Armour Helmet { get; set; }
        public Armour Chestplate { get; set; }
        public Armour Shield { get; set; }
        public Armour Boots { get; set; }
        public Armour Shoulderguard { get; set; }
        public Armour Gauntlests { get; set; }
        public Armour Greaves { get; set; }
        public Armour Shinguards { get; set; }

        public Warrior(string name, Weapon weapon, Armour helmet, Armour chestplate,
            Armour shield, Armour boots, Armour shoulderguard, Armour gauntlests,
            Armour greaves, Armour shinguards):base(1,0,false,100,50,1,1,1,1)
        {
            Name = name;
            Weapon = weapon;
            Helmet = helmet;
            Chestplate = chestplate;
            Shield = shield;
            Boots = boots;
            Shoulderguard = shoulderguard;
            Gauntlests = gauntlests;
            Greaves = greaves;
            Shinguards = shinguards;
        }
    }


}
