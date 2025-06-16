using System.Security.Cryptography.X509Certificates;

namespace SwordAndSandals
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            label1 = new Label();
            label2 = new Label();
            currentMoney = new Label();
            buyButton = new Button();
            label6 = new Label();
            comboBoxWeapon = new ComboBox();
            SearchButtonWeapon = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBoxArmour = new ComboBox();
            comboBoxSpell = new ComboBox();
            SearchButtonArmour = new Button();
            SearchButtonSpell = new Button();
            exitButton = new Button();
            comboBoxWeaponEnum = new ComboBox();
            WeaponSearchResultListBox = new ListBox();
            comboBoxArmourTypeEnum = new ComboBox();
            ArmourSearchResultListBox = new ListBox();
            SpellSearchResultListBox = new ListBox();
            comboBoxSpellTypeEnum = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 57);
            label1.Name = "label1";
            label1.Size = new Size(108, 42);
            label1.TabIndex = 0;
            label1.Text = "Shop";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 16.25F);
            label2.Location = new Point(101, 69);
            label2.Name = "label2";
            label2.Size = new Size(91, 26);
            label2.TabIndex = 1;
            label2.Text = "Money:";
            // 
            // currentMoney
            // 
            currentMoney.AutoSize = true;
            currentMoney.BackColor = Color.Transparent;
            currentMoney.Font = new Font("Stencil", 16.25F);
            currentMoney.Location = new Point(183, 69);
            currentMoney.Name = "currentMoney";
            currentMoney.Size = new Size(51, 26);
            currentMoney.TabIndex = 3;
            currentMoney.Text = "100";
            currentMoney.Click += currentMoney_Click;
            // 
            // buyButton
            // 
            buyButton.Font = new Font("Stencil", 16.25F);
            buyButton.Location = new Point(445, 554);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(123, 51);
            buyButton.TabIndex = 5;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 16.25F);
            label6.Location = new Point(515, 101);
            label6.Name = "label6";
            label6.Size = new Size(96, 26);
            label6.TabIndex = 8;
            label6.Text = "Search";
            // 
            // comboBoxWeapon
            // 
            comboBoxWeapon.FormattingEnabled = true;
            comboBoxWeapon.Location = new Point(41, 159);
            comboBoxWeapon.Name = "comboBoxWeapon";
            comboBoxWeapon.Size = new Size(193, 23);
            comboBoxWeapon.TabIndex = 12;
            // 
            // SearchButtonWeapon
            // 
            SearchButtonWeapon.Font = new Font("Stencil", 10F);
            SearchButtonWeapon.Location = new Point(240, 159);
            SearchButtonWeapon.Name = "SearchButtonWeapon";
            SearchButtonWeapon.Size = new Size(80, 23);
            SearchButtonWeapon.TabIndex = 13;
            SearchButtonWeapon.Text = "Search";
            SearchButtonWeapon.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 16.25F);
            label7.Location = new Point(92, 117);
            label7.Name = "label7";
            label7.Size = new Size(112, 26);
            label7.TabIndex = 14;
            label7.Text = "Weapons";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Stencil", 16.25F);
            label8.Location = new Point(92, 306);
            label8.Name = "label8";
            label8.Size = new Size(102, 26);
            label8.TabIndex = 15;
            label8.Text = "Armour";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Stencil", 16.25F);
            label9.Location = new Point(92, 444);
            label9.Name = "label9";
            label9.Size = new Size(75, 26);
            label9.TabIndex = 16;
            label9.Text = "Spell";
            // 
            // comboBoxArmour
            // 
            comboBoxArmour.FormattingEnabled = true;
            comboBoxArmour.Location = new Point(41, 351);
            comboBoxArmour.Name = "comboBoxArmour";
            comboBoxArmour.Size = new Size(193, 23);
            comboBoxArmour.TabIndex = 17;
            // 
            // comboBoxSpell
            // 
            comboBoxSpell.FormattingEnabled = true;
            comboBoxSpell.Location = new Point(41, 502);
            comboBoxSpell.Name = "comboBoxSpell";
            comboBoxSpell.Size = new Size(193, 23);
            comboBoxSpell.TabIndex = 18;
            // 
            // SearchButtonArmour
            // 
            SearchButtonArmour.Font = new Font("Stencil", 10F);
            SearchButtonArmour.Location = new Point(240, 351);
            SearchButtonArmour.Name = "SearchButtonArmour";
            SearchButtonArmour.Size = new Size(80, 23);
            SearchButtonArmour.TabIndex = 19;
            SearchButtonArmour.Text = "Search";
            SearchButtonArmour.UseVisualStyleBackColor = true;
            // 
            // SearchButtonSpell
            // 
            SearchButtonSpell.Font = new Font("Stencil", 10F);
            SearchButtonSpell.Location = new Point(240, 502);
            SearchButtonSpell.Name = "SearchButtonSpell";
            SearchButtonSpell.Size = new Size(80, 23);
            SearchButtonSpell.TabIndex = 20;
            SearchButtonSpell.Text = "Search";
            SearchButtonSpell.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Stencil", 16.25F);
            exitButton.Location = new Point(574, 554);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(123, 51);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxWeaponEnum
            // 
            comboBoxWeaponEnum.FormattingEnabled = true;
            comboBoxWeaponEnum.Location = new Point(41, 188);
            comboBoxWeaponEnum.Name = "comboBoxWeaponEnum";
            comboBoxWeaponEnum.Size = new Size(193, 23);
            comboBoxWeaponEnum.TabIndex = 12;
            comboBoxWeaponEnum.Visible = false;
            // 
            // WeaponSearchResultListBox
            // 
            WeaponSearchResultListBox.BackColor = Color.FromArgb(152, 103, 58);
            WeaponSearchResultListBox.FormattingEnabled = true;
            WeaponSearchResultListBox.Location = new Point(337, 130);
            WeaponSearchResultListBox.Name = "WeaponSearchResultListBox";
            WeaponSearchResultListBox.Size = new Size(369, 394);
            WeaponSearchResultListBox.TabIndex = 23;
            // 
            // comboBoxArmourTypeEnum
            // 
            comboBoxArmourTypeEnum.FormattingEnabled = true;
            comboBoxArmourTypeEnum.Location = new Point(41, 393);
            comboBoxArmourTypeEnum.Name = "comboBoxArmourTypeEnum";
            comboBoxArmourTypeEnum.Size = new Size(193, 23);
            comboBoxArmourTypeEnum.TabIndex = 17;
            // 
            // ArmourSearchResultListBox
            // 
            ArmourSearchResultListBox.BackColor = Color.FromArgb(152, 103, 58);
            ArmourSearchResultListBox.FormattingEnabled = true;
            ArmourSearchResultListBox.Location = new Point(337, 131);
            ArmourSearchResultListBox.Name = "ArmourSearchResultListBox";
            ArmourSearchResultListBox.Size = new Size(369, 394);
            ArmourSearchResultListBox.TabIndex = 23;
            ArmourSearchResultListBox.Visible = false;
            // 
            // SpellSearchResultListBox
            // 
            SpellSearchResultListBox.BackColor = Color.FromArgb(152, 103, 58);
            SpellSearchResultListBox.FormattingEnabled = true;
            SpellSearchResultListBox.Location = new Point(337, 130);
            SpellSearchResultListBox.Name = "SpellSearchResultListBox";
            SpellSearchResultListBox.Size = new Size(468, 394);
            SpellSearchResultListBox.TabIndex = 23;
            SpellSearchResultListBox.Visible = false;
            // 
            // comboBoxSpellTypeEnum
            // 
            comboBoxSpellTypeEnum.FormattingEnabled = true;
            comboBoxSpellTypeEnum.Location = new Point(41, 543);
            comboBoxSpellTypeEnum.Name = "comboBoxSpellTypeEnum";
            comboBoxSpellTypeEnum.Size = new Size(193, 23);
            comboBoxSpellTypeEnum.TabIndex = 24;
            comboBoxSpellTypeEnum.Visible = false;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundFrame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(899, 690);
            Controls.Add(comboBoxSpellTypeEnum);
            Controls.Add(SpellSearchResultListBox);
            Controls.Add(ArmourSearchResultListBox);
            Controls.Add(WeaponSearchResultListBox);
            Controls.Add(SearchButtonSpell);
            Controls.Add(SearchButtonArmour);
            Controls.Add(comboBoxSpell);
            Controls.Add(comboBoxArmourTypeEnum);
            Controls.Add(comboBoxArmour);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(SearchButtonWeapon);
            Controls.Add(comboBoxWeaponEnum);
            Controls.Add(comboBoxWeapon);
            Controls.Add(label6);
            Controls.Add(exitButton);
            Controls.Add(buyButton);
            Controls.Add(currentMoney);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShopForm";
            Text = "Shop";
            Load += ShopForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label currentMoney;
        public Button buyButton;
        public ListBox CurrentCartListBox;
        public Label label6;
        public ComboBox comboBoxWeapon;
        public Button SearchButton;
        public Label label7;
        public Label label8;
        public Label label9;
        public ComboBox comboBoxArmour;
        public ComboBox comboBoxSpell;
        public Button button3;
        public Button button4;
        public Button SearchButtonWeapon;
        public Button SearchButtonSpell;
        public Button SearchButtonArmour;
        public Button exitButton;
        public ComboBox comboBoxWeaponEnum;
        public ListBox WeaponSearchResultListBox;
        public ComboBox comboBoxArmourTypeEnum;
        public ListBox ArmourSearchResultListBox;
        public ListBox SpellSearchResultListBox;
        public ComboBox comboBoxSpellTypeEnum;
    }
}