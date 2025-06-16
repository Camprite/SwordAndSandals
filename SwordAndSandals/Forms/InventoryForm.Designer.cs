namespace SwordAndSandals
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            saveEquipment = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxShield = new ComboBox();
            comboBoxChestplate = new ComboBox();
            comboBoxSandals = new ComboBox();
            comboBoxHelmet = new ComboBox();
            comboBoxWeapon = new ComboBox();
            Current = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            helmetLabel = new Label();
            label9 = new Label();
            shieldLabel = new Label();
            sandalsLabel = new Label();
            chestplateLabel = new Label();
            waeponLabel = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // saveEquipment
            // 
            saveEquipment.Font = new Font("Stencil", 16.25F);
            saveEquipment.Location = new Point(486, 616);
            saveEquipment.Name = "saveEquipment";
            saveEquipment.Size = new Size(124, 44);
            saveEquipment.TabIndex = 0;
            saveEquipment.Text = "Save";
            saveEquipment.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Stencil", 16.25F);
            exitButton.Location = new Point(686, 616);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(124, 44);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.gladiatorwyciety;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(565, 390);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 220);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 16.25F);
            label1.Location = new Point(616, 284);
            label1.Name = "label1";
            label1.Size = new Size(97, 26);
            label1.TabIndex = 3;
            label1.Text = "Helmet";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 16.25F);
            label2.Location = new Point(777, 490);
            label2.Name = "label2";
            label2.Size = new Size(100, 26);
            label2.TabIndex = 3;
            label2.Text = "Weapon";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 16.25F);
            label3.Location = new Point(763, 357);
            label3.Name = "label3";
            label3.Size = new Size(146, 26);
            label3.TabIndex = 4;
            label3.Text = "Chestplate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 16.25F);
            label4.Location = new Point(415, 357);
            label4.Name = "label4";
            label4.Size = new Size(89, 26);
            label4.TabIndex = 4;
            label4.Text = "Shield";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 16.25F);
            label5.Location = new Point(415, 490);
            label5.Name = "label5";
            label5.Size = new Size(105, 26);
            label5.TabIndex = 4;
            label5.Text = "Sandals";
            // 
            // comboBoxShield
            // 
            comboBoxShield.FormattingEnabled = true;
            comboBoxShield.Location = new Point(364, 436);
            comboBoxShield.Name = "comboBoxShield";
            comboBoxShield.Size = new Size(195, 23);
            comboBoxShield.TabIndex = 5;
            // 
            // comboBoxChestplate
            // 
            comboBoxChestplate.FormattingEnabled = true;
            comboBoxChestplate.Location = new Point(731, 436);
            comboBoxChestplate.Name = "comboBoxChestplate";
            comboBoxChestplate.Size = new Size(195, 23);
            comboBoxChestplate.TabIndex = 6;
            comboBoxChestplate.SelectedIndexChanged += comboBoxChestplate_SelectedIndexChanged;
            // 
            // comboBoxSandals
            // 
            comboBoxSandals.FormattingEnabled = true;
            comboBoxSandals.Location = new Point(364, 564);
            comboBoxSandals.Name = "comboBoxSandals";
            comboBoxSandals.Size = new Size(195, 23);
            comboBoxSandals.TabIndex = 7;
            // 
            // comboBoxHelmet
            // 
            comboBoxHelmet.FormattingEnabled = true;
            comboBoxHelmet.Location = new Point(562, 341);
            comboBoxHelmet.Name = "comboBoxHelmet";
            comboBoxHelmet.Size = new Size(195, 23);
            comboBoxHelmet.TabIndex = 8;
            // 
            // comboBoxWeapon
            // 
            comboBoxWeapon.FormattingEnabled = true;
            comboBoxWeapon.Location = new Point(731, 564);
            comboBoxWeapon.Name = "comboBoxWeapon";
            comboBoxWeapon.Size = new Size(195, 23);
            comboBoxWeapon.TabIndex = 9;
            comboBoxWeapon.SelectedIndexChanged += comboBoxWeapon_SelectedIndexChanged;
            // 
            // Current
            // 
            Current.AutoSize = true;
            Current.BackColor = Color.Transparent;
            Current.Font = new Font("Stencil", 9.9F);
            Current.Location = new Point(540, 304);
            Current.Name = "Current";
            Current.Size = new Size(70, 17);
            Current.TabIndex = 10;
            Current.Text = "Current";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 9.9F);
            label6.Location = new Point(350, 390);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 10;
            label6.Text = "Current";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 9.9F);
            label7.Location = new Point(350, 516);
            label7.Name = "label7";
            label7.Size = new Size(70, 17);
            label7.TabIndex = 10;
            label7.Text = "Current";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Stencil", 9.9F);
            label8.Location = new Point(731, 390);
            label8.Name = "label8";
            label8.Size = new Size(70, 17);
            label8.TabIndex = 10;
            label8.Text = "Current";
            // 
            // helmetLabel
            // 
            helmetLabel.AutoSize = true;
            helmetLabel.BackColor = Color.Transparent;
            helmetLabel.Font = new Font("Stencil", 9.9F);
            helmetLabel.Location = new Point(616, 304);
            helmetLabel.Name = "helmetLabel";
            helmetLabel.Size = new Size(0, 17);
            helmetLabel.TabIndex = 11;
            helmetLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Stencil", 9.9F);
            label9.Location = new Point(616, 304);
            label9.Name = "label9";
            label9.Size = new Size(0, 17);
            label9.TabIndex = 11;
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // shieldLabel
            // 
            shieldLabel.AutoSize = true;
            shieldLabel.BackColor = Color.Transparent;
            shieldLabel.Font = new Font("Stencil", 9.9F);
            shieldLabel.Location = new Point(426, 390);
            shieldLabel.Name = "shieldLabel";
            shieldLabel.Size = new Size(0, 17);
            shieldLabel.TabIndex = 12;
            shieldLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sandalsLabel
            // 
            sandalsLabel.AutoSize = true;
            sandalsLabel.BackColor = Color.Transparent;
            sandalsLabel.Font = new Font("Stencil", 9.9F);
            sandalsLabel.Location = new Point(426, 516);
            sandalsLabel.Name = "sandalsLabel";
            sandalsLabel.Size = new Size(0, 17);
            sandalsLabel.TabIndex = 13;
            sandalsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chestplateLabel
            // 
            chestplateLabel.AutoSize = true;
            chestplateLabel.BackColor = Color.Transparent;
            chestplateLabel.Font = new Font("Stencil", 9.9F);
            chestplateLabel.Location = new Point(801, 390);
            chestplateLabel.Name = "chestplateLabel";
            chestplateLabel.Size = new Size(0, 17);
            chestplateLabel.TabIndex = 14;
            chestplateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // waeponLabel
            // 
            waeponLabel.AutoSize = true;
            waeponLabel.BackColor = Color.Transparent;
            waeponLabel.Font = new Font("Stencil", 9.9F);
            waeponLabel.Location = new Point(801, 516);
            waeponLabel.Name = "waeponLabel";
            waeponLabel.Size = new Size(0, 17);
            waeponLabel.TabIndex = 15;
            waeponLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Stencil", 9.9F);
            label10.Location = new Point(731, 516);
            label10.Name = "label10";
            label10.Size = new Size(70, 17);
            label10.TabIndex = 16;
            label10.Text = "Current";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InventoryBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1305, 745);
            Controls.Add(label10);
            Controls.Add(waeponLabel);
            Controls.Add(chestplateLabel);
            Controls.Add(sandalsLabel);
            Controls.Add(shieldLabel);
            Controls.Add(label9);
            Controls.Add(helmetLabel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Current);
            Controls.Add(comboBoxWeapon);
            Controls.Add(comboBoxHelmet);
            Controls.Add(comboBoxSandals);
            Controls.Add(comboBoxChestplate);
            Controls.Add(comboBoxShield);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(saveEquipment);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InventoryForm";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button saveEquipment;
        public Button exitButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public ComboBox comboBoxShield;
        public ComboBox comboBoxChestplate;
        public ComboBox comboBoxSandals;
        public ComboBox comboBoxHelmet;
        public ComboBox comboBoxWeapon;
        private Label Current;
        private Label label6;
        private Label label7;
        private Label label8;
        public Label helmetLabel;
        public Label label9;
        public Label shieldLabel;
        public Label sandalsLabel;
        public Label chestplateLabel;
        public Label waeponLabel;
        private Label label10;
    }
}