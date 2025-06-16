using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public enum WeaponSearchEnum
    {
        [Description("All weapons")]
        AllWeapons = 0,

        //[Description("Weapons avaiable by level")]
        //WeaponsAvaiableByLevel = 1,

        [Description("Weapons avaiable by price")]
        WeaponsAvaiableByPrice = 2,

        //[Description("Weapons avaiable by price and level")]
        //WeaponsAvaiableByPriceAndLevel = 3,

        [Description("Weapons by type")]
        WeaponsByType = 4,
    }
}
