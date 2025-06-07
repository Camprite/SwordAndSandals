using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public interface IWarriorItem
    {
        void addToCart();
        void removeFromCart();

        void addToPlayer();
    }
}
