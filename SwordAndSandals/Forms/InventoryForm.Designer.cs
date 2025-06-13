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
            pictureBox1.Location = new Point(565, 357);
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
            comboBoxShield.Location = new Point(364, 386);
            comboBoxShield.Name = "comboBoxShield";
            comboBoxShield.Size = new Size(195, 23);
            comboBoxShield.TabIndex = 5;
            // 
            // comboBoxChestplate
            // 
            comboBoxChestplate.FormattingEnabled = true;
            comboBoxChestplate.Location = new Point(731, 386);
            comboBoxChestplate.Name = "comboBoxChestplate";
            comboBoxChestplate.Size = new Size(195, 23);
            comboBoxChestplate.TabIndex = 6;
            comboBoxChestplate.SelectedIndexChanged += comboBoxChestplate_SelectedIndexChanged;
            // 
            // comboBoxSandals
            // 
            comboBoxSandals.FormattingEnabled = true;
            comboBoxSandals.Location = new Point(364, 519);
            comboBoxSandals.Name = "comboBoxSandals";
            comboBoxSandals.Size = new Size(195, 23);
            comboBoxSandals.TabIndex = 7;
            // 
            // comboBoxHelmet
            // 
            comboBoxHelmet.FormattingEnabled = true;
            comboBoxHelmet.Location = new Point(556, 313);
            comboBoxHelmet.Name = "comboBoxHelmet";
            comboBoxHelmet.Size = new Size(195, 23);
            comboBoxHelmet.TabIndex = 8;
            // 
            // comboBoxWeapon
            // 
            comboBoxWeapon.FormattingEnabled = true;
            comboBoxWeapon.Location = new Point(731, 519);
            comboBoxWeapon.Name = "comboBoxWeapon";
            comboBoxWeapon.Size = new Size(195, 23);
            comboBoxWeapon.TabIndex = 9;
            comboBoxWeapon.SelectedIndexChanged += comboBoxWeapon_SelectedIndexChanged;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InventoryBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1305, 745);
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
    }
}