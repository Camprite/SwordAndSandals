using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;


namespace SwordAndSandals.FormControllers
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
        public BattleForm BattleForm { get; set; }

        public BattleController BattleController;
        public Menu menu;

        

        public BattleFormController(BattleForm battleForm)
        {
            BattleForm = battleForm;
            InitilizeBattleFormControls();
        }

        public BattleFormController()
        {


        }


        public void InitilizeBattleFormControls()
        {
            BattleForm.VictoryPicture.Visible = false;
            BattleForm.DefeatPicture.Visible = false;

            //BattleForm.BattleStatsPicture.Visible = false;
            BattleForm.BattleStatsLabel.Visible = false;
            BattleForm.BattleStatsPanel.Visible = false;

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
                
                return;
            }



            //int Damage = BattleController.PlayerAttack();
            int Damage = BattleController.PlayerAttack();

         

            UpdateHealthBar(BattleController.Bot);
            BattleForm.ConsoleTextBox.AppendText($"[P] Zadałeś przeciwnikowi: [{BattleController.Player.Damage()}] {Damage} obrażeń  Pozostało mu: {BattleController.Bot.ActualHealth}  \n");
            //BattleForm.ConsoleTextBox.AppendText($"[P] Def: {BattleController.getDefence(BattleController.Player)}  \n");
            //BattleForm.ConsoleTextBox.AppendText($"[P] TestDamage with defemce {testDamage} \n");
            
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



        public async void CheckFightStatus()
        {
            int status = BattleController.CheckFightStatus();
            if (status == 1)
            {

                BattleForm.VictoryPicture.Visible = true;

                var result = new BattleResult(xp: 250, money: 300, totalDamage: BattleController.TotalDamage);
                
                await Task.Delay(1000);
                
              
                ShowStats(result);
                BattleController.Player.XP += result.EarnedXP;
                BattleController.Player.Money += result.EarnedMoney;
                await Task.Delay(2000);
                ResetGame();
                BattleForm.VictoryPicture.Visible = false;
                //Task.Delay(2000).ContinueWith(_ => BattleForm.Invoke(() => ResetGame()));


            }
            else if (status == -1)
            {

                BattleForm.DefeatPicture.Visible = true;

                var result = new BattleResult(xp: 100, money: 150, totalDamage: BattleController.TotalDamage);

                await Task.Delay(1000);

                
                ShowStats(result);
                BattleController.Player.XP += result.EarnedXP;
                BattleController.Player.Money += result.EarnedMoney;
                await Task.Delay(2000);
                BattleForm.DefeatPicture.Visible = false;
                ResetGame();

                //Task.Delay(2000).ContinueWith(_ => BattleForm.Invoke(() => ResetGame()));
            }


        }


        private void ShowStats(BattleResult result)
        {
            //BattleForm.BattleStatsPicture.BringToFront();
            //BattleForm.BattleStatsPicture.Visible = true;
            //BattleForm.BattleStatsPanel.BringToFront();
            //BattleForm.BattleStatsPanel.Visible = true;
            BattleForm.BattleStatsLabel.BringToFront();
            BattleForm.BattleStatsLabel.Visible = true;
            BattleForm.BattleStatsLabel.Text =
                $"Zdobyte XP : {result.EarnedXP}\n" +
                $"Zdobyte złoto: {result.EarnedMoney}\n" +
                $"Zadane obrażenia: {result.TotalDamage}";

        }


        private void BotTurn()
        {
            if (BattleController.Bot.IsDead) return;

            if (BattleController.Bot.ActualStamina >= 10)
            {


                if (BattleController.CanAttack(BattleForm.panelRightWarrior.Location, BattleForm.panelLeftWarrior.Location))
                {

                    int damage = BattleController.BotAttack();
                    BattleForm.ConsoleTextBox.AppendText($"[B]{BattleController.Bot.Name} zadał [{BattleController.Bot.Damage()}] {damage} obrażeń. Twoje zdrowie: {BattleController.Player.ActualHealth} \n");
                    //BattleForm.ConsoleTextBox.AppendText($"Podstawowe {BattleController.Bot.Damage()}");
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

            BattleController.Player.ActualHealth = BattleController.Player.MaxHealth;
            BattleController.Player.ActualStamina = BattleController.Player.MaxStamina;
            BattleController.isPlayerTurn = true;
            BattleForm.ConsoleTextBox.Clear();
            BattleForm.panelLeftWarrior.Location = new Point(332, 277);
            BattleForm.panelRightWarrior.Location = new Point(740, 277);
            menu.nextForm = FormEnum.None;
            
            BattleForm.Close();




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
