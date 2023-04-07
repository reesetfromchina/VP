namespace Avion
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
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.lbAirport = new System.Windows.Forms.ListBox();
            this.btnAddAerodrom = new System.Windows.Forms.Button();
            this.btnDeleteAerodrom = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.tbMostExpensiveDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAverageDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.Location = new System.Drawing.Point(464, 41);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(293, 238);
            this.lbDestinations.TabIndex = 0;
            // 
            // lbAirport
            // 
            this.lbAirport.FormattingEnabled = true;
            this.lbAirport.Location = new System.Drawing.Point(60, 41);
            this.lbAirport.Name = "lbAirport";
            this.lbAirport.Size = new System.Drawing.Size(293, 238);
            this.lbAirport.TabIndex = 0;
            this.lbAirport.SelectedIndexChanged += new System.EventHandler(this.lbAirport_SelectedIndexChanged);
            this.lbAirport.SelectedValueChanged += new System.EventHandler(this.lbAirport_SelectedValueChanged);
            // 
            // btnAddAerodrom
            // 
            this.btnAddAerodrom.Location = new System.Drawing.Point(54, 301);
            this.btnAddAerodrom.Name = "btnAddAerodrom";
            this.btnAddAerodrom.Size = new System.Drawing.Size(298, 24);
            this.btnAddAerodrom.TabIndex = 1;
            this.btnAddAerodrom.Text = "Додади аеродром";
            this.btnAddAerodrom.UseVisualStyleBackColor = true;
            this.btnAddAerodrom.Click += new System.EventHandler(this.btnAddAerodrom_Click);
            // 
            // btnDeleteAerodrom
            // 
            this.btnDeleteAerodrom.Location = new System.Drawing.Point(54, 354);
            this.btnDeleteAerodrom.Name = "btnDeleteAerodrom";
            this.btnDeleteAerodrom.Size = new System.Drawing.Size(298, 24);
            this.btnDeleteAerodrom.TabIndex = 1;
            this.btnDeleteAerodrom.Text = "Избриши аеродром";
            this.btnDeleteAerodrom.UseVisualStyleBackColor = true;
            this.btnDeleteAerodrom.Click += new System.EventHandler(this.btnDeleteAerodrom_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(54, 398);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(298, 24);
            this.btnAddDestination.TabIndex = 1;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // tbMostExpensiveDestination
            // 
            this.tbMostExpensiveDestination.Enabled = false;
            this.tbMostExpensiveDestination.Location = new System.Drawing.Point(464, 316);
            this.tbMostExpensiveDestination.Name = "tbMostExpensiveDestination";
            this.tbMostExpensiveDestination.Size = new System.Drawing.Size(293, 20);
            this.tbMostExpensiveDestination.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Најскапата дестинација";
            // 
            // tbAverageDestination
            // 
            this.tbAverageDestination.Enabled = false;
            this.tbAverageDestination.Location = new System.Drawing.Point(464, 357);
            this.tbAverageDestination.Name = "tbAverageDestination";
            this.tbAverageDestination.Size = new System.Drawing.Size(293, 20);
            this.tbAverageDestination.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Просечна должина на дестинациите";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAverageDestination);
            this.Controls.Add(this.tbMostExpensiveDestination);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAerodrom);
            this.Controls.Add(this.btnAddAerodrom);
            this.Controls.Add(this.lbAirport);
            this.Controls.Add(this.lbDestinations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.ListBox lbAirport;
        private System.Windows.Forms.Button btnAddAerodrom;
        private System.Windows.Forms.Button btnDeleteAerodrom;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.TextBox tbMostExpensiveDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAverageDestination;
        private System.Windows.Forms.Label label2;
    }
}

