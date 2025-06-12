using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    public class BattleResult
    {
        public int EarnedXP { get; set; }
        public int EarnedMoney { get; set; }
        public int TotalDamage { get; set; }

        public BattleResult(int xp, int money, int totalDamage)
        {
            EarnedXP = xp;
            EarnedMoney= money;
            TotalDamage = totalDamage;
        }
    }
}
