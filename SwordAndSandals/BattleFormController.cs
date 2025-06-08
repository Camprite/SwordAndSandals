using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;


namespace SwordAndSandals
{
   public class BattleFormController
    {
        private Timer animationTimer;
        private const int MoveStep = 20;
        public delegate void BattleAction();
        public BattleAction OnAttack;
        public BattleAction OnRest;
        public BattleAction OnMoveForward;
        public BattleAction OnMoveBackward;
        public BattleForm BattleForm { get;set; }

        public BattleController BattleController;
        public Menu menu;


        public BattleFormController(BattleForm battleForm)
        {
            this.BattleForm = battleForm;
            InitilizeBattleFormControls();
        }
       
        public BattleFormController()
        {
            

        }


        public void InitilizeBattleFormControls()
        {
            BattleForm.labelLeftWarrior.Text = BattleController.Player.Name;
            BattleForm.pbLeftHP.Minimum = 0;
            BattleForm.pbLeftHP.Maximum = BattleController.Player.MaxHealth;
            BattleForm.pbLeftHP.Value = BattleController.Player.ActualHealth;
            BattleForm.pbLeftMana.Minimum = 0;
            BattleForm.pbLeftMana.Maximum = BattleController.Player.MaxStamina;
            BattleForm.pbLeftMana.Value = BattleController.Player.ActualStamina;

            OnAttack = HandlePlayerAttack;
            OnRest = HandlePlayerRest;
            OnMoveForward = HandleMoveForward;
            OnMoveBackward = HandleMoveBackward;

            BattleForm.btnLeftAtack.Click += (s, e) => OnAttack?.Invoke();
            BattleForm.btnLeftRest.Click += (s, e) => OnRest?.Invoke();
            BattleForm.btnLeftForward.Click += (s, e) => OnMoveForward?.Invoke();
            BattleForm.btnLeftBack.Click += (s, e) => OnMoveBackward?.Invoke();

            //added

            BattleForm.labelRightWarrior.Text = BattleController.Bot.Name;
            BattleForm.pbRightHP.Minimum = 0;
            BattleForm.pbRightHP.Maximum = BattleController.Bot.MaxHealth;
            BattleForm.pbRightHP.Value = BattleController.Bot.ActualHealth;
            BattleForm.pbRightMana.Minimum = 0;
            BattleForm.pbRightMana.Maximum = BattleController.Bot.MaxStamina;
            BattleForm.pbRightMana.Value = BattleController.Bot.ActualStamina;
            BattleForm.btnRightAtack.Visible = false;
            BattleForm.btnRightRest.Visible = false;
            BattleForm.btnRightForward.Visible = false;
            BattleForm.btnEightBack.Visible = false;
            BattleForm.btnRightUse.Visible = false;
            BattleForm.cmbboxRightSpell.Visible = false;
            BattleForm.labelSpelRight.Visible = false;
        }

       
        private void HandlePlayerAttack()
        {
            if (!BattleController.isPlayerTurn) return;

            if (BattleController.Player.ActualStamina < 10)
            {
                HandlePlayerRest();
                BattleController.EndPlayerTurn();
            }

            if (!BattleController.CanAttack(BattleForm.panelLeftWarrior.Location, BattleForm.panelRightWarrior.Location))
            {
                BattleForm.ConsoleTextBox.AppendText("[P] Jesteś za daleko, aby zaatakować! \n");
                //MessageBox.Show("Jesteś za daleko, aby zaatakować!");
                return;
            }

            

            int Damage = BattleController.PlayerAttack();

            UpdateHealthBar(BattleController.Bot);
            BattleForm.ConsoleTextBox.AppendText($"[P] Zadałeś przeciwnikowi: {Damage} obrażeń \n");
            UpdateManaBar(BattleController.Player);
            BattleController.EndPlayerTurn();
            CheckFightStatus();
            Task.Delay(500).ContinueWith(_ => BattleForm.Invoke(() => BotTurn()));
        }

        private void HandlePlayerRest()
        {
            if (!BattleController.isPlayerTurn) return;

            BattleController.Rest(BattleController.Player);
            UpdateManaBar(BattleController.Player);
            BattleController.EndPlayerTurn();
            Task.Delay(500).ContinueWith(_ => BattleForm.Invoke(() => BotTurn()));
        }

        private void HandleMoveForward()
        {
            if (BattleController.Player.ActualStamina < 10)
            {
                HandlePlayerRest();
                BattleController.EndPlayerTurn();
            }

            animationTimer = new Timer();
            animationTimer.Interval = 15; // ~60 FPS

            if (!BattleController.isPlayerTurn) return;

            var currentLocation = BattleForm.panelLeftWarrior.Location;
            var destinationLocation = currentLocation.X + MoveStep;

            animationTimer.Tick += (s, e) =>
            {
                if (currentLocation.X <= destinationLocation)
                {
                    currentLocation.X++;

                    BattleForm.panelLeftWarrior.Location = new Point(currentLocation.X, currentLocation.Y);
                }
                else
                {
                    animationTimer.Stop();
                    return;
                }
            };
            animationTimer.Start();
            UpdateManaBar(BattleController.Player);
            BattleController.EndPlayerTurn();
            Task.Delay(500).ContinueWith(_ => BattleForm.Invoke(() => BotTurn()));
        }

