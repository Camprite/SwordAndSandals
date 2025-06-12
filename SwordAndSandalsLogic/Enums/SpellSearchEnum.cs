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

        [Description("By Type")]
        ByType = 1,

        [Description("Avaiable by level")]
        AvaiableByLevel = 2,

        [Description("Avaiable by price")]
        AvaiableByPrice = 3,

        [Description("Avaiable by price and level")]
        AvaiableByPriceAndLevel = 4,

        [Description("Avaiable by type")]
        AvaiableAndByType = 5,



    }
}
