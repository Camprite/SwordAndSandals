using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    internal class Weapon
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public WeaponEnum WeaponEnum { get; set; }
        public int xPadding { get; set; } = 0;
        public int yPadding { get; set; } = 0;
        public int Rotate {  get; set; } = 0;
        public string Path { get; set; }

        public Weapon(int id, string name, string description, WeaponEnum weaponEnum, int xPadding, 
            int yPadding, int rotate, string path)
        {
            Id = id;
            Name = name;
            Description = description;
            WeaponEnum = weaponEnum;
            this.xPadding = xPadding;
            this.yPadding = yPadding;
            Rotate = rotate;
            Path = path;
        }
    }
}
