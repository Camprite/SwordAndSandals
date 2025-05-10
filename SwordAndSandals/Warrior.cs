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
    }
}
