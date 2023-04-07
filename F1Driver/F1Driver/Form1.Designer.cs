namespace F1Driver
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
            this.Vozaci = new System.Windows.Forms.GroupBox();
            this.btnIzbrisiVozac = new System.Windows.Forms.Button();
            this.lbVozaci = new System.Windows.Forms.ListBox();
            this.btnDodadiVozac = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbKrugovi = new System.Windows.Forms.ListBox();
            this.tbNajdobarKrug = new System.Windows.Forms.TextBox();
            this.btnAddKrug = new System.Windows.Forms.Button();
            this.nudSekundi = new System.Windows.Forms.NumericUpDown();
            this.nudMinuti = new System.Windows.Forms.NumericUpDown();
            this.nudVreme = new System.Windows.Forms.NumericUpDown();
            this.Vozaci.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekundi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).BeginInit();
            this.SuspendLayout();
            // 
            // Vozaci
            // 
            this.Vozaci.Controls.Add(this.btnIzbrisiVozac);
            this.Vozaci.Controls.Add(this.lbVozaci);
            this.Vozaci.Controls.Add(this.btnDodadiVozac);
            this.Vozaci.Location = new System.Drawing.Point(70, 70);
            this.Vozaci.Name = "Vozaci";
            this.Vozaci.Size = new System.Drawing.Size(337, 507);
            this.Vozaci.TabIndex = 0;
            this.Vozaci.TabStop = false;
            this.Vozaci.Text = "Vozaci";
            // 
            // btnIzbrisiVozac
            // 
            this.btnIzbrisiVozac.Location = new System.Drawing.Point(98, 397);
            this.btnIzbrisiVozac.Name = "btnIzbrisiVozac";
            this.btnIzbrisiVozac.Size = new System.Drawing.Size(152, 23);
            this.btnIzbrisiVozac.TabIndex = 1;
            this.btnIzbrisiVozac.Text = "Delete vozac";
            this.btnIzbrisiVozac.UseVisualStyleBackColor = true;
            this.btnIzbrisiVozac.Click += new System.EventHandler(this.btnIzbrisiVozac_Click);
            // 
            // lbVozaci
            // 
            this.lbVozaci.FormattingEnabled = true;
            this.lbVozaci.Location = new System.Drawing.Point(20, 44);
            this.lbVozaci.Name = "lbVozaci";
            this.lbVozaci.Size = new System.Drawing.Size(289, 303);
            this.lbVozaci.TabIndex = 0;
            this.lbVozaci.SelectedIndexChanged += new System.EventHandler(this.lbVozaci_SelectedIndexChanged);
            // 
            // btnDodadiVozac
            // 
            this.btnDodadiVozac.Location = new System.Drawing.Point(98, 365);
            this.btnDodadiVozac.Name = "btnDodadiVozac";
            this.btnDodadiVozac.Size = new System.Drawing.Size(152, 23);
            this.btnDodadiVozac.TabIndex = 1;
            this.btnDodadiVozac.Text = "Dodadi Vozac";
            this.btnDodadiVozac.UseVisualStyleBackColor = true;
            this.btnDodadiVozac.Click += new System.EventHandler(this.btnDodadiVozac_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbKrugovi);
            this.groupBox2.Controls.Add(this.tbNajdobarKrug);
            this.groupBox2.Controls.Add(this.btnAddKrug);
            this.groupBox2.Controls.Add(this.nudSekundi);
            this.groupBox2.Controls.Add(this.nudMinuti);
            this.groupBox2.Controls.Add(this.nudVreme);
            this.groupBox2.Location = new System.Drawing.Point(485, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 507);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Krugovi";
            // 
            // lbKrugovi
            // 
            this.lbKrugovi.FormattingEnabled = true;
            this.lbKrugovi.Location = new System.Drawing.Point(6, 44);
            this.lbKrugovi.Name = "lbKrugovi";
            this.lbKrugovi.Size = new System.Drawing.Size(315, 199);
            this.lbKrugovi.TabIndex = 5;
            // 
            // tbNajdobarKrug
            // 
            this.tbNajdobarKrug.Enabled = false;
            this.tbNajdobarKrug.Location = new System.Drawing.Point(29, 334);
            this.tbNajdobarKrug.Name = "tbNajdobarKrug";
            this.tbNajdobarKrug.Size = new System.Drawing.Size(292, 20);
            this.tbNajdobarKrug.TabIndex = 4;
            // 
            // btnAddKrug
            // 
            this.btnAddKrug.Location = new System.Drawing.Point(246, 305);
            this.btnAddKrug.Name = "btnAddKrug";
            this.btnAddKrug.Size = new System.Drawing.Size(75, 23);
            this.btnAddKrug.TabIndex = 1;
            this.btnAddKrug.Text = "Dodadi krug";
            this.btnAddKrug.UseVisualStyleBackColor = true;
            this.btnAddKrug.Click += new System.EventHandler(this.btnAddKrug_Click);
            // 
            // nudSekundi
            // 
            this.nudSekundi.Location = new System.Drawing.Point(136, 303);
            this.nudSekundi.Name = "nudSekundi";
            this.nudSekundi.Size = new System.Drawing.Size(86, 20);
            this.nudSekundi.TabIndex = 3;
            // 
            // nudMinuti
            // 
            this.nudMinuti.Location = new System.Drawing.Point(29, 303);
            this.nudMinuti.Name = "nudMinuti";
            this.nudMinuti.Size = new System.Drawing.Size(94, 20);
            this.nudMinuti.TabIndex = 2;
            // 
            // nudVreme
            // 
            this.nudVreme.Location = new System.Drawing.Point(29, 368);
            this.nudVreme.Name = "nudVreme";
            this.nudVreme.Size = new System.Drawing.Size(94, 20);
            this.nudVreme.TabIndex = 2;
            this.nudVreme.ValueChanged += new System.EventHandler(this.nudVreme_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Vozaci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Vozaci.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekundi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Vozaci;
        private System.Windows.Forms.Button btnDodadiVozac;
        private System.Windows.Forms.Button btnIzbrisiVozac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddKrug;
        private System.Windows.Forms.NumericUpDown nudMinuti;
        private System.Windows.Forms.NumericUpDown nudSekundi;
        private System.Windows.Forms.TextBox tbNajdobarKrug;
        private System.Windows.Forms.NumericUpDown nudVreme;
        private System.Windows.Forms.ListBox lbVozaci;
        private System.Windows.Forms.ListBox lbKrugovi;
    }
}

