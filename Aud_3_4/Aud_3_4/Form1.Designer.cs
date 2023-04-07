namespace Aud_3_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clbStrings = new CheckedListBox();
            lbStrings = new ListBox();
            inputTextBox = new TextBox();
            btnAddString = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // clbStrings
            // 
            clbStrings.FormattingEnabled = true;
            clbStrings.Location = new Point(544, 12);
            clbStrings.Name = "clbStrings";
            clbStrings.Size = new Size(195, 256);
            clbStrings.TabIndex = 0;
            // 
            // lbStrings
            // 
            lbStrings.FormattingEnabled = true;
            lbStrings.ItemHeight = 15;
            lbStrings.Location = new Point(336, 12);
            lbStrings.Name = "lbStrings";
            lbStrings.Size = new Size(202, 244);
            lbStrings.TabIndex = 1;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(145, 117);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(100, 23);
            inputTextBox.TabIndex = 2;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // btnAddString
            // 
            btnAddString.Location = new Point(145, 146);
            btnAddString.Name = "btnAddString";
            btnAddString.Size = new Size(100, 23);
            btnAddString.TabIndex = 3;
            btnAddString.Text = "Додади";
            btnAddString.UseVisualStyleBackColor = true;
            btnAddString.Click += btnAddString_Click;
            // 
            // button2
            // 
            button2.Location = new Point(483, 308);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Премести";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnAddString);
            Controls.Add(inputTextBox);
            Controls.Add(lbStrings);
            Controls.Add(clbStrings);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbStrings;
        private ListBox lbStrings;
        private TextBox inputTextBox;
        private Button btnAddString;
        private Button button2;
    }
}