namespace ExamQuestions
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
            this.btnDodadiIspit = new System.Windows.Forms.Button();
            this.btnDeleteIspit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnZacuvajZadaca1 = new System.Windows.Forms.Button();
            this.lbPrvaZadaca = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnZacuvajZadaca2 = new System.Windows.Forms.Button();
            this.nudPoeniZadaca2 = new System.Windows.Forms.NumericUpDown();
            this.lbVtoraZadaca = new System.Windows.Forms.ListBox();
            this.nudPoeniZadaca1 = new System.Windows.Forms.NumericUpDown();
            this.lbIspit = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeniZadaca2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeniZadaca1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIspit);
            this.groupBox1.Location = new System.Drawing.Point(44, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ispiti";
            // 
            // btnDodadiIspit
            // 
            this.btnDodadiIspit.Location = new System.Drawing.Point(101, 347);
            this.btnDodadiIspit.Name = "btnDodadiIspit";
            this.btnDodadiIspit.Size = new System.Drawing.Size(75, 23);
            this.btnDodadiIspit.TabIndex = 1;
            this.btnDodadiIspit.Text = "Dodadi ispit";
            this.btnDodadiIspit.UseVisualStyleBackColor = true;
            this.btnDodadiIspit.Click += new System.EventHandler(this.btnDodadiIspit_Click);
            // 
            // btnDeleteIspit
            // 
            this.btnDeleteIspit.Location = new System.Drawing.Point(101, 376);
            this.btnDeleteIspit.Name = "btnDeleteIspit";
            this.btnDeleteIspit.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteIspit.TabIndex = 1;
            this.btnDeleteIspit.Text = "Izbrisi ispit";
            this.btnDeleteIspit.UseVisualStyleBackColor = true;
            this.btnDeleteIspit.Click += new System.EventHandler(this.btnDeleteIspit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnZacuvajZadaca1);
            this.groupBox2.Controls.Add(this.nudPoeniZadaca1);
            this.groupBox2.Controls.Add(this.lbPrvaZadaca);
            this.groupBox2.Location = new System.Drawing.Point(432, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 244);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zadaca 1";
            // 
            // btnZacuvajZadaca1
            // 
            this.btnZacuvajZadaca1.Location = new System.Drawing.Point(242, 199);
            this.btnZacuvajZadaca1.Name = "btnZacuvajZadaca1";
            this.btnZacuvajZadaca1.Size = new System.Drawing.Size(75, 23);
            this.btnZacuvajZadaca1.TabIndex = 2;
            this.btnZacuvajZadaca1.Text = "Zacuvaj";
            this.btnZacuvajZadaca1.UseVisualStyleBackColor = true;
            // 
            // lbPrvaZadaca
            // 
            this.lbPrvaZadaca.FormattingEnabled = true;
            this.lbPrvaZadaca.Location = new System.Drawing.Point(24, 47);
            this.lbPrvaZadaca.Name = "lbPrvaZadaca";
            this.lbPrvaZadaca.Size = new System.Drawing.Size(287, 95);
            this.lbPrvaZadaca.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnZacuvajZadaca2);
            this.groupBox3.Controls.Add(this.nudPoeniZadaca2);
            this.groupBox3.Controls.Add(this.lbVtoraZadaca);
            this.groupBox3.Location = new System.Drawing.Point(432, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 244);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zadaca 2";
            // 
            // btnZacuvajZadaca2
            // 
            this.btnZacuvajZadaca2.Location = new System.Drawing.Point(242, 204);
            this.btnZacuvajZadaca2.Name = "btnZacuvajZadaca2";
            this.btnZacuvajZadaca2.Size = new System.Drawing.Size(75, 23);
            this.btnZacuvajZadaca2.TabIndex = 2;
            this.btnZacuvajZadaca2.Text = "Zacuvaj";
            this.btnZacuvajZadaca2.UseVisualStyleBackColor = true;
            // 
            // nudPoeniZadaca2
            // 
            this.nudPoeniZadaca2.Location = new System.Drawing.Point(7, 182);
            this.nudPoeniZadaca2.Name = "nudPoeniZadaca2";
            this.nudPoeniZadaca2.Size = new System.Drawing.Size(120, 20);
            this.nudPoeniZadaca2.TabIndex = 1;
            // 
            // lbVtoraZadaca
            // 
            this.lbVtoraZadaca.FormattingEnabled = true;
            this.lbVtoraZadaca.Location = new System.Drawing.Point(24, 55);
            this.lbVtoraZadaca.Name = "lbVtoraZadaca";
            this.lbVtoraZadaca.Size = new System.Drawing.Size(287, 95);
            this.lbVtoraZadaca.TabIndex = 0;
            // 
            // nudPoeniZadaca1
            // 
            this.nudPoeniZadaca1.Location = new System.Drawing.Point(24, 199);
            this.nudPoeniZadaca1.Name = "nudPoeniZadaca1";
            this.nudPoeniZadaca1.Size = new System.Drawing.Size(120, 20);
            this.nudPoeniZadaca1.TabIndex = 1;
            // 
            // lbIspit
            // 
            this.lbIspit.FormattingEnabled = true;
            this.lbIspit.Location = new System.Drawing.Point(20, 47);
            this.lbIspit.Name = "lbIspit";
            this.lbIspit.Size = new System.Drawing.Size(215, 225);
            this.lbIspit.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.btnDeleteIspit);
            this.Controls.Add(this.btnDodadiIspit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeniZadaca2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeniZadaca1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodadiIspit;
        private System.Windows.Forms.Button btnDeleteIspit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnZacuvajZadaca1;
        private System.Windows.Forms.ListBox lbPrvaZadaca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnZacuvajZadaca2;
        private System.Windows.Forms.NumericUpDown nudPoeniZadaca2;
        private System.Windows.Forms.ListBox lbVtoraZadaca;
        private System.Windows.Forms.NumericUpDown nudPoeniZadaca1;
        private System.Windows.Forms.ListBox lbIspit;
    }
}

