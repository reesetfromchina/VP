namespace TvSerii
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
            this.cbTV = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnDeleteProgram = new System.Windows.Forms.Button();
            this.nudTimeLength = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbProgrami = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTV = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.btnAddTv = new System.Windows.Forms.Button();
            this.lbTest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeLength)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTV
            // 
            this.cbTV.FormattingEnabled = true;
            this.cbTV.Location = new System.Drawing.Point(9, 44);
            this.cbTV.Name = "cbTV";
            this.cbTV.Size = new System.Drawing.Size(352, 21);
            this.cbTV.TabIndex = 0;
            this.cbTV.SelectedIndexChanged += new System.EventHandler(this.cbTV_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddProgram);
            this.groupBox1.Controls.Add(this.btnDeleteProgram);
            this.groupBox1.Controls.Add(this.nudTimeLength);
            this.groupBox1.Controls.Add(this.cbTV);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нова програма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Времетраење:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телевизија";
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Enabled = false;
            this.btnAddProgram.Location = new System.Drawing.Point(9, 286);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(150, 23);
            this.btnAddProgram.TabIndex = 2;
            this.btnAddProgram.Text = "Додади програма";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // btnDeleteProgram
            // 
            this.btnDeleteProgram.Location = new System.Drawing.Point(204, 289);
            this.btnDeleteProgram.Name = "btnDeleteProgram";
            this.btnDeleteProgram.Size = new System.Drawing.Size(157, 23);
            this.btnDeleteProgram.TabIndex = 2;
            this.btnDeleteProgram.Text = "Избриши програма";
            this.btnDeleteProgram.UseVisualStyleBackColor = true;
            this.btnDeleteProgram.Click += new System.EventHandler(this.btnDeleteProgram_Click);
            // 
            // nudTimeLength
            // 
            this.nudTimeLength.Location = new System.Drawing.Point(9, 166);
            this.nudTimeLength.Name = "nudTimeLength";
            this.nudTimeLength.Size = new System.Drawing.Size(120, 20);
            this.nudTimeLength.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 100);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbProgrami);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbTV);
            this.groupBox2.Controls.Add(this.tbAverage);
            this.groupBox2.Location = new System.Drawing.Point(403, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Програма на ТВ:";
            // 
            // lbProgrami
            // 
            this.lbProgrami.FormattingEnabled = true;
            this.lbProgrami.Location = new System.Drawing.Point(6, 58);
            this.lbProgrami.Name = "lbProgrami";
            this.lbProgrami.Size = new System.Drawing.Size(353, 186);
            this.lbProgrami.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Просечно времетрање:";
            // 
            // lbTV
            // 
            this.lbTV.AutoSize = true;
            this.lbTV.Location = new System.Drawing.Point(17, 28);
            this.lbTV.Name = "lbTV";
            this.lbTV.Size = new System.Drawing.Size(30, 13);
            this.lbTV.TabIndex = 0;
            this.lbTV.Text = "HBO";
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(6, 289);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(373, 20);
            this.tbAverage.TabIndex = 0;
            // 
            // btnAddTv
            // 
            this.btnAddTv.Location = new System.Drawing.Point(21, 392);
            this.btnAddTv.Name = "btnAddTv";
            this.btnAddTv.Size = new System.Drawing.Size(131, 23);
            this.btnAddTv.TabIndex = 2;
            this.btnAddTv.Text = "Додади ТВ";
            this.btnAddTv.UseVisualStyleBackColor = true;
            this.btnAddTv.Click += new System.EventHandler(this.btnAddTv_Click);
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(270, 392);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(35, 13);
            this.lbTest.TabIndex = 3;
            this.lbTest.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.btnAddTv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeLength)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Button btnDeleteProgram;
        private System.Windows.Forms.NumericUpDown nudTimeLength;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTV;
        private System.Windows.Forms.Button btnAddTv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbProgrami;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label lbTest;
    }
}

