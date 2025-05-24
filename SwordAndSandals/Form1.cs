using System.Drawing.Text;
using Timer = System.Windows.Forms.Timer;

namespace SwordAndSandals
{
    public partial class Form1 : Form
    {

        private Timer animationTimer;


        private const int MoveStep = 20;
        private const int AttackRange = 400;
        private bool isPlayerTurn = true;

        
        private Warrior warrior1;
        private Warrior warrior2;
        

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
            
            warrior1 = new Warrior("Steve", 0, ThorsAxe, null, null, null, null, null, null, null, null,CharacterEnum.Human);
            warrior2 = new Warrior("John", 0, ArthursSword, null, null, null, null, null, null, null, null,CharacterEnum.Bot);

        }

        public void InitializeControls()
        {

            labelLeftWarrior.Text = warrior1.Name;
            pbLeftHP.Minimum = 0;
            pbLeftHP.Maximum = warrior1.MaxHealth;
            pbLeftHP.Value = warrior1.ActualHealth;
            pbLeftMana.Minimum = 0;
            pbLeftMana.Maximum = warrior1.MaxStamina;
            pbLeftMana.Value = warrior1.ActualStamina;
            btnLeftAtack.Click += Atack;
            btnLeftForward.Click += MoveForward;
            btnLeftBack.Click += MoveBackward;
            btnLeftForward.Click += MoveForward;




            labelRightWarrior.Text = warrior2.Name;
            pbRightHP.Minimum = 0;
            pbRightHP.Maximum = warrior2.MaxHealth;
            pbRightHP.Value = warrior2.ActualHealth;
            pbRightMana.Minimum = 0;
            pbRightMana.Maximum = warrior2.MaxStamina;
            pbRightMana.Value = warrior2.ActualStamina;
            btnRightAtack.Visible = false;
            btnRightRest.Visible = false;
            btnRightForward.Visible = false;
            btnEightBack.Visible = false;
            btnRightUse.Visible = false;
            cmbboxRightSpell.Visible = false;
            labelSpelRight.Visible = false;

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
            if (!isPlayerTurn) return;

            int distance = Math.Abs(panelLeftWarrior.Location.X - panelRightWarrior.Location.X);
            if (distance > AttackRange)
            {
                MessageBox.Show("Jesteœ za daleko, aby zaatakowaæ!");
                return;
            }

            if (!warrior1.IsDead)
            {
                int damageDealt = warrior1.Damage();
                warrior2.TakeDamage(damageDealt);
                warrior1.ActualStamina = warrior1.ActualStamina - 10;
                //MessageBox.Show($"Zadano {damageDealt} obra¿eñ. Zdrowie przeciwnika: {warrior2.ActualHealth}");
            }
            
            UpdateHealthBar(warrior2);
            UpdateManaBar(warrior2);
            EndPlayerTurn();
            CheckFightStatus();

        }


        public void CheckFightStatus()
        {
            if(!warrior1.IsDead || !warrior2.IsDead)
            {
                return;
            }
            else if(warrior2.IsDead)
            {
                MessageBox.Show("Wygra³eœ!");
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
            //panelLeftWarrior.Location = new Point(currentLocation.X + MoveStep, currentLocation.Y);

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
            UpdateManaBar(warrior1);
            EndPlayerTurn();

        }

        private void MoveBackward(object sender, EventArgs e)
        {
            if (!isPlayerTurn) return;

            var currentLocation = panelLeftWarrior.Location;
            if (currentLocation.X - MoveStep >= 0)
            {
                panelLeftWarrior.Location = new Point(currentLocation.X - MoveStep, currentLocation.Y);
            }
            EndPlayerTurn();
        }

        private void EndPlayerTurn()
        {
            isPlayerTurn = false;
            Task.Delay(500).ContinueWith(_ => Invoke(() => BotTurn()));
        }

        private void BotTurn()
        {
            if (warrior2.IsDead) return;

            int distance = Math.Abs(panelRightWarrior.Location.X - panelLeftWarrior.Location.X);

            if (distance <= AttackRange)
            {
                int damage = warrior2.Damage();
                warrior1.TakeDamage(damage);
                //MessageBox.Show($"Bot zada³ {damage} obra¿eñ. Twoje zdrowie: {warrior1.ActualHealth}");
            }
            else
            {
                
                if (panelRightWarrior.Location.X > panelLeftWarrior.Location.X)
                {
                    panelRightWarrior.Location = new Point(panelRightWarrior.Location.X - MoveStep, panelRightWarrior.Location.Y);
                }
                else
                {
                    panelRightWarrior.Location = new Point(panelRightWarrior.Location.X + MoveStep, panelRightWarrior.Location.Y);
                }
            }

            isPlayerTurn = true;
        }

        


    }
}
