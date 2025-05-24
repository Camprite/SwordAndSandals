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
    public partial class StartGame : Form
    {
        public string PlayerName;
        public int Int;
        public int Strenght;
        public int Agility;
        public int Vitality;
        private const int TotalPoints = 4;
        public StartGame()
        {
            InitializeComponent();
            StartGameButton.Click += StartGameButton_Click;
            StrenghtUpDown.ValueChanged += UpdatePointsLeft;
            AgilityUpDown.ValueChanged += UpdatePointsLeft;
            IntUpDown.ValueChanged += UpdatePointsLeft;
            VitalityUpDown.ValueChanged += UpdatePointsLeft;
            UpdatePointsLeft(null, null);

        }


        private void UpdatePointsLeft(object sender, EventArgs e)
        {
            int spent = (int)(StrenghtUpDown.Value + AgilityUpDown.Value + IntUpDown.Value + VitalityUpDown.Value);
            int left = TotalPoints - spent;
            PointsLeftLabel.Text = $"Pozostało jeszcze: {left.ToString()} punktów";
            StartGameButton.Enabled = left == 0;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            PlayerName = NameTextBox.Text;
            Int = (int)IntUpDown.Value;
            Strenght = (int)StrenghtUpDown.Value;
            Agility = (int)AgilityUpDown.Value;
            Vitality = (int)VitalityUpDown.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
