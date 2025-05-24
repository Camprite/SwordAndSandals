using System.Drawing.Text;
using Timer = System.Windows.Forms.Timer;
using SwordAndSandalsLogic;

namespace SwordAndSandals
{
    
    public partial class Form1 : Form
    {
        
    
        private Timer animationTimer;
        private BattleController battleController;

        private const int MoveStep = 20;
        private const int AttackRange = 400;
        private bool isPlayerTurn = true;


        
        private Warrior Player;
        private Warrior Bot;



        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            InitializeHeroesAndArmours();
            InitializeControls();
            
        }
        public class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
            {
                this.DoubleBuffered = true;
                this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                              ControlStyles.UserPaint |
                              ControlStyles.OptimizedDoubleBuffer, true);
                this.UpdateStyles();
            }
        }


        public void InitializeHeroesAndArmours()
        {
            Armour MosesBoots = new Armour(1, "Buty Moj¿esza", "+5 do zwinnoœæi", ArmourEnum.Boots, 5, "", 500);
            Armour HerculesBoots = new Armour(2, "Buty Herkulesa", "+10 do zwinnosci", ArmourEnum.Boots, 5, "", 1000);

            Weapon ArthursSword = new Weapon(1, "Miecz króla artura", "+5 do ataku", WeaponEnum.Sword, 0, 0, 0, "", 500, 10);
            Weapon ThorsAxe = new Weapon(2, "Topór Thora", "+10 do si³y", WeaponEnum.Axe, 0, 0, 0, "", 1000, 15);
            
            Player = new Warrior("Steve", 0, ThorsAxe, null, null, null, null, null, null, null, null,CharacterEnum.Human);
            Bot = new Warrior("John", 0, ArthursSword, null, null, null, null, null, null, null, null,CharacterEnum.Bot);
            battleController = new BattleController(Player, Bot);
        }

        public void InitializeControls()
        {

            labelLeftWarrior.Text = Player.Name;
            pbLeftHP.Minimum = 0;
            pbLeftHP.Maximum = Player.MaxHealth;
            pbLeftHP.Value = Player.ActualHealth;
            pbLeftMana.Minimum = 0;
            pbLeftMana.Maximum = Player.MaxStamina;
            pbLeftMana.Value = Player.ActualStamina;
            btnLeftAtack.Click += Atack;
            btnLeftForward.Click += MoveForward;
            btnLeftBack.Click += MoveBackward;
            btnLeftForward.Click += MoveForward;
            btnLeftRest.Click += Rest;
            
            



            labelRightWarrior.Text = Bot.Name;
            pbRightHP.Minimum = 0;
            pbRightHP.Maximum = Bot.MaxHealth;
            pbRightHP.Value = Bot.ActualHealth;
            pbRightMana.Minimum = 0;
            pbRightMana.Maximum = Bot.MaxStamina;
            pbRightMana.Value = Bot.ActualStamina;
            btnRightAtack.Visible = false;
            btnRightRest.Visible = false;
            btnRightForward.Visible = false;
            btnEightBack.Visible = false;
            btnRightUse.Visible = false;
            cmbboxRightSpell.Visible = false;
            labelSpelRight.Visible = false;

        }

        private void Rest(object? sender, EventArgs e)
        {
            if(!battleController.isPlayerTurn) return;

            battleController.Rest(Player);
            UpdateManaBar(Player);
            battleController.EndPlayerTurn();
            Task.Delay(500).ContinueWith(_ => Invoke(() => BotTurn()));

        }

        private void UpdateHealthBar(Warrior warrior)
        {
            if (warrior.Character == CharacterEnum.Human)
            {
                pbLeftHP.Maximum = warrior.MaxHealth;
                pbLeftHP.Value = Math.Min(warrior.ActualHealth, warrior.MaxHealth);
            }
            else if (warrior.Character == CharacterEnum.Bot)
            { 
                pbRightHP.Maximum = warrior.MaxHealth;
                pbRightHP.Value = Math.Min(warrior.ActualHealth, warrior.MaxHealth);
            }
        }

        private void UpdateManaBar(Warrior warrior)
        {
            if (warrior.Character == CharacterEnum.Human)
            {
                pbLeftMana.Maximum = warrior.MaxStamina;
                pbLeftMana.Value = Math.Min(warrior.ActualStamina, warrior.MaxStamina);
            }
            else if (warrior.Character == CharacterEnum.Bot)
            {
                pbRightMana.Maximum = warrior.MaxStamina;
                pbRightMana.Value = Math.Min(warrior.ActualStamina, warrior.MaxStamina);
            }
        }


        private void Atack(object sender, EventArgs e)
        {
            if (!battleController.isPlayerTurn) return;

            if (!battleController.CanAttack(panelLeftWarrior.Location, panelRightWarrior.Location))
            {
                MessageBox.Show("Jesteœ za daleko, aby zaatakowaæ!");
                return;
            }


            int Damage = battleController.PlayerAttack();
            UpdateHealthBar(Bot);
            UpdateManaBar(Player);
            battleController.EndPlayerTurn();
            CheckFightStatus();
            Task.Delay(500).ContinueWith(_ => Invoke(() => BotTurn()));

        }


        public void CheckFightStatus()
        {
            int status = battleController.CheckFightStatus();
            if (status == 1)
            {
                MessageBox.Show("Wygra³eœ!");
                ResetGame();
            }
            else if (status == -1)
            {
                MessageBox.Show("Przegra³eœ!");
                ResetGame();
            }

            
        }

        private void MoveForward(object sender, EventArgs e)
        {
            animationTimer = new Timer();
            animationTimer = new Timer();
            animationTimer.Interval = 15; // ~60 FPS

            if (!isPlayerTurn) return;

            var currentLocation = panelLeftWarrior.Location;
            var destinationLocation = currentLocation.X + MoveStep;

            animationTimer.Tick += (s, e) =>
            {
                if (currentLocation.X <= destinationLocation)
                {
                    currentLocation.X++;

                    panelLeftWarrior.Location = new Point(currentLocation.X, currentLocation.Y);
                }
                else
                {
                    animationTimer.Stop();
                    return;
                }
            };
            animationTimer.Start();
            UpdateManaBar(Player);
            battleController.EndPlayerTurn();
            Task.Delay(500).ContinueWith(_ => Invoke(() => BotTurn()));

        }

        private void MoveBackward(object sender, EventArgs e)
        {
           
                if (!battleController.isPlayerTurn) return;

                var CurrentPosition = panelLeftWarrior.Location;
                if (CurrentPosition.X - MoveStep >= 0)
                {
                    panelLeftWarrior.Location = battleController.MoveBackward(panelLeftWarrior.Location, Player);
                    UpdateManaBar(Player);
                }


                
                battleController.EndPlayerTurn();
                Task.Delay(500).ContinueWith(_ => Invoke(() => BotTurn()));
            
        }



        private void BotTurn()
        {
            if (Bot.IsDead) return;

            if (Bot.ActualStamina >= 10)
            {


                if (battleController.CanAttack(panelRightWarrior.Location, panelLeftWarrior.Location))
                {

                    int damage = battleController.BotAttack();
                    Player.TakeDamage(damage);
                    MessageBox.Show($"Bot zada³ {damage} obra¿eñ. Twoje zdrowie: {Player.ActualHealth}");
                    UpdateManaBar(Bot);
                    UpdateHealthBar(Player);
                }
                else
                {
                    if (panelRightWarrior.Location.X > panelLeftWarrior.Location.X)
                        panelRightWarrior.Location = battleController.MoveBackward(panelRightWarrior.Location, Bot);
                    else
                        panelRightWarrior.Location = battleController.MoveForward(panelRightWarrior.Location, Bot);

                    UpdateManaBar(Bot);
                }

            }else
            {
                battleController.Rest(Bot);
            }

            battleController.isPlayerTurn = true;
            CheckFightStatus();
        }


        public void ResetGame()
        {
            panelLeftWarrior.Location = new Point(332, 277);
            panelRightWarrior.Location = new Point(740, 277);

            InitializeHeroesAndArmours(); 
            InitializeControls();         

            
            UpdateHealthBar(Player);
            UpdateManaBar(Player);
            UpdateHealthBar(Bot);
            UpdateManaBar(Bot);

            
            battleController.isPlayerTurn = true;
        }
        


    }
}
