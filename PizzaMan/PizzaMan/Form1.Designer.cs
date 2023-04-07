namespace PizzaMan
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLarge = new System.Windows.Forms.TextBox();
            this.tbMid = new System.Windows.Forms.TextBox();
            this.tbSmall = new System.Windows.Forms.TextBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMid = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbKetchup = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbHotPeppers = new System.Windows.Forms.CheckBox();
            this.tbKetchup = new System.Windows.Forms.TextBox();
            this.tbExtraCheese = new System.Windows.Forms.TextBox();
            this.tbHotPeppers = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBeerPrice = new System.Windows.Forms.TextBox();
            this.tbBeerTotal = new System.Windows.Forms.TextBox();
            this.tbBeerQuantity = new System.Windows.Forms.TextBox();
            this.tbAppleJuicePrice = new System.Windows.Forms.TextBox();
            this.tbAppleTotal = new System.Windows.Forms.TextBox();
            this.tbAppleJuiceQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSodaPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotalSoda = new System.Windows.Forms.TextBox();
            this.tbQuantitySoda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbDessert = new System.Windows.Forms.ListBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.tbPriceOfDesert = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbChange = new System.Windows.Forms.TextBox();
            this.tbPaid = new System.Windows.Forms.TextBox();
            this.tbTotalToPlay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLarge);
            this.groupBox1.Controls.Add(this.tbMid);
            this.groupBox1.Controls.Add(this.tbSmall);
            this.groupBox1.Controls.Add(this.rbLarge);
            this.groupBox1.Controls.Add(this.rbMid);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Location = new System.Drawing.Point(26, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // tbLarge
            // 
            this.tbLarge.Location = new System.Drawing.Point(147, 100);
            this.tbLarge.Name = "tbLarge";
            this.tbLarge.Size = new System.Drawing.Size(100, 20);
            this.tbLarge.TabIndex = 5;
            this.tbLarge.Text = "500";
            // 
            // tbMid
            // 
            this.tbMid.Location = new System.Drawing.Point(147, 74);
            this.tbMid.Name = "tbMid";
            this.tbMid.Size = new System.Drawing.Size(100, 20);
            this.tbMid.TabIndex = 4;
            this.tbMid.Text = "300";
            // 
            // tbSmall
            // 
            this.tbSmall.Location = new System.Drawing.Point(147, 48);
            this.tbSmall.Name = "tbSmall";
            this.tbSmall.Size = new System.Drawing.Size(100, 20);
            this.tbSmall.TabIndex = 3;
            this.tbSmall.Text = "200";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(19, 94);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMid
            // 
            this.rbMid.AutoSize = true;
            this.rbMid.Location = new System.Drawing.Point(19, 71);
            this.rbMid.Name = "rbMid";
            this.rbMid.Size = new System.Drawing.Size(42, 17);
            this.rbMid.TabIndex = 1;
            this.rbMid.TabStop = true;
            this.rbMid.Text = "Mid";
            this.rbMid.UseVisualStyleBackColor = true;
            this.rbMid.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(19, 48);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbKetchup);
            this.groupBox2.Controls.Add(this.cbExtraCheese);
            this.groupBox2.Controls.Add(this.cbHotPeppers);
            this.groupBox2.Controls.Add(this.tbKetchup);
            this.groupBox2.Controls.Add(this.tbExtraCheese);
            this.groupBox2.Controls.Add(this.tbHotPeppers);
            this.groupBox2.Location = new System.Drawing.Point(421, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additions";
            // 
            // cbKetchup
            // 
            this.cbKetchup.AutoSize = true;
            this.cbKetchup.Location = new System.Drawing.Point(6, 103);
            this.cbKetchup.Name = "cbKetchup";
            this.cbKetchup.Size = new System.Drawing.Size(66, 17);
            this.cbKetchup.TabIndex = 3;
            this.cbKetchup.Text = "Ketchup";
            this.cbKetchup.UseVisualStyleBackColor = true;
            this.cbKetchup.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(6, 77);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(88, 17);
            this.cbExtraCheese.TabIndex = 1;
            this.cbExtraCheese.Text = "Extra cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // cbHotPeppers
            // 
            this.cbHotPeppers.AutoSize = true;
            this.cbHotPeppers.Location = new System.Drawing.Point(6, 50);
            this.cbHotPeppers.Name = "cbHotPeppers";
            this.cbHotPeppers.Size = new System.Drawing.Size(84, 17);
            this.cbHotPeppers.TabIndex = 0;
            this.cbHotPeppers.Text = "Hot peppers";
            this.cbHotPeppers.UseVisualStyleBackColor = true;
            this.cbHotPeppers.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // tbKetchup
            // 
            this.tbKetchup.Location = new System.Drawing.Point(147, 100);
            this.tbKetchup.Name = "tbKetchup";
            this.tbKetchup.Size = new System.Drawing.Size(100, 20);
            this.tbKetchup.TabIndex = 5;
            this.tbKetchup.Text = "20";
            // 
            // tbExtraCheese
            // 
            this.tbExtraCheese.Location = new System.Drawing.Point(147, 74);
            this.tbExtraCheese.Name = "tbExtraCheese";
            this.tbExtraCheese.Size = new System.Drawing.Size(100, 20);
            this.tbExtraCheese.TabIndex = 5;
            this.tbExtraCheese.Text = "30";
            // 
            // tbHotPeppers
            // 
            this.tbHotPeppers.Location = new System.Drawing.Point(147, 48);
            this.tbHotPeppers.Name = "tbHotPeppers";
            this.tbHotPeppers.Size = new System.Drawing.Size(100, 20);
            this.tbHotPeppers.TabIndex = 4;
            this.tbHotPeppers.Text = "40";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBeerPrice);
            this.groupBox3.Controls.Add(this.tbBeerTotal);
            this.groupBox3.Controls.Add(this.tbBeerQuantity);
            this.groupBox3.Controls.Add(this.tbAppleJuicePrice);
            this.groupBox3.Controls.Add(this.tbAppleTotal);
            this.groupBox3.Controls.Add(this.tbAppleJuiceQuantity);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbSodaPrice);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbTotalSoda);
            this.groupBox3.Controls.Add(this.tbQuantitySoda);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(26, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 134);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drink";
            // 
            // tbBeerPrice
            // 
            this.tbBeerPrice.Location = new System.Drawing.Point(395, 106);
            this.tbBeerPrice.Name = "tbBeerPrice";
            this.tbBeerPrice.Size = new System.Drawing.Size(100, 20);
            this.tbBeerPrice.TabIndex = 8;
            this.tbBeerPrice.Text = "80";
            this.tbBeerPrice.TextChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // tbBeerTotal
            // 
            this.tbBeerTotal.Enabled = false;
            this.tbBeerTotal.Location = new System.Drawing.Point(538, 108);
            this.tbBeerTotal.Name = "tbBeerTotal";
            this.tbBeerTotal.Size = new System.Drawing.Size(100, 20);
            this.tbBeerTotal.TabIndex = 11;
            // 
            // tbBeerQuantity
            // 
            this.tbBeerQuantity.Location = new System.Drawing.Point(214, 108);
            this.tbBeerQuantity.Name = "tbBeerQuantity";
            this.tbBeerQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbBeerQuantity.TabIndex = 5;
            this.tbBeerQuantity.Text = "0";
            this.tbBeerQuantity.TextChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // tbAppleJuicePrice
            // 
            this.tbAppleJuicePrice.Location = new System.Drawing.Point(395, 75);
            this.tbAppleJuicePrice.Name = "tbAppleJuicePrice";
            this.tbAppleJuicePrice.Size = new System.Drawing.Size(100, 20);
            this.tbAppleJuicePrice.TabIndex = 7;
            this.tbAppleJuicePrice.Text = "70";
            this.tbAppleJuicePrice.TextChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // tbAppleTotal
            // 
            this.tbAppleTotal.Enabled = false;
            this.tbAppleTotal.Location = new System.Drawing.Point(538, 77);
            this.tbAppleTotal.Name = "tbAppleTotal";
            this.tbAppleTotal.Size = new System.Drawing.Size(100, 20);
            this.tbAppleTotal.TabIndex = 10;
            // 
            // tbAppleJuiceQuantity
            // 
            this.tbAppleJuiceQuantity.Location = new System.Drawing.Point(214, 77);
            this.tbAppleJuiceQuantity.Name = "tbAppleJuiceQuantity";
            this.tbAppleJuiceQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbAppleJuiceQuantity.TabIndex = 4;
            this.tbAppleJuiceQuantity.Text = "0";
            this.tbAppleJuiceQuantity.TextChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total";
            // 
            // tbSodaPrice
            // 
            this.tbSodaPrice.Location = new System.Drawing.Point(395, 43);
            this.tbSodaPrice.Name = "tbSodaPrice";
            this.tbSodaPrice.Size = new System.Drawing.Size(100, 20);
            this.tbSodaPrice.TabIndex = 6;
            this.tbSodaPrice.Text = "60";
            this.tbSodaPrice.TextChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // tbTotalSoda
            // 
            this.tbTotalSoda.Enabled = false;
            this.tbTotalSoda.Location = new System.Drawing.Point(538, 45);
            this.tbTotalSoda.Name = "tbTotalSoda";
            this.tbTotalSoda.Size = new System.Drawing.Size(100, 20);
            this.tbTotalSoda.TabIndex = 9;
            // 
            // tbQuantitySoda
            // 
            this.tbQuantitySoda.Location = new System.Drawing.Point(214, 43);
            this.tbQuantitySoda.Name = "tbQuantitySoda";
            this.tbQuantitySoda.Size = new System.Drawing.Size(100, 20);
            this.tbQuantitySoda.TabIndex = 3;
            this.tbQuantitySoda.Text = "0";
            this.tbQuantitySoda.TextChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Beer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apple Juice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coca cola / Fanta / Sprite (Clean) ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnOrder);
            this.groupBox4.Controls.Add(this.lbDessert);
            this.groupBox4.Controls.Add(this.textBox21);
            this.groupBox4.Controls.Add(this.tbPriceOfDesert);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(26, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 135);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dessert";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(155, 63);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbDessert
            // 
            this.lbDessert.FormattingEnabled = true;
            this.lbDessert.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lbDessert.Location = new System.Drawing.Point(12, 19);
            this.lbDessert.Name = "lbDessert";
            this.lbDessert.Size = new System.Drawing.Size(120, 95);
            this.lbDessert.TabIndex = 0;
            this.lbDessert.SelectedIndexChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(480, 65);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(91, 20);
            this.textBox21.TabIndex = 4;
            // 
            // tbPriceOfDesert
            // 
            this.tbPriceOfDesert.Location = new System.Drawing.Point(152, 37);
            this.tbPriceOfDesert.Name = "tbPriceOfDesert";
            this.tbPriceOfDesert.Size = new System.Drawing.Size(91, 20);
            this.tbPriceOfDesert.TabIndex = 2;
            this.tbPriceOfDesert.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Price of dessert:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbChange);
            this.groupBox5.Controls.Add(this.tbPaid);
            this.groupBox5.Controls.Add(this.tbTotalToPlay);
            this.groupBox5.Location = new System.Drawing.Point(421, 386);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(297, 135);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pay";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Change:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Paid:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total to pay:";
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(107, 97);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(91, 20);
            this.tbChange.TabIndex = 5;
            this.tbChange.Text = "0";
            // 
            // tbPaid
            // 
            this.tbPaid.Location = new System.Drawing.Point(107, 68);
            this.tbPaid.Name = "tbPaid";
            this.tbPaid.Size = new System.Drawing.Size(91, 20);
            this.tbPaid.TabIndex = 3;
            this.tbPaid.Text = "0";
            this.tbPaid.TextChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // tbTotalToPlay
            // 
            this.tbTotalToPlay.Location = new System.Drawing.Point(107, 37);
            this.tbTotalToPlay.Name = "tbTotalToPlay";
            this.tbTotalToPlay.Size = new System.Drawing.Size(91, 20);
            this.tbTotalToPlay.TabIndex = 1;
            this.tbTotalToPlay.Text = "200";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizza Delivery";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLarge;
        private System.Windows.Forms.TextBox tbMid;
        private System.Windows.Forms.TextBox tbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMid;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbKetchup;
        private System.Windows.Forms.TextBox tbExtraCheese;
        private System.Windows.Forms.TextBox tbHotPeppers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbBeerPrice;
        private System.Windows.Forms.TextBox tbBeerTotal;
        private System.Windows.Forms.TextBox tbBeerQuantity;
        private System.Windows.Forms.TextBox tbAppleJuicePrice;
        private System.Windows.Forms.TextBox tbAppleTotal;
        private System.Windows.Forms.TextBox tbAppleJuiceQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSodaPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotalSoda;
        private System.Windows.Forms.TextBox tbQuantitySoda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lbDessert;
        private System.Windows.Forms.TextBox tbPriceOfDesert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbKetchup;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.CheckBox cbHotPeppers;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.TextBox tbPaid;
        private System.Windows.Forms.TextBox tbTotalToPlay;
    }
}

