using System.Security.Cryptography.X509Certificates;

namespace SwordAndSandals
{
    partial class Battle
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLeftWarrior = new Label();
            labelRightWarrior = new Label();
            WarriorboxLeft = new PictureBox();
            WarriorboxRight = new PictureBox();
            btnLeftAtack = new Button();
            btnRightAtack = new Button();
            pbLeftHP = new ProgressBar();
            pbLeftMana = new ProgressBar();
            pbRightHP = new ProgressBar();
            pbRightMana = new ProgressBar();
            btnLeftRest = new Button();
            btnRightRest = new Button();
            btnLeftForward = new Button();
            btnRightForward = new Button();
            btnLeftBack = new Button();
            btnEightBack = new Button();
            labelHealthRight = new Label();
            labelManaRight = new Label();
            btnLeftUse = new Button();
            labelSpelLeft = new Label();
            cmbboxLeftSpell = new ComboBox();
            labelManaLeft = new Label();
            labelHealthLeft = new Label();
            btnRightUse = new Button();
            labelSpelRight = new Label();
            cmbboxRightSpell = new ComboBox();
            panelRightWarrior = new DoubleBufferedPanel();
            panelLeftWarrior = new DoubleBufferedPanel();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)WarriorboxLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarriorboxRight).BeginInit();
            panelRightWarrior.SuspendLayout();
            panelLeftWarrior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelLeftWarrior
            // 
            labelLeftWarrior.AutoSize = true;
            labelLeftWarrior.BackColor = Color.DarkGray;
            labelLeftWarrior.Location = new Point(268, 2);
            labelLeftWarrior.Margin = new Padding(2, 0, 2, 0);
            labelLeftWarrior.Name = "labelLeftWarrior";
            labelLeftWarrior.Size = new Size(38, 15);
            labelLeftWarrior.TabIndex = 0;
            labelLeftWarrior.Text = "label1";
            // 
            // labelRightWarrior
            // 
            labelRightWarrior.AutoSize = true;
            labelRightWarrior.BackColor = Color.DarkGray;
            labelRightWarrior.Location = new Point(67, 2);
            labelRightWarrior.Margin = new Padding(2, 0, 2, 0);
            labelRightWarrior.Name = "labelRightWarrior";
            labelRightWarrior.Size = new Size(38, 15);
            labelRightWarrior.TabIndex = 1;
            labelRightWarrior.Text = "label2";
            // 
            // WarriorboxLeft
            // 
            WarriorboxLeft.BackgroundImage = Properties.Resources.gladiatorwyciety;
            WarriorboxLeft.BackgroundImageLayout = ImageLayout.Zoom;
            WarriorboxLeft.Location = new Point(223, 19);
            WarriorboxLeft.Margin = new Padding(2);
            WarriorboxLeft.Name = "WarriorboxLeft";
            WarriorboxLeft.Size = new Size(134, 207);
            WarriorboxLeft.TabIndex = 2;
            WarriorboxLeft.TabStop = false;
            // 
            // WarriorboxRight
            // 
            WarriorboxRight.BackColor = Color.Transparent;
            WarriorboxRight.BackgroundImage = Properties.Resources.gladiatorwycietylewy;
            WarriorboxRight.BackgroundImageLayout = ImageLayout.Zoom;
            WarriorboxRight.Location = new Point(12, 19);
            WarriorboxRight.Margin = new Padding(2);
            WarriorboxRight.Name = "WarriorboxRight";
            WarriorboxRight.Size = new Size(139, 207);
            WarriorboxRight.TabIndex = 3;
            WarriorboxRight.TabStop = false;
            // 
            // btnLeftAtack
            // 
            btnLeftAtack.BackColor = SystemColors.ActiveBorder;
            btnLeftAtack.Location = new Point(141, 113);
            btnLeftAtack.Margin = new Padding(2);
            btnLeftAtack.Name = "btnLeftAtack";
            btnLeftAtack.Size = new Size(78, 20);
            btnLeftAtack.TabIndex = 4;
            btnLeftAtack.Text = "Atak";
            btnLeftAtack.UseVisualStyleBackColor = false;
            // 
            // btnRightAtack
            // 
            btnRightAtack.BackColor = Color.DarkGray;
            btnRightAtack.Location = new Point(155, 116);
            btnRightAtack.Margin = new Padding(2);
            btnRightAtack.Name = "btnRightAtack";
            btnRightAtack.Size = new Size(78, 20);
            btnRightAtack.TabIndex = 5;
            btnRightAtack.Text = "Atak";
            btnRightAtack.UseVisualStyleBackColor = false;
            // 
            // pbLeftHP
            // 
            pbLeftHP.BackColor = SystemColors.ActiveBorder;
            pbLeftHP.Location = new Point(109, 36);
            pbLeftHP.Margin = new Padding(2);
            pbLeftHP.Name = "pbLeftHP";
            pbLeftHP.Size = new Size(105, 20);
            pbLeftHP.TabIndex = 6;
            // 
            // pbLeftMana
            // 
            pbLeftMana.BackColor = SystemColors.ActiveBorder;
            pbLeftMana.Location = new Point(109, 68);
            pbLeftMana.Margin = new Padding(2);
            pbLeftMana.Name = "pbLeftMana";
            pbLeftMana.Size = new Size(105, 20);
            pbLeftMana.TabIndex = 7;
            // 
            // pbRightHP
            // 
            pbRightHP.BackColor = Color.DarkGray;
            pbRightHP.Location = new Point(157, 35);
            pbRightHP.Margin = new Padding(2);
            pbRightHP.Name = "pbRightHP";
            pbRightHP.Size = new Size(105, 20);
            pbRightHP.TabIndex = 8;
            // 
            // pbRightMana
            // 
            pbRightMana.BackColor = Color.DarkGray;
            pbRightMana.Location = new Point(155, 74);
            pbRightMana.Margin = new Padding(2);
            pbRightMana.Name = "pbRightMana";
            pbRightMana.Size = new Size(105, 20);
            pbRightMana.TabIndex = 9;
            // 
            // btnLeftRest
            // 
            btnLeftRest.BackColor = SystemColors.ActiveBorder;
            btnLeftRest.Location = new Point(127, 137);
            btnLeftRest.Margin = new Padding(2);
            btnLeftRest.Name = "btnLeftRest";
            btnLeftRest.Size = new Size(92, 20);
            btnLeftRest.TabIndex = 10;
            btnLeftRest.Text = "Odpoczynek";
            btnLeftRest.UseVisualStyleBackColor = false;
            // 
            // btnRightRest
            // 
            btnRightRest.BackColor = Color.DarkGray;
            btnRightRest.Location = new Point(155, 140);
            btnRightRest.Margin = new Padding(2);
            btnRightRest.Name = "btnRightRest";
            btnRightRest.Size = new Size(92, 20);
            btnRightRest.TabIndex = 11;
            btnRightRest.Text = "Odpoczynek";
            btnRightRest.UseVisualStyleBackColor = false;
            // 
            // btnLeftForward
            // 
            btnLeftForward.BackColor = SystemColors.ActiveBorder;
            btnLeftForward.Location = new Point(141, 161);
            btnLeftForward.Margin = new Padding(2);
            btnLeftForward.Name = "btnLeftForward";
            btnLeftForward.Size = new Size(78, 20);
            btnLeftForward.TabIndex = 12;
            btnLeftForward.Text = "Naprzód";
            btnLeftForward.UseVisualStyleBackColor = false;
            // 
            // btnRightForward
            // 
            btnRightForward.BackColor = Color.DarkGray;
            btnRightForward.Location = new Point(155, 164);
            btnRightForward.Margin = new Padding(2);
            btnRightForward.Name = "btnRightForward";
            btnRightForward.Size = new Size(78, 20);
            btnRightForward.TabIndex = 13;
            btnRightForward.Text = "Naprzód";
            btnRightForward.UseVisualStyleBackColor = false;
            // 
            // btnLeftBack
            // 
            btnLeftBack.BackColor = SystemColors.ActiveBorder;
            btnLeftBack.Location = new Point(54, 161);
            btnLeftBack.Margin = new Padding(2);
            btnLeftBack.Name = "btnLeftBack";
            btnLeftBack.Size = new Size(78, 20);
            btnLeftBack.TabIndex = 14;
            btnLeftBack.Text = "Wycofaj";
            btnLeftBack.UseVisualStyleBackColor = false;
            // 
            // btnEightBack
            // 
            btnEightBack.BackColor = Color.DarkGray;
            btnEightBack.Location = new Point(246, 164);
            btnEightBack.Margin = new Padding(2);
            btnEightBack.Name = "btnEightBack";
            btnEightBack.Size = new Size(78, 20);
            btnEightBack.TabIndex = 15;
            btnEightBack.Text = "Wycofaj";
            btnEightBack.UseVisualStyleBackColor = false;
            // 
            // labelHealthRight
            // 
            labelHealthRight.AutoSize = true;
            labelHealthRight.BackColor = Color.DarkGray;
            labelHealthRight.Location = new Point(157, 19);
            labelHealthRight.Margin = new Padding(2, 0, 2, 0);
            labelHealthRight.Name = "labelHealthRight";
            labelHealthRight.Size = new Size(73, 15);
            labelHealthRight.TabIndex = 17;
            labelHealthRight.Text = "Punkty życia";
            // 
            // labelManaRight
            // 
            labelManaRight.AutoSize = true;
            labelManaRight.BackColor = Color.DarkGray;
            labelManaRight.Location = new Point(157, 58);
            labelManaRight.Margin = new Padding(2, 0, 2, 0);
            labelManaRight.Name = "labelManaRight";
            labelManaRight.Size = new Size(37, 15);
            labelManaRight.TabIndex = 19;
            labelManaRight.Text = "Mana";
            // 
            // btnLeftUse
            // 
            btnLeftUse.BackColor = SystemColors.ActiveBorder;
            btnLeftUse.Location = new Point(139, 202);
            btnLeftUse.Margin = new Padding(2);
            btnLeftUse.Name = "btnLeftUse";
            btnLeftUse.Size = new Size(78, 20);
            btnLeftUse.TabIndex = 21;
            btnLeftUse.Text = "Użyj";
            btnLeftUse.UseVisualStyleBackColor = false;
            // 
            // labelSpelLeft
            // 
            labelSpelLeft.AutoSize = true;
            labelSpelLeft.BackColor = SystemColors.ActiveBorder;
            labelSpelLeft.Location = new Point(5, 194);
            labelSpelLeft.Margin = new Padding(2, 0, 2, 0);
            labelSpelLeft.Name = "labelSpelLeft";
            labelSpelLeft.Size = new Size(50, 15);
            labelSpelLeft.TabIndex = 20;
            labelSpelLeft.Text = "Zaklecie";
            // 
            // cmbboxLeftSpell
            // 
            cmbboxLeftSpell.BackColor = SystemColors.ActiveBorder;
            cmbboxLeftSpell.FormattingEnabled = true;
            cmbboxLeftSpell.Location = new Point(5, 203);
            cmbboxLeftSpell.Margin = new Padding(2);
            cmbboxLeftSpell.Name = "cmbboxLeftSpell";
            cmbboxLeftSpell.Size = new Size(129, 23);
            cmbboxLeftSpell.TabIndex = 19;
            // 
            // labelManaLeft
            // 
            labelManaLeft.AutoSize = true;
            labelManaLeft.BackColor = SystemColors.ActiveBorder;
            labelManaLeft.Location = new Point(109, 55);
            labelManaLeft.Margin = new Padding(2, 0, 2, 0);
            labelManaLeft.Name = "labelManaLeft";
            labelManaLeft.Size = new Size(37, 15);
            labelManaLeft.TabIndex = 18;
            labelManaLeft.Text = "Mana";
            // 
            // labelHealthLeft
            // 
            labelHealthLeft.AutoSize = true;
            labelHealthLeft.BackColor = SystemColors.ActiveBorder;
            labelHealthLeft.Location = new Point(109, 19);
            labelHealthLeft.Margin = new Padding(2, 0, 2, 0);
            labelHealthLeft.Name = "labelHealthLeft";
            labelHealthLeft.RightToLeft = RightToLeft.No;
            labelHealthLeft.Size = new Size(73, 15);
            labelHealthLeft.TabIndex = 16;
            labelHealthLeft.Text = "Punkty życia";
            // 
            // btnRightUse
            // 
            btnRightUse.BackColor = Color.DarkGray;
            btnRightUse.Location = new Point(294, 205);
            btnRightUse.Margin = new Padding(2);
            btnRightUse.Name = "btnRightUse";
            btnRightUse.Size = new Size(78, 20);
            btnRightUse.TabIndex = 22;
            btnRightUse.Text = "Uzyj";
            btnRightUse.UseVisualStyleBackColor = false;
            // 
            // labelSpelRight
            // 
            labelSpelRight.AutoSize = true;
            labelSpelRight.BackColor = Color.DarkGray;
            labelSpelRight.Location = new Point(155, 189);
            labelSpelRight.Margin = new Padding(2, 0, 2, 0);
            labelSpelRight.Name = "labelSpelRight";
            labelSpelRight.Size = new Size(50, 15);
            labelSpelRight.TabIndex = 21;
            labelSpelRight.Text = "Zaklecie";
            // 
            // cmbboxRightSpell
            // 
            cmbboxRightSpell.BackColor = Color.DarkGray;
            cmbboxRightSpell.FormattingEnabled = true;
            cmbboxRightSpell.Location = new Point(155, 206);
            cmbboxRightSpell.Margin = new Padding(2);
            cmbboxRightSpell.Name = "cmbboxRightSpell";
            cmbboxRightSpell.Size = new Size(129, 23);
            cmbboxRightSpell.TabIndex = 20;
            // 
            // panelRightWarrior
            // 
            panelRightWarrior.BackColor = Color.Transparent;
            panelRightWarrior.Controls.Add(btnRightUse);
            panelRightWarrior.Controls.Add(WarriorboxRight);
            panelRightWarrior.Controls.Add(labelSpelRight);
            panelRightWarrior.Controls.Add(btnRightRest);
            panelRightWarrior.Controls.Add(cmbboxRightSpell);
            panelRightWarrior.Controls.Add(btnRightForward);
            panelRightWarrior.Controls.Add(pbRightMana);
            panelRightWarrior.Controls.Add(labelRightWarrior);
            panelRightWarrior.Controls.Add(btnEightBack);
            panelRightWarrior.Controls.Add(labelManaRight);
            panelRightWarrior.Controls.Add(pbRightHP);
            panelRightWarrior.Controls.Add(btnRightAtack);
            panelRightWarrior.Controls.Add(labelHealthRight);
            panelRightWarrior.Location = new Point(740, 277);
            panelRightWarrior.Name = "panelRightWarrior";
            panelRightWarrior.Size = new Size(381, 256);
            panelRightWarrior.TabIndex = 22;
            // 
            // panelLeftWarrior
            // 
            panelLeftWarrior.BackColor = Color.Transparent;
            panelLeftWarrior.Controls.Add(btnLeftUse);
            panelLeftWarrior.Controls.Add(WarriorboxLeft);
            panelLeftWarrior.Controls.Add(labelSpelLeft);
            panelLeftWarrior.Controls.Add(labelLeftWarrior);
            panelLeftWarrior.Controls.Add(cmbboxLeftSpell);
            panelLeftWarrior.Controls.Add(pbLeftMana);
            panelLeftWarrior.Controls.Add(pbLeftHP);
            panelLeftWarrior.Controls.Add(btnLeftAtack);
            panelLeftWarrior.Controls.Add(labelHealthLeft);
            panelLeftWarrior.Controls.Add(labelManaLeft);
            panelLeftWarrior.Controls.Add(btnLeftForward);
            panelLeftWarrior.Controls.Add(btnLeftRest);
            panelLeftWarrior.Controls.Add(btnLeftBack);
            panelLeftWarrior.Location = new Point(332, 277);
            panelLeftWarrior.Name = "panelLeftWarrior";
            panelLeftWarrior.Size = new Size(362, 256);
            panelLeftWarrior.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(314, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(244, 73);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(280, 96);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "Bot zadal: 5 obrazen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.battleBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1420, 583);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panelLeftWarrior);
            Controls.Add(panelRightWarrior);
            Name = "Form1";
            Text = "SwordAndSandals";
            ((System.ComponentModel.ISupportInitialize)WarriorboxLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarriorboxRight).EndInit();
            panelRightWarrior.ResumeLayout(false);
            panelRightWarrior.PerformLayout();
            panelLeftWarrior.ResumeLayout(false);
            panelLeftWarrior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label labelLeftWarrior;
        public Label labelRightWarrior;
        public PictureBox WarriorboxLeft;
        public PictureBox WarriorboxRight;
        public Button btnLeftAtack;
        public Button btnRightAtack;
        public ProgressBar pbLeftHP;
        public ProgressBar pbLeftMana;
        public ProgressBar pbRightHP;
        public ProgressBar pbRightMana;
        public Button btnLeftRest;
        public Button btnRightRest;
        public Button btnLeftForward;
        public Button btnRightForward;
        public Button btnLeftBack;
        public Button btnEightBack;
        public Label labelHealthRight;
        public Label labelManaRight;
        public ComboBox cmbboxLeftSpell;
        public ComboBox cmbboxRightSpell;
        public Button btnLeftUse;
        public Label labelSpelLeft;
        public Button btnRightUse;
        public Label labelSpelRight;
        public Label labelManaLeft;
        public Label labelHealthLeft;
        public DoubleBufferedPanel panelRightWarrior;
        public DoubleBufferedPanel panelLeftWarrior;
        public PictureBox pictureBox1;
        public RichTextBox richTextBox1;
    }

}
