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
                StrenghtUpDown.Value = 0;
                AgilityUpDown.Value = 0;
                IntUpDown.Value = 0;
                VitalityUpDown.Value = 0;
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
                this.Player = new Warrior(NameTextBox.Text, (int)StrenghtUpDown.Value, (int)AgilityUpDown.Value, (int)IntUpDown.Value, (int)VitalityUpDown.Value);
                this.Player.baseStatisticPoints = TotalPoints;

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
    }
}
