using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public enum ArmourSearchEnum
    {
        [Description("All")]
        All = 0,

        //[Description("Avaiable by level")]
        //AvaiableByLevel = 1,

        [Description("Avaiable by price")]
        AvaiableByPrice = 2,

        //[Description("Avaiable by price and level")]
        //AvaiableByPriceAndLevel = 3,

        [Description("Not avaiable")]
        NotAvaiable = 4,

        [Description("By defence")]
        ByDefence = 5,

      
    }
}
