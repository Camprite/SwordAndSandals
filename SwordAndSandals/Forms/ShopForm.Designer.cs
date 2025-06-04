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
            label4 = new Label();
            buyButton = new Button();
            CurrentCartListBox = new ListBox();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 16.25F);
            label4.Location = new Point(553, 69);
            label4.Name = "label4";
            label4.Size = new Size(38, 26);
            label4.TabIndex = 4;
            label4.Text = "50";
            // 
            // buyButton
            // 
            buyButton.Font = new Font("Stencil", 16.25F);
            buyButton.Location = new Point(462, 554);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(123, 51);
            buyButton.TabIndex = 5;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            // 
            // CurrentCartListBox
            // 
            CurrentCartListBox.BackColor = Color.FromArgb(152, 103, 58);
            CurrentCartListBox.BorderStyle = BorderStyle.None;
            CurrentCartListBox.FormattingEnabled = true;
            CurrentCartListBox.Location = new Point(92, 484);
            CurrentCartListBox.Name = "CurrentCartListBox";
            CurrentCartListBox.Size = new Size(340, 120);
            CurrentCartListBox.TabIndex = 6;
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
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(152, 103, 58);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(506, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(186, 259);
            listBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(617, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Add to cart";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 16.25F);
            button2.Location = new Point(462, 484);
            button2.Name = "button2";
            button2.Size = new Size(123, 64);
            button2.TabIndex = 11;
            button2.Text = "Clear Cart";
            button2.UseVisualStyleBackColor = true;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundFrame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 690);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CurrentCartListBox);
            Controls.Add(buyButton);
            Controls.Add(label4);
            Controls.Add(currentMoney);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Shop";
            Text = "D";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label currentMoney;
        public Label label4;
        public Button buyButton;
        public ListBox CurrentCartListBox;
        public Label label5;
        public Label label6;
        public ListBox listBox1;
        public Button button1;
        public Button button2;
    }
}