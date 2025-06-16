using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class Weapon
    {
        public int Id {  get; set; }
        public int Lvl {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public WeaponEnum WeaponEnum { get; set; }
        public int xPadding { get; set; } = 0;
        public int yPadding { get; set; } = 0;
        public int Rotate {  get; set; } = 0;
        public string Path { get; set; }
        public int Price {  get; set; }
        public string DisplayText => $"{Name}\t [$]:{Price}\t [DMG]:{Damage} ";
        public string InventoryText => $"{Name} [DMG]:{Damage}";
        public int Damage {  get; set; }

        public Weapon(int id, string name, string description, WeaponEnum weaponEnum, int xPadding, 
            int yPadding, int rotate, string path, int price, int damage)
        {
            Id = id;
            Name = name;
            Description = description;
            WeaponEnum = weaponEnum;
            this.xPadding = xPadding;
            this.yPadding = yPadding;
            Rotate = rotate;
            Path = path;
            Price = price; 
            Damage = damage;

        }
        public Weapon() { }

        public override string? ToString()
        {
            return $"{Name}:{Price}:{WeaponEnum}";
        }
    }
}