        private void HandleMoveBackward()
        {
            if (!BattleController.isPlayerTurn) return;

            if (BattleController.Player.ActualStamina < 10)
            {
                HandlePlayerRest();
                BattleController.EndPlayerTurn();
            }

            var CurrentPosition = BattleForm.panelLeftWarrior.Location;
            if (CurrentPosition.X - MoveStep >= 0)
            {
                BattleForm.panelLeftWarrior.Location = BattleController.MoveBackward(BattleForm.panelLeftWarrior.Location, BattleController.Player);
                UpdateManaBar(BattleController.Player);
            }

            BattleController.EndPlayerTurn();
            Task.Delay(500).ContinueWith(_ => BattleForm.Invoke(() => BotTurn()));
        }



        public void CheckFightStatus()
        {
            int status = BattleController.CheckFightStatus();
            if (status == 1)
            {
                //MessageBox.Show("Wygrałeś!");
                this.BattleForm.VictoryPicture.Visible = true;
                Task.Delay(2000).ContinueWith(_ => BattleForm.Invoke(() => ResetGame()));

               
            }
            else if (status == -1)
            {
                //MessageBox.Show("Przegrałeś!");
                this.BattleForm.DefeatPicture.Visible = true;
                Task.Delay(2000);
                Task.Delay(2000).ContinueWith(_ => BattleForm.Invoke(() => ResetGame()));
            }


        }


        private void BotTurn()
        {
            if (BattleController.Bot.IsDead) return;

            if (BattleController.Bot.ActualStamina >= 10)
            {


                if (BattleController.CanAttack(BattleForm.panelRightWarrior.Location, BattleForm.panelLeftWarrior.Location))
                {

                    int damage = BattleController.BotAttack();
                    BattleController.Player.TakeDamage(damage);
                    BattleForm.ConsoleTextBox.AppendText($"[B]{BattleController.Bot.Name} zadał {damage} obrażeń. Twoje zdrowie: {BattleController.Player.ActualHealth} \n");
                    //MessageBox.Show($"Bot zadał {damage} obrażeń. Twoje zdrowie: {BattleController.Player.ActualHealth}");
                    UpdateManaBar(BattleController.Bot);
                    UpdateHealthBar(BattleController.Player);
                }
                else
                {
                    if (BattleForm.panelRightWarrior.Location.X > BattleForm.panelLeftWarrior.Location.X)
                        BattleForm.panelRightWarrior.Location = BattleController.MoveBackward(BattleForm.panelRightWarrior.Location, BattleController.Bot);
                    else
                        BattleForm.panelRightWarrior.Location = BattleController.MoveForward(BattleForm.panelRightWarrior.Location, BattleController.Bot);

                    UpdateManaBar(BattleController.Bot);
                }

            }
            else
            {
                BattleController.Rest(BattleController.Bot);
            }

            BattleController.isPlayerTurn = true;
            CheckFightStatus();
        }


       
        public void ResetGame()
        {
            
            BattleController.Player.ActualHealth = 100;
            BattleController.Player.ActualStamina= 100;
            BattleController.isPlayerTurn = true;


            menu.nextForm = FormEnum.None;

            //this.BattleForm.
            this.BattleForm.Close();
            
           


        }

        private void UpdateHealthBar(Warrior warrior)
        {
            if (warrior.Character == CharacterEnum.Human)
            {
                BattleForm.pbLeftHP.Maximum = warrior.MaxHealth;
                BattleForm.pbLeftHP.Value = Math.Min(warrior.ActualHealth, warrior.MaxHealth);
            }
            else if (warrior.Character == CharacterEnum.Bot)
            {
                BattleForm.pbRightHP.Maximum = warrior.MaxHealth;
                BattleForm.pbRightHP.Value = Math.Min(warrior.ActualHealth, warrior.MaxHealth);
            }
        }

        private void UpdateManaBar(Warrior warrior)
        {
            if (warrior.Character == CharacterEnum.Human)
            {
                BattleForm.pbLeftMana.Maximum = warrior.MaxStamina;
                BattleForm.pbLeftMana.Value = Math.Min(warrior.ActualStamina, warrior.MaxStamina);
            }
            else if (warrior.Character == CharacterEnum.Bot)
            {
                BattleForm.pbRightMana.Maximum = warrior.MaxStamina;
                BattleForm.pbRightMana.Value = Math.Min(warrior.ActualStamina, warrior.MaxStamina);
            }
        }

    }
}
