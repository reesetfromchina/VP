namespace Aud4
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
            this.clbSelectedCourses = new System.Windows.Forms.CheckedListBox();
            this.lbAvalableCourse = new System.Windows.Forms.ListBox();
            this.btnAddCourseToAvalablelb = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.btnPomestiDesno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbSelectedCourses
            // 
            this.clbSelectedCourses.FormattingEnabled = true;
            this.clbSelectedCourses.Location = new System.Drawing.Point(519, 55);
            this.clbSelectedCourses.Name = "clbSelectedCourses";
            this.clbSelectedCourses.Size = new System.Drawing.Size(253, 229);
            this.clbSelectedCourses.TabIndex = 0;
            // 
            // lbAvalableCourse
            // 
            this.lbAvalableCourse.FormattingEnabled = true;
            this.lbAvalableCourse.Items.AddRange(new object[] {
            "DM",
            "E-VLADA",
            "AOK",
            "SP",
            "OOP",
            "APS",
            "VVKN",
            "OS",
            "VP",
            "SI",
            "KNIO",
            "ASIM"});
            this.lbAvalableCourse.Location = new System.Drawing.Point(191, 46);
            this.lbAvalableCourse.Name = "lbAvalableCourse";
            this.lbAvalableCourse.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAvalableCourse.Size = new System.Drawing.Size(241, 238);
            this.lbAvalableCourse.TabIndex = 1;
            // 
            // btnAddCourseToAvalablelb
            // 
            this.btnAddCourseToAvalablelb.Location = new System.Drawing.Point(31, 94);
            this.btnAddCourseToAvalablelb.Name = "btnAddCourseToAvalablelb";
            this.btnAddCourseToAvalablelb.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourseToAvalablelb.TabIndex = 2;
            this.btnAddCourseToAvalablelb.Text = "Add";
            this.btnAddCourseToAvalablelb.UseVisualStyleBackColor = true;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(438, 203);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.Text = "<<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(12, 68);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(116, 20);
            this.tbCourse.TabIndex = 3;
            // 
            // btnPomestiDesno
            // 
            this.btnPomestiDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomestiDesno.Location = new System.Drawing.Point(438, 94);
            this.btnPomestiDesno.Name = "btnPomestiDesno";
            this.btnPomestiDesno.Size = new System.Drawing.Size(75, 37);
            this.btnPomestiDesno.TabIndex = 2;
            this.btnPomestiDesno.Text = ">>";
            this.btnPomestiDesno.UseVisualStyleBackColor = true;
            this.btnPomestiDesno.Click += new System.EventHandler(this.btnPomestiDesno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCourse);
            this.Controls.Add(this.btnPomestiDesno);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnAddCourseToAvalablelb);
            this.Controls.Add(this.lbAvalableCourse);
            this.Controls.Add(this.clbSelectedCourses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSelectedCourses;
        private System.Windows.Forms.ListBox lbAvalableCourse;
        private System.Windows.Forms.Button btnAddCourseToAvalablelb;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.Button btnPomestiDesno;
    }
}

