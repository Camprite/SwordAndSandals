using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic.Enums
{
    public enum SpellSearchEnum
    {
        [Description("All")]
        All = 0,

        [Description("Avaiable by level")]
        AvaiableByLevel = 1,

        [Description("Avaiable by price")]
        AvaiableByPrice = 2,

        [Description("Avaiable by price and level")]
        AvaiableByPriceAndLevel = 3,

        [Description("Avaiable Offensive")]
        AvaiableOffensive = 4,

        [Description("Avaiable Defensive")]
        AvaiableDefensive = 5,

        [Description("Avaiable Healing")]
        AvaiableHealing = 6,

    }
}
