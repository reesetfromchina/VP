namespace Avion
{
    partial class AddAirports
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
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveAddAirport = new System.Windows.Forms.Button();
            this.btnCancelAirportAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(38, 80);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(215, 20);
            this.tbCity.TabIndex = 0;
            this.tbCity.Validated += new System.EventHandler(this.tbCity_Validated);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(38, 145);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(215, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Validated += new System.EventHandler(this.tbCity_Validated);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(38, 197);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(215, 20);
            this.tbCode.TabIndex = 0;
            this.tbCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbCode_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Додади нов аеродром";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Град";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Кратенка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Име";
            // 
            // btnSaveAddAirport
            // 
            this.btnSaveAddAirport.Location = new System.Drawing.Point(38, 247);
            this.btnSaveAddAirport.Name = "btnSaveAddAirport";
            this.btnSaveAddAirport.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAddAirport.TabIndex = 2;
            this.btnSaveAddAirport.Text = "Зачувај";
            this.btnSaveAddAirport.UseVisualStyleBackColor = true;
            this.btnSaveAddAirport.Click += new System.EventHandler(this.btnSaveAddAirport_Click);
            // 
            // btnCancelAirportAdd
            // 
            this.btnCancelAirportAdd.Location = new System.Drawing.Point(178, 247);
            this.btnCancelAirportAdd.Name = "btnCancelAirportAdd";
            this.btnCancelAirportAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAirportAdd.TabIndex = 2;
            this.btnCancelAirportAdd.Text = "Откажи";
            this.btnCancelAirportAdd.UseVisualStyleBackColor = true;
            this.btnCancelAirportAdd.Click += new System.EventHandler(this.btnCancelAirportAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 282);
            this.Controls.Add(this.btnCancelAirportAdd);
            this.Controls.Add(this.btnSaveAddAirport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCity);
            this.Name = "AddAirports";
            this.Text = "Додади аеродром";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveAddAirport;
        private System.Windows.Forms.Button btnCancelAirportAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}