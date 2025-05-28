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
        public Menu()
        {
            InitializeComponent();
            ExitButton.Click += (o, s) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
