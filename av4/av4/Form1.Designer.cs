namespace av4
{
    partial class Krister
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.btnAddCourseLeftToAvalableCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(240, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(547, 96);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(138, 139);
            this.checkedListBox1.TabIndex = 1;
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(420, 126);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(75, 23);
            this.moveRight.TabIndex = 2;
            this.moveRight.Text = ">>";
            this.moveRight.UseVisualStyleBackColor = true;
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(420, 196);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(75, 23);
            this.moveLeft.TabIndex = 3;
            this.moveLeft.Text = "<<";
            this.moveLeft.UseVisualStyleBackColor = true;
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(0, 96);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(142, 20);
            this.tbCourse.TabIndex = 4;
            // 
            // btnAddCourseLeftToAvalableCourse
            // 
            this.btnAddCourseLeftToAvalableCourse.Location = new System.Drawing.Point(24, 155);
            this.btnAddCourseLeftToAvalableCourse.Name = "btnAddCourseLeftToAvalableCourse";
            this.btnAddCourseLeftToAvalableCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourseLeftToAvalableCourse.TabIndex = 5;
            this.btnAddCourseLeftToAvalableCourse.Text = "Add course";
            this.btnAddCourseLeftToAvalableCourse.UseVisualStyleBackColor = true;
            // 
            // Krister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCourseLeftToAvalableCourse);
            this.Controls.Add(this.tbCourse);
            this.Controls.Add(this.moveLeft);
            this.Controls.Add(this.moveRight);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Krister";
            this.Text = "Krister ronaldo siu";
            this.Click += new System.EventHandler(this.Krister_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.Button btnAddCourseLeftToAvalableCourse;
    }
}

