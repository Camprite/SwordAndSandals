using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class Armour
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ArmourEnum ArmourType { get; set; }
        public int Defence { get; set; }
        public string IconPath { get; set; }
        public int Price { get; set; }

        public Armour(int id, string name, string description, ArmourEnum armourType, int defence, string iconPath, int Price)
        {
            Id = id;
            Name = name;
            Description = description;
            ArmourType = armourType;
            Defence = defence;
            this.IconPath = iconPath;
            this.Price = Price;
        }
    }
}
