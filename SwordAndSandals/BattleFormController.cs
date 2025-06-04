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

        public Warrior Bot;
        public Warrior Player { get; set; }
        public BattleForm BattleForm { get;set; }

        public BattleController BattleController { get; set; }
        public GameController GameController;

        public BattleFormController(BattleForm battleForm)
        {
            
            InitilizeBattleFormControls();
        }
       
        public BattleFormController()
        {
            

        }


        public void InitilizeBattleFormControls()
        {
            BattleForm.labelLeftWarrior.Text = Player.Name;
            BattleForm.pbLeftHP.Minimum = 0;
            BattleForm.pbLeftHP.Maximum = Player.MaxHealth;
            BattleForm.pbLeftHP.Value = Player.ActualHealth;
            BattleForm.pbLeftMana.Minimum = 0;
            BattleForm.pbLeftMana.Maximum = Player.MaxStamina;
            BattleForm.pbLeftMana.Value = Player.ActualStamina;

            OnAttack = HandlePlayerAttack;
            OnRest = HandlePlayerRest;
            OnMoveForward = HandleMoveForward;
            OnMoveBackward = HandleMoveBackward;

            BattleForm.btnLeftAtack.Click += (s, e) => OnAttack?.Invoke();
            BattleForm.btnLeftRest.Click += (s, e) => OnRest?.Invoke();
            BattleForm.btnLeftForward.Click += (s, e) => OnMoveForward?.Invoke();
            BattleForm.btnLeftBack.Click += (s, e) => OnMoveBackward?.Invoke();

            //added
            this.Bot = GenerateBot();

            BattleForm.labelRightWarrior.Text = Bot.Name;
            BattleForm.pbRightHP.Minimum = 0;
            BattleForm.pbRightHP.Maximum = Bot.MaxHealth;
            BattleForm.pbRightHP.Value = Bot.ActualHealth;
            BattleForm.pbRightMana.Minimum = 0;
            BattleForm.pbRightMana.Maximum = Bot.MaxStamina;
            BattleForm.pbRightMana.Value = Bot.ActualStamina;
            BattleForm.btnRightAtack.Visible = false;
            BattleForm.btnRightRest.Visible = false;
            BattleForm.btnRightForward.Visible = false;
            BattleForm.btnEightBack.Visible = false;
            BattleForm.btnRightUse.Visible = false;
            BattleForm.cmbboxRightSpell.Visible = false;
            BattleForm.labelSpelRight.Visible = false;
        }

        //public void InitializeHeroesAndArmours()
        //{
        //    Player = GameController.getPlayer();
        //    string Name = Player.Name;
        //    int Int = (int)StartGame.IntUpDown.Value;
        //    int Strenght = (int)StartGame.StrenghtUpDown.Value;
        //    int Agility = (int)StartGame.AgilityUpDown.Value;
        //    int Vitality = (int)StartGame.VitalityUpDown.Value;
        //    Armour MosesBoots = new Armour(1, "Buty Mojżesza", "+5 do zwinnośći", ArmourEnum.Boots, 5, "", 500);
        //    Armour HerculesBoots = new Armour(2, "Buty Herkulesa", "+10 do zwinnosci", ArmourEnum.Boots, 5, "", 1000);

        //    Weapon ArthursSword = new Weapon(1, "Miecz króla artura", "+5 do ataku", WeaponEnum.Sword, 0, 0, 0, "", 500, 10);
        //    Weapon ThorsAxe = new Weapon(2, "Topór Thora", "+10 do siły", WeaponEnum.Axe, 0, 0, 0, "", 1000, 15);

        //    Player = new Warrior(Name, 0, ThorsAxe, null, null, null, null, null, null, null, null, CharacterEnum.Human, Strenght, Agility, Vitality, Int);
        //    Bot = new Warrior("John", 0, ArthursSword, null, null, null, null, null, null, null, null, CharacterEnum.Bot, 0, 0, 0, 0);
        //    //BattleController = new BattleController(Player, Bot);
        //}

        private void HandlePlayerAttack()
        {
            if (!BattleController.isPlayerTurn) return;

            if (!BattleController.CanAttack(BattleForm.panelLeftWarrior.Location, BattleForm.panelRightWarrior.Location))
            {
                MessageBox.Show("Jesteś za daleko, aby zaatakować!");
                return;
            }


            int Damage = BattleController.PlayerAttack();
            UpdateHealthBar(Bot);
            UpdateManaBar(Player);
            BattleController.EndPlayerTurn();
            CheckFightStatus();
            Task.Delay(500).ContinueWith(_ => BattleForm.Invoke(() => BotTurn()));
        }

        private void HandlePlayerRest()
        {
            if (!BattleController.isPlayerTurn) return;

            BattleController.Rest(Player);
            UpdateManaBar(Player);
            BattleController.EndPlayerTurn();
            Task.Delay(500).ContinueWith(_ => BattleForm.Invoke(() => BotTurn()));
        }

        private void HandleMoveForward()
        {
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
            UpdateManaBar(Player);
            BattleController.EndPlayerTurn();
            Task.Delay(500).ContinueWith(_ => BattleForm.Invoke(() => BotTurn()));
        }

        private void HandleMoveBackward()
        {
            if (!BattleController.isPlayerTurn) return;

            var CurrentPosition = BattleForm.panelLeftWarrior.Location;
            if (CurrentPosition.X - MoveStep >= 0)
            {
                BattleForm.panelLeftWarrior.Location = BattleController.MoveBackward(BattleForm.panelLeftWarrior.Location, Player);
                UpdateManaBar(Player);
            }

            BattleController.EndPlayerTurn();
            Task.Delay(500).ContinueWith(_ => BattleForm.Invoke(() => BotTurn()));
        }



        public void CheckFightStatus()
        {
            int status = BattleController.CheckFightStatus();
            if (status == 1)
            {
                MessageBox.Show("Wygrałeś!");
                ResetGame();
            }
            else if (status == -1)
            {
                MessageBox.Show("Przegrałeś!");
                ResetGame();
            }


        }


        private void BotTurn()
        {
            if (Bot.IsDead) return;

            if (Bot.ActualStamina >= 10)
            {


                if (BattleController.CanAttack(BattleForm.panelRightWarrior.Location, BattleForm.panelLeftWarrior.Location))
                {

                    int damage = BattleController.BotAttack();
                    Player.TakeDamage(damage);
                    MessageBox.Show($"Bot zadał {damage} obrażeń. Twoje zdrowie: {Player.ActualHealth}");
                    UpdateManaBar(Bot);
                    UpdateHealthBar(Player);
                }
                else
                {
                    if (BattleForm.panelRightWarrior.Location.X > BattleForm.panelLeftWarrior.Location.X)
                        BattleForm.panelRightWarrior.Location = BattleController.MoveBackward(BattleForm.panelRightWarrior.Location, Bot);
                    else
                        BattleForm.panelRightWarrior.Location = BattleController.MoveForward(BattleForm.panelRightWarrior.Location, Bot);

                    UpdateManaBar(Bot);
                }

            }
            else
            {
                BattleController.Rest(Bot);
            }

            BattleController.isPlayerTurn = true;
            CheckFightStatus();
        }


       
        public void ResetGame()
        {

            //BattleForm.panelLeftWarrior.Location = new Point(332, 277);
            //BattleForm.panelRightWarrior.Location = new Point(740, 277);

            //InitializeHeroesAndArmours(StartGame);
            //InitilizeBattleFormControls();


            //UpdateHealthBar(Player);
            //UpdateManaBar(Player);
            //UpdateHealthBar(Bot);
            //UpdateManaBar(Bot);


            //BattleController.isPlayerTurn = true;

            BattleForm.Close();
            GameController.menuForm.ShowDialog();



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


        public Warrior GenerateBot()
        {
            Weapon ArthursSword = new Weapon(1, "Miecz króla artura", "+5 do ataku", WeaponEnum.Sword, 0, 0, 0, "", 500, 10);
            Bot = new Warrior("John", 0, ArthursSword, null, null, null, null, null, null, null, null, CharacterEnum.Bot, 0, 0, 0, 0);
            return Bot;
        }


    }
}
