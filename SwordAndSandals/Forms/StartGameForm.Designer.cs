namespace SwordAndSandals
{
    partial class StartGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGameForm));
            VitalityUpDown = new NumericUpDown();
            AgilityUpDown = new NumericUpDown();
            StrenghtUpDown = new NumericUpDown();
            IntUpDown = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            ResetStatsButton = new Button();
            StartGameButton = new Button();
            PointsLeftLabel = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            NameTextBox = new TextBox();
            panel1 = new Panel();
            openFromFileButton = new Button();
            testButton = new Button();
            ((System.ComponentModel.ISupportInitialize)VitalityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgilityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StrenghtUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntUpDown).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // VitalityUpDown
            // 
            VitalityUpDown.Location = new Point(305, 233);
            VitalityUpDown.Name = "VitalityUpDown";
            VitalityUpDown.Size = new Size(100, 23);
            VitalityUpDown.TabIndex = 6;
            // 
            // AgilityUpDown
            // 
            AgilityUpDown.Location = new Point(305, 204);
            AgilityUpDown.Name = "AgilityUpDown";
            AgilityUpDown.Size = new Size(100, 23);
            AgilityUpDown.TabIndex = 5;
            // 
            // StrenghtUpDown
            // 
            StrenghtUpDown.Location = new Point(305, 175);
            StrenghtUpDown.Name = "StrenghtUpDown";
            StrenghtUpDown.Size = new Size(100, 23);
            StrenghtUpDown.TabIndex = 4;
            // 
            // IntUpDown
            // 
            IntUpDown.Location = new Point(305, 146);
            IntUpDown.Name = "IntUpDown";
            IntUpDown.Size = new Size(100, 23);
            IntUpDown.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 12.25F);
            label5.Location = new Point(131, 229);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 1;
            label5.Text = "Vitaly";
            label5.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 12.25F);
            label4.Location = new Point(131, 200);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 1;
            label4.Text = "Agility";
            label4.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 12.25F);
            label6.Location = new Point(131, 172);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 1;
            label6.Text = "Strength";
            label6.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 12.25F);
            label3.Location = new Point(131, 142);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 1;
            label3.Text = "Int";
            label3.Click += label2_Click;
            // 
            // ResetStatsButton
            // 
            ResetStatsButton.Font = new Font("Stencil", 12.25F);
            ResetStatsButton.Location = new Point(134, 262);
            ResetStatsButton.Name = "ResetStatsButton";
            ResetStatsButton.Size = new Size(96, 26);
            ResetStatsButton.TabIndex = 2;
            ResetStatsButton.Text = "Resetuj";
            ResetStatsButton.UseVisualStyleBackColor = true;
            // 
            // StartGameButton
            // 
            StartGameButton.Font = new Font("Stencil", 18.25F);
            StartGameButton.Location = new Point(305, 326);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(189, 38);
            StartGameButton.TabIndex = 2;
            StartGameButton.Text = "Rozpocznij";
            StartGameButton.UseVisualStyleBackColor = true;
            // 
            // PointsLeftLabel
            // 
            PointsLeftLabel.AutoSize = true;
            PointsLeftLabel.BackColor = Color.Transparent;
            PointsLeftLabel.Font = new Font("Stencil", 12.25F);
            PointsLeftLabel.Location = new Point(429, 113);
            PointsLeftLabel.Name = "PointsLeftLabel";
            PointsLeftLabel.Size = new Size(19, 20);
            PointsLeftLabel.TabIndex = 1;
            PointsLeftLabel.Text = "0";
            PointsLeftLabel.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 12.25F);
            label7.Location = new Point(316, 113);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 1;
            label7.Text = "Pozostalo:";
            label7.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 12.25F);
            label2.Location = new Point(131, 113);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 1;
            label2.Text = "Rozdaj statystyki";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 16.25F);
            label1.Location = new Point(131, 60);
            label1.Name = "label1";
            label1.Size = new Size(158, 26);
            label1.TabIndex = 1;
            label1.Text = "Podaj Nazwe";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(319, 63);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(148, 23);
            NameTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.backgroundFrame;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(openFromFileButton);
            panel1.Controls.Add(StartGameButton);
            panel1.Controls.Add(VitalityUpDown);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(AgilityUpDown);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(StrenghtUpDown);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(IntUpDown);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(PointsLeftLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(testButton);
            panel1.Controls.Add(ResetStatsButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(319, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 425);
            panel1.TabIndex = 1;
            // 
            // openFromFileButton
            // 
            openFromFileButton.Font = new Font("Stencil", 10.25F);
            openFromFileButton.Location = new Point(316, 282);
            openFromFileButton.Name = "openFromFileButton";
            openFromFileButton.Size = new Size(162, 38);
            openFromFileButton.TabIndex = 7;
            openFromFileButton.Text = "Wczytaj z Pliku";
            openFromFileButton.UseVisualStyleBackColor = true;
            openFromFileButton.Click += openFromFileButton_Click;
            // 
            // testButton
            // 
            testButton.Font = new Font("Stencil", 12.25F);
            testButton.Location = new Point(516, 338);
            testButton.Name = "testButton";
            testButton.Size = new Size(96, 26);
            testButton.TabIndex = 2;
            testButton.Text = "Test";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // StartGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.battleBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1420, 583);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartGameForm";
            Text = "StartGame";
            ((System.ComponentModel.ISupportInitialize)VitalityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgilityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)StrenghtUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label label1;
        public TextBox NameTextBox;
        public Button StartGameButton;
        public NumericUpDown VitalityUpDown;
        public NumericUpDown AgilityUpDown;
        public NumericUpDown StrenghtUpDown;
        public NumericUpDown IntUpDown;
        public Label label2;
        public Label label5;
        public Label label4;
        public Label label6;
        public Label label3;
        public Label PointsLeftLabel;
        public Label label7;
        public Button ResetStatsButton;
        public Panel panel1;
        public Button testButton;
        public Button openFromFileButton;
    }
}