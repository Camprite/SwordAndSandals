using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandals
{
    internal class BattleController
    {
        
        private Warrior Player;
        private Warrior Bot;
        
        
        public const int MoveStep = 10;
        public const int AttackRange = 400;
        public bool isPlayerTurn { get;  set; } = true;

        public BattleController(Warrior Player, Warrior Bot)
        {
            this.Player = Player;
            this.Bot = Bot;
            this.isPlayerTurn = true;

        }

        public bool CanAttack(Point PlayerPos, Point BotPos)
        {
            return Math.Abs(PlayerPos.X - BotPos.X) <= AttackRange;
        }

        public int PlayerAttack()
        {
            if(Player.IsDead || Player.ActualStamina < 10) return 0;

            int damage = Player.Damage();
            Bot.TakeDamage(damage);
            Player.ActualStamina -= 10;
            return damage;
        }

        public int BotAttack()
        {
            if (Bot.IsDead || Bot.ActualStamina < 10);

            int damage = Bot.Damage();
            Player.TakeDamage(damage);
            Bot.ActualStamina -= 10;

            return damage;
        }

        public Point MoveForward(Point CurrentPosition, Warrior warrior)
        {
            warrior.ActualStamina -= 10;
            return new Point(CurrentPosition.X + MoveStep, CurrentPosition.Y);
        }

        public Point MoveBackward(Point CurrentPosition, Warrior warrior)
        {
            warrior.ActualStamina -= 10;
            int newX = CurrentPosition.X - MoveStep;
            return newX >= 0 ? new Point(newX, CurrentPosition.Y) : CurrentPosition;
        }

        public string CheckFightStatus()
        {
            if (Player.IsDead)
            {
                MessageBox.Show("Przegrałeś");
                return "";
            }
            else if (Bot.IsDead)
            {
                MessageBox.Show("Wygrałeś!");
                return "";
            }
            return null;

        }

        public int Rest(Warrior warrior)
        {
            return warrior.ActualStamina += 20;
        }

        public void EndPlayerTurn()
        {
            isPlayerTurn = false;
            
        }

        





    }
}
