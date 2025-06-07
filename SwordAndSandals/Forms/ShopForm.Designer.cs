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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            currentMoney = new Label();
            cartValue = new Label();
            buyButton = new Button();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBoxWeapon = new ComboBox();
            SearchButtonWeapon = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBoxArmour = new ComboBox();
            comboBoxSpell = new ComboBox();
            SearchButtonArmour = new Button();
            SearchButtonSpell = new Button();
            SearchResultList = new RichTextBox();
            CurrentCartList = new RichTextBox();
            exitButton = new Button();
            comboBoxWeaponEnum = new ComboBox();
            SearchResultListBox = new ListBox();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 16.25F);
            label3.Location = new Point(473, 69);
            label3.Name = "label3";
            label3.Size = new Size(74, 26);
            label3.TabIndex = 2;
            label3.Text = "Cart:";
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
            // cartValue
            // 
            cartValue.AutoSize = true;
            cartValue.BackColor = Color.Transparent;
            cartValue.Font = new Font("Stencil", 16.25F);
            cartValue.Location = new Point(553, 69);
            cartValue.Name = "cartValue";
            cartValue.Size = new Size(38, 26);
            cartValue.TabIndex = 4;
            cartValue.Text = "50";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 16.25F);
            label5.Location = new Point(92, 451);
            label5.Name = "label5";
            label5.Size = new Size(74, 26);
            label5.TabIndex = 7;
            label5.Text = "Cart:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 16.25F);
            label6.Location = new Point(321, 101);
            label6.Name = "label6";
            label6.Size = new Size(96, 26);
            label6.TabIndex = 8;
            label6.Text = "Search";
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 16.25F);
            button1.Location = new Point(485, 398);
            button1.Name = "button1";
            button1.Size = new Size(172, 41);
            button1.TabIndex = 10;
            button1.Text = "Add to cart";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 16.25F);
            button2.Location = new Point(445, 484);
            button2.Name = "button2";
            button2.Size = new Size(123, 64);
            button2.TabIndex = 11;
            button2.Text = "Clear Cart";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxWeapon
            // 
            comboBoxWeapon.FormattingEnabled = true;
            comboBoxWeapon.Location = new Point(92, 159);
            comboBoxWeapon.Name = "comboBoxWeapon";
            comboBoxWeapon.Size = new Size(121, 23);
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
            label8.Location = new Point(92, 225);
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
            label9.Location = new Point(92, 311);
            label9.Name = "label9";
            label9.Size = new Size(75, 26);
            label9.TabIndex = 16;
            label9.Text = "Spell";
            // 
            // comboBoxArmour
            // 
            comboBoxArmour.FormattingEnabled = true;
            comboBoxArmour.Location = new Point(92, 270);
            comboBoxArmour.Name = "comboBoxArmour";
            comboBoxArmour.Size = new Size(121, 23);
            comboBoxArmour.TabIndex = 17;
            // 
            // comboBoxSpell
            // 
            comboBoxSpell.FormattingEnabled = true;
            comboBoxSpell.Location = new Point(92, 369);
            comboBoxSpell.Name = "comboBoxSpell";
            comboBoxSpell.Size = new Size(121, 23);
            comboBoxSpell.TabIndex = 18;
            // 
            // SearchButtonArmour
            // 
            SearchButtonArmour.Font = new Font("Stencil", 10F);
            SearchButtonArmour.Location = new Point(240, 270);
            SearchButtonArmour.Name = "SearchButtonArmour";
            SearchButtonArmour.Size = new Size(80, 23);
            SearchButtonArmour.TabIndex = 19;
            SearchButtonArmour.Text = "Search";
            SearchButtonArmour.UseVisualStyleBackColor = true;
            // 
            // SearchButtonSpell
            // 
            SearchButtonSpell.Font = new Font("Stencil", 10F);
            SearchButtonSpell.Location = new Point(240, 369);
            SearchButtonSpell.Name = "SearchButtonSpell";
            SearchButtonSpell.Size = new Size(80, 23);
            SearchButtonSpell.TabIndex = 20;
            SearchButtonSpell.Text = "Search";
            SearchButtonSpell.UseVisualStyleBackColor = true;
            // 
            // SearchResultList
            // 
            SearchResultList.BackColor = Color.FromArgb(152, 103, 58);
            SearchResultList.Location = new Point(609, 74);
            SearchResultList.Name = "SearchResultList";
            SearchResultList.Size = new Size(260, 291);
            SearchResultList.TabIndex = 21;
            SearchResultList.Text = "";
            // 
            // CurrentCartList
            // 
            CurrentCartList.BackColor = Color.FromArgb(152, 103, 58);
            CurrentCartList.Location = new Point(85, 484);
            CurrentCartList.Name = "CurrentCartList";
            CurrentCartList.Size = new Size(332, 111);
            CurrentCartList.TabIndex = 22;
            CurrentCartList.Text = "";
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
            comboBoxWeaponEnum.Location = new Point(92, 188);
            comboBoxWeaponEnum.Name = "comboBoxWeaponEnum";
            comboBoxWeaponEnum.Size = new Size(121, 23);
            comboBoxWeaponEnum.TabIndex = 12;
            comboBoxWeaponEnum.Visible = false;
            // 
            // SearchResultListBox
            // 
            SearchResultListBox.FormattingEnabled = true;
            SearchResultListBox.Location = new Point(445, 117);
            SearchResultListBox.Name = "SearchResultListBox";
            SearchResultListBox.Size = new Size(158, 244);
            SearchResultListBox.TabIndex = 23;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundFrame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 690);
            Controls.Add(SearchResultListBox);
            Controls.Add(CurrentCartList);
            Controls.Add(SearchResultList);
            Controls.Add(SearchButtonSpell);
            Controls.Add(SearchButtonArmour);
            Controls.Add(comboBoxSpell);
            Controls.Add(comboBoxArmour);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(SearchButtonWeapon);
            Controls.Add(comboBoxWeaponEnum);
            Controls.Add(comboBoxWeapon);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(exitButton);
            Controls.Add(buyButton);
            Controls.Add(cartValue);
            Controls.Add(currentMoney);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShopForm";
            Text = "Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label currentMoney;
        public Label cartValue;
        public Button buyButton;
        public ListBox CurrentCartListBox;
        public Label label5;
        public Label label6;
        public Button button1;
        public Button button2;
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
        private RichTextBox CurrentCartList;
        public Button exitButton;
        public ComboBox comboBoxWeaponEnum;
        public RichTextBox SearchResultList;
        public ListBox SearchResultListBox;
    }
}