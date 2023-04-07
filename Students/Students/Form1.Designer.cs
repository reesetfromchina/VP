namespace Students
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteGrades = new System.Windows.Forms.Button();
            this.rbNajvisokProsek = new System.Windows.Forms.RadioButton();
            this.rbNajmoguPolozeniIspiti = new System.Windows.Forms.RadioButton();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInformations = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(29, 12);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(234, 264);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(51, 322);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(121, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Додади студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteGrades
            // 
            this.btnDeleteGrades.Location = new System.Drawing.Point(51, 364);
            this.btnDeleteGrades.Name = "btnDeleteGrades";
            this.btnDeleteGrades.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteGrades.TabIndex = 1;
            this.btnDeleteGrades.Text = "Избриши оценки";
            this.btnDeleteGrades.UseVisualStyleBackColor = true;
            this.btnDeleteGrades.Click += new System.EventHandler(this.btnDeleteGrades_Click);
            // 
            // rbNajvisokProsek
            // 
            this.rbNajvisokProsek.AutoSize = true;
            this.rbNajvisokProsek.Location = new System.Drawing.Point(373, 340);
            this.rbNajvisokProsek.Name = "rbNajvisokProsek";
            this.rbNajvisokProsek.Size = new System.Drawing.Size(110, 17);
            this.rbNajvisokProsek.TabIndex = 2;
            this.rbNajvisokProsek.TabStop = true;
            this.rbNajvisokProsek.Text = "Највисок просек";
            this.rbNajvisokProsek.UseVisualStyleBackColor = true;
            // 
            // rbNajmoguPolozeniIspiti
            // 
            this.rbNajmoguPolozeniIspiti.AutoSize = true;
            this.rbNajmoguPolozeniIspiti.Location = new System.Drawing.Point(373, 364);
            this.rbNajmoguPolozeniIspiti.Name = "rbNajmoguPolozeniIspiti";
            this.rbNajmoguPolozeniIspiti.Size = new System.Drawing.Size(156, 17);
            this.rbNajmoguPolozeniIspiti.TabIndex = 3;
            this.rbNajmoguPolozeniIspiti.TabStop = true;
            this.rbNajmoguPolozeniIspiti.Text = "Најмогу положени испити";
            this.rbNajmoguPolozeniIspiti.UseVisualStyleBackColor = true;
            // 
            // nudGrade
            // 
            this.nudGrade.Location = new System.Drawing.Point(373, 63);
            this.nudGrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGrade.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGrade.Name = "nudGrade";
            this.nudGrade.Size = new System.Drawing.Size(120, 20);
            this.nudGrade.TabIndex = 4;
            this.nudGrade.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(373, 89);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(120, 23);
            this.btnAddGrade.TabIndex = 1;
            this.btnAddGrade.Text = "Додади оценка";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Информации за селектираниот студент";
            // 
            // lbInformations
            // 
            this.lbInformations.AutoSize = true;
            this.lbInformations.Location = new System.Drawing.Point(376, 180);
            this.lbInformations.Name = "lbInformations";
            this.lbInformations.Size = new System.Drawing.Size(35, 13);
            this.lbInformations.TabIndex = 6;
            this.lbInformations.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(603, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbInformations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.rbNajmoguPolozeniIspiti);
            this.Controls.Add(this.rbNajvisokProsek);
            this.Controls.Add(this.btnDeleteGrades);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteGrades;
        private System.Windows.Forms.RadioButton rbNajvisokProsek;
        private System.Windows.Forms.RadioButton rbNajmoguPolozeniIspiti;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInformations;
        private System.Windows.Forms.TextBox textBox1;
    }
}

