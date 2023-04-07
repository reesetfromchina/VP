namespace ExamQuestions
{
    partial class Ispit
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
            this.nudGodina = new System.Windows.Forms.NumericUpDown();
            this.cbMesec = new System.Windows.Forms.ComboBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodina)).BeginInit();
            this.SuspendLayout();
            // 
            // nudGodina
            // 
            this.nudGodina.Location = new System.Drawing.Point(84, 143);
            this.nudGodina.Name = "nudGodina";
            this.nudGodina.Size = new System.Drawing.Size(120, 20);
            this.nudGodina.TabIndex = 0;
            // 
            // cbMesec
            // 
            this.cbMesec.FormattingEnabled = true;
            this.cbMesec.Items.AddRange(new object[] {
            "Januari",
            "Juni",
            "Septemvri"});
            this.cbMesec.Location = new System.Drawing.Point(84, 203);
            this.cbMesec.Name = "cbMesec";
            this.cbMesec.Size = new System.Drawing.Size(121, 21);
            this.cbMesec.TabIndex = 1;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(84, 314);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(75, 23);
            this.btnDodadi.TabIndex = 2;
            this.btnDodadi.Text = "Dodadi";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(198, 314);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // Ispit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 380);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.cbMesec);
            this.Controls.Add(this.nudGodina);
            this.Name = "Ispit";
            this.Text = "Ispit";
            ((System.ComponentModel.ISupportInitialize)(this.nudGodina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGodina;
        private System.Windows.Forms.ComboBox cbMesec;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnOtkazi;
    }
}