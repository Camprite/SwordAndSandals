using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic
{
    public class BattleController
    {

        public Warrior Player { get; set; }
        public Warrior Bot { get; set; }


        public const int MoveStep = 10;
        public const int AttackRange = 400;
        public bool isPlayerTurn { get; set; } = true;

        public int TotalDamage = 0;
        public int AdditionalDefence = 0;


        public BattleController()
        {
            this.isPlayerTurn = true;

        }

        public bool CanAttack(Point PlayerPos, Point BotPos)
        {
            return Math.Abs(PlayerPos.X - BotPos.X) <= AttackRange;
        }
        public void heal(bool IsPlayerTurn, int heal)
        {
            Warrior Entity = Bot;

            if (isPlayerTurn)
            {
                Entity = Player;

            }
            if (Entity.ActualHealth + heal > Entity.MaxHealth)
            {
                Entity.ActualHealth = Entity.MaxHealth;
            }
            else
            {
                Entity.ActualHealth += heal;
            }



        }

        public int PlayerAttack()
        {
            if (Player.IsDead || Player.ActualStamina < 10) return 0;

            //int botDefence = getDefence(Bot);
            //int playerDamage = Player.Damage();
            //int realDamage = playerDamage * (botDefence/10);

            int damage = getRealDamage(true);
            TotalDamage += damage;

            Player.ActualStamina -= 10;

            return Bot.TakeDamage(damage);
        }
        public void addPlayerDefence(int defence)
        {
            this.AdditionalDefence += defence;

        }
        public int PlayerMagicAttack(int damage)
        {
            if (Player.IsDead || Player.ActualStamina < 10) return 0;

            TotalDamage += damage;
            Bot.TakeDamage(damage);
            Player.ActualStamina -= 10;
            return damage;
        }

        public int BotAttack()
        {
            if (Bot.IsDead || Bot.ActualStamina < 10) return 0;

            int damage = getRealDamage(false);
            if (this.AdditionalDefence > 0)
            {
                damage = getDamagedamageAfterAdditionalDefence(damage);
            }
            

            Bot.ActualStamina -= 10;

            return Player.TakeDamage(damage); 
        }
        public int getRealDamage(bool IsPlayerTurn)
        {
            int Defence;
            int Damage;

            if (IsPlayerTurn)
            {
                Defence = getDefence(Bot);
                Damage = Player.Damage();
            }
            else
            {
                Defence = getDefence(Player); //4
                Damage = Bot.Damage(); //4
            }

            int realDamage = Damage - Defence/2;
            if(realDamage <= 1) return 1;

            return realDamage;
        } 
        public int getDamagedamageAfterAdditionalDefence(int Damage)
        {
       
            return Damage - this.AdditionalDefence/4;
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

        public int CheckFightStatus()
        {
            if (Player.IsDead)
            {
                return -1;
            }
            else if (Bot.IsDead)
            {
                Player.WinsCounter++;
                return 1;
            }
            return 0;

        }

        public int Rest(Warrior warrior)
        {
            warrior.ActualStamina = Math.Min(warrior.ActualStamina + 30, warrior.MaxStamina);

            return warrior.ActualStamina;
        }

        public void EndPlayerTurn()
        {
            isPlayerTurn = false;

        }
        public int getDefence(Warrior entity)
        {
            int defenceFactor = 1;
            if (entity.Shield != null) { defenceFactor += entity.Shield.Defence; };
            if (entity.Helmet != null) { defenceFactor += entity.Helmet.Defence; };
            if (entity.Chestplate != null) { defenceFactor += entity.Chestplate.Defence; };
            if (entity.Boots != null) { defenceFactor += entity.Boots.Defence; };

          
            if(defenceFactor < 1)
            {
                return 1;
            }
            return defenceFactor;
        }



    }
}
