namespace F1Driver
{
    partial class DodadiVozac
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
            this.components = new System.ComponentModel.Container();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.nudVozrast = new System.Windows.Forms.NumericUpDown();
            this.cbPrvVozac = new System.Windows.Forms.CheckBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudVozrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(147, 140);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(497, 20);
            this.tbIme.TabIndex = 0;
            this.tbIme.Validated += new System.EventHandler(this.tbIme_Validated);
            // 
            // nudVozrast
            // 
            this.nudVozrast.Location = new System.Drawing.Point(147, 241);
            this.nudVozrast.Name = "nudVozrast";
            this.nudVozrast.Size = new System.Drawing.Size(179, 20);
            this.nudVozrast.TabIndex = 1;
            // 
            // cbPrvVozac
            // 
            this.cbPrvVozac.AutoSize = true;
            this.cbPrvVozac.Location = new System.Drawing.Point(369, 243);
            this.cbPrvVozac.Name = "cbPrvVozac";
            this.cbPrvVozac.Size = new System.Drawing.Size(74, 17);
            this.cbPrvVozac.TabIndex = 2;
            this.cbPrvVozac.Text = "Prv vozac";
            this.cbPrvVozac.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(147, 318);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(374, 318);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(75, 23);
            this.btnDodadi.TabIndex = 3;
            this.btnDodadi.Text = "Dodadi";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vozrast";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodadiVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.cbPrvVozac);
            this.Controls.Add(this.nudVozrast);
            this.Controls.Add(this.tbIme);
            this.Name = "DodadiVozac";
            this.Text = "DodadiVozac";
            ((System.ComponentModel.ISupportInitialize)(this.nudVozrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.NumericUpDown nudVozrast;
        private System.Windows.Forms.CheckBox cbPrvVozac;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}