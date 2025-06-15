using Newtonsoft.Json;
using SwordAndSandalsLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwordAndSandals
{
    public partial class Menu : Form
    {
        public Warrior player = null;
        public FormEnum nextForm = FormEnum.None;

        public Menu()
        {
            InitializeComponent();
           
            ExitButton.Click += (o, s) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            saveGameButton.Click += (o, s) =>
            {
                string json = JsonConvert.SerializeObject(player, Formatting.Indented);
                string path = $"warrior{player.GetHashCode()}.json";
                File.WriteAllText(path, json);
                MessageBox.Show($"Pomyślnie zapisano postać w pliku:{path}");
            };
            this.intIncrement.Click += (o, s) => { player.addPoint(StatisticsEnum.Inteligence); this.updateForm(); };
            this.witIncrement.Click += (o, s) => { player.addPoint(StatisticsEnum.Vitality); this.updateForm(); };
            this.aglIncrement.Click += (o, s) => { player.addPoint(StatisticsEnum.Agility); this.updateForm(); };
            this.strIncrement.Click += (o, s) => { player.addPoint(StatisticsEnum.Strenght); this.updateForm(); };

            this.ShopButton.Click += (o, s) => { this.returnNextForm(FormEnum.Shop);  };
            this.InventoryButton.Click += (o, s) => { this.returnNextForm(FormEnum.Inventory);  };
            this.BattleButton.Click += (o, s) => { this.returnNextForm(FormEnum.Battle);  };

           
            this.LevelUp.Click += (o, s) => {

                if(player.CanLevelUp())
                {
                player.LevelUp();
                updateForm();}
            };
        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void returnNextForm(FormEnum formName){
            this.DialogResult= DialogResult.OK;
            this.nextForm = formName;
            }

        private void StartGameButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void updateForm()
        {
            this.playerName.Text = player.Name;
            this.moneyLabel.Text = player.Money.ToString();
            this.xpLabel.Text = player.XP.ToString();
            this.levelLabel.Text = player.Level.ToString();
            this.pointsLabel.Text = player.getAvaiablePoints().ToString();

            //if (player.getAvaiablePoints() <= 0)
            //{
            //    this.setNumericUpDisabled();
            //}

            this.intLabel.Text = player.Int.ToString();
            this.strLabel.Text = player.Strenght.ToString();
            this.witLabel.Text = player.Vitality.ToString();
            this.aglLabel.Text = player.Agility.ToString();



        }
        

        private void xpLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
