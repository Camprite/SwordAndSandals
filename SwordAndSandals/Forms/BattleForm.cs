using System.Drawing.Text;
using Timer = System.Windows.Forms.Timer;
using SwordAndSandalsLogic;
using SwordAndSandals.FormControllers;

namespace SwordAndSandals
{

    public partial class BattleForm : Form
    {
        private BattleFormController formController;
        public BattleForm()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();


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

        private void ConsoleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DefeatPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
