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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace SwordAndSandals
{
    public partial class StartGameForm : Form
    {
        public Warrior Player = null;
        private const int TotalPoints = 4;
        public StartGameForm()
        {
            InitializeComponent();
            StartGameButton.Click += StartGameButton_Click;
            StrenghtUpDown.ValueChanged += UpdatePointsLeft;
            AgilityUpDown.ValueChanged += UpdatePointsLeft;
            IntUpDown.ValueChanged += UpdatePointsLeft;
            VitalityUpDown.ValueChanged += UpdatePointsLeft;
            StrenghtUpDown.Maximum = TotalPoints;
            AgilityUpDown.Maximum = TotalPoints;
            IntUpDown.Maximum = TotalPoints;
            VitalityUpDown.Maximum = TotalPoints;


            UpdatePointsLeft(null, null);
            ResetStatsButton.Click += (s, e) =>
            {

            };
        }


        private void UpdatePointsLeft(object sender, EventArgs e)
        {

            int spent = (int)(StrenghtUpDown.Value + AgilityUpDown.Value + IntUpDown.Value + VitalityUpDown.Value);

            if (spent >= TotalPoints)
            {
                StrenghtUpDown.Enabled = false;
                AgilityUpDown.Enabled = false;
                IntUpDown.Enabled = false;
                VitalityUpDown.Enabled = false;
            }
            else
            {
                StrenghtUpDown.Enabled = true;
                AgilityUpDown.Enabled = true;
                IntUpDown.Enabled = true;
                VitalityUpDown.Enabled = true;

            }

            int left = TotalPoints - spent;
            PointsLeftLabel.Text = $"{left.ToString()} punktów";
            StartGameButton.Enabled = left == 0;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (this.Player == null)
                {

                    this.Player = new Warrior(NameTextBox.Text, (int)StrenghtUpDown.Value, (int)AgilityUpDown.Value, (int)IntUpDown.Value, (int)VitalityUpDown.Value, CharacterEnum.Human);
                    this.Player.baseStatisticPoints = TotalPoints;

                    this.Player.Weapons.Add(WeaponRepository.GetWeapons()[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartGameGB_Enter(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "Tester";
            StrenghtUpDown.Value = 1;
            AgilityUpDown.Value = 1;
            IntUpDown.Value = 1;
            VitalityUpDown.Value = 1;
            this.UpdatePointsLeft(sender, e);
            this.StartGameButton_Click(sender, e);
        }

        private void openFromFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik JSON";
            openFileDialog.Filter = "Pliki JSON (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
              

                string jsonFromFile = File.ReadAllText(selectedFilePath);
                Warrior loadedWarrior = JsonConvert.DeserializeObject<Warrior>(jsonFromFile);

        
                this.Player = loadedWarrior;
                this.UpdatePointsLeft(sender, e);
                this.StartGameButton_Click(sender, e);
 
            }
        }
    }
}
