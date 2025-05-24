namespace SwordAndSandals
{
    partial class StartGame
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
            StartGameGB = new GroupBox();
            VitalityUpDown = new NumericUpDown();
            AgilityUpDown = new NumericUpDown();
            StrenghtUpDown = new NumericUpDown();
            IntUpDown = new NumericUpDown();
            StartGameButton = new Button();
            label1 = new Label();
            NameTextBox = new TextBox();
            PointsLeftLabel = new Label();
            StartGameGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VitalityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgilityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StrenghtUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntUpDown).BeginInit();
            SuspendLayout();
            // 
            // StartGameGB
            // 
            StartGameGB.BackColor = SystemColors.ActiveBorder;
            StartGameGB.Controls.Add(PointsLeftLabel);
            StartGameGB.Controls.Add(VitalityUpDown);
            StartGameGB.Controls.Add(AgilityUpDown);
            StartGameGB.Controls.Add(StrenghtUpDown);
            StartGameGB.Controls.Add(IntUpDown);
            StartGameGB.Controls.Add(StartGameButton);
            StartGameGB.Controls.Add(label1);
            StartGameGB.Controls.Add(NameTextBox);
            StartGameGB.Location = new Point(484, 129);
            StartGameGB.Name = "StartGameGB";
            StartGameGB.Size = new Size(444, 336);
            StartGameGB.TabIndex = 0;
            StartGameGB.TabStop = false;
            // 
            // VitalityUpDown
            // 
            VitalityUpDown.Location = new Point(28, 216);
            VitalityUpDown.Name = "VitalityUpDown";
            VitalityUpDown.Size = new Size(100, 23);
            VitalityUpDown.TabIndex = 6;
            // 
            // AgilityUpDown
            // 
            AgilityUpDown.Location = new Point(28, 187);
            AgilityUpDown.Name = "AgilityUpDown";
            AgilityUpDown.Size = new Size(100, 23);
            AgilityUpDown.TabIndex = 5;
            // 
            // StrenghtUpDown
            // 
            StrenghtUpDown.Location = new Point(28, 158);
            StrenghtUpDown.Name = "StrenghtUpDown";
            StrenghtUpDown.Size = new Size(100, 23);
            StrenghtUpDown.TabIndex = 4;
            // 
            // IntUpDown
            // 
            IntUpDown.Location = new Point(28, 129);
            IntUpDown.Name = "IntUpDown";
            IntUpDown.Size = new Size(100, 23);
            IntUpDown.TabIndex = 3;
            // 
            // StartGameButton
            // 
            StartGameButton.Location = new Point(176, 273);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(75, 23);
            StartGameButton.TabIndex = 2;
            StartGameButton.Text = "Zacznij grę";
            StartGameButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 55);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Podaj Nazwe";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(28, 73);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 0;
            // 
            // PointsLeftLabel
            // 
            PointsLeftLabel.AutoSize = true;
            PointsLeftLabel.Location = new Point(28, 111);
            PointsLeftLabel.Name = "PointsLeftLabel";
            PointsLeftLabel.Size = new Size(0, 15);
            PointsLeftLabel.TabIndex = 7;
            // 
            // StartGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.battleBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1420, 583);
            Controls.Add(StartGameGB);
            Name = "StartGame";
            Text = "StartGame";
            StartGameGB.ResumeLayout(false);
            StartGameGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VitalityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgilityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)StrenghtUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox StartGameGB;
        private Label label1;
        private TextBox NameTextBox;
        private Button StartGameButton;
        private NumericUpDown VitalityUpDown;
        private NumericUpDown AgilityUpDown;
        private NumericUpDown StrenghtUpDown;
        private NumericUpDown IntUpDown;
        private Label PointsLeftLabel;
    }
}