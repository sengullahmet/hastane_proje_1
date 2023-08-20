namespace hastane_proje_1
{
    partial class FrmPatientEditİnfo
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
            this.BtnEditİnfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdTel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.mskdTc = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEditİnfo
            // 
            this.BtnEditİnfo.BackColor = System.Drawing.Color.LightCoral;
            this.BtnEditİnfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditİnfo.Location = new System.Drawing.Point(238, 385);
            this.BtnEditİnfo.Name = "BtnEditİnfo";
            this.BtnEditİnfo.Size = new System.Drawing.Size(206, 38);
            this.BtnEditİnfo.TabIndex = 31;
            this.BtnEditİnfo.Text = "Update";
            this.BtnEditİnfo.UseVisualStyleBackColor = false;
            this.BtnEditİnfo.Click += new System.EventHandler(this.BtnEditİnfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gender :";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(262, 328);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(159, 36);
            this.cmbGender.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Surname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name :";
            // 
            // mskdTel
            // 
            this.mskdTel.Location = new System.Drawing.Point(261, 210);
            this.mskdTel.Margin = new System.Windows.Forms.Padding(4);
            this.mskdTel.Mask = "(999) 000-0000";
            this.mskdTel.Name = "mskdTel";
            this.mskdTel.Size = new System.Drawing.Size(160, 36);
            this.mskdTel.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Telephone :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(262, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 36);
            this.txtName.TabIndex = 24;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(261, 98);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(160, 36);
            this.txtSurname.TabIndex = 23;
            // 
            // mskdTc
            // 
            this.mskdTc.Location = new System.Drawing.Point(262, 151);
            this.mskdTc.Margin = new System.Windows.Forms.Padding(4);
            this.mskdTc.Mask = "0000000000";
            this.mskdTc.Name = "mskdTc";
            this.mskdTc.Size = new System.Drawing.Size(158, 36);
            this.mskdTc.TabIndex = 22;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(261, 273);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 36);
            this.txtPassword.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "T.C Idenıty Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password :";
            // 
            // FrmPatientEditİnfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 533);
            this.Controls.Add(this.BtnEditİnfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskdTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.mskdTc);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FrmPatientEditİnfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPatientEditİnfo";
            this.Load += new System.EventHandler(this.FrmPatientEditİnfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEditİnfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbGender;
        public System.Windows.Forms.MaskedTextBox mskdTel;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.MaskedTextBox mskdTc;
        public System.Windows.Forms.TextBox txtPassword;
    }
}