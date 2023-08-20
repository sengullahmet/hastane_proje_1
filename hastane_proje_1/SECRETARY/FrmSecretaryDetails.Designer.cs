namespace hastane_proje_1.SECRETARY
{
    partial class FrmSecretaryDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rchNotice = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.chckState = new System.Windows.Forms.CheckBox();
            this.mskHour = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.mmskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtİd = new System.Windows.Forms.TextBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgwBranches = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgwDoctors = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnBranchPanel = new System.Windows.Forms.Button();
            this.btnApoinListed = new System.Windows.Forms.Button();
            this.btnDctorPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBranches)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoctors)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.lblNameSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary İnfo";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(136, 98);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(0, 28);
            this.lblNameSurname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad :";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(153, 51);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(144, 28);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC İDENTİTY :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.rchNotice);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create a Notice";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 196);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(278, 40);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rchNotice
            // 
            this.rchNotice.Location = new System.Drawing.Point(11, 35);
            this.rchNotice.Name = "rchNotice";
            this.rchNotice.Size = new System.Drawing.Size(278, 140);
            this.rchNotice.TabIndex = 0;
            this.rchNotice.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnApply);
            this.groupBox3.Controls.Add(this.chckState);
            this.groupBox3.Controls.Add(this.mskHour);
            this.groupBox3.Controls.Add(this.mskDate);
            this.groupBox3.Controls.Add(this.mmskTc);
            this.groupBox3.Controls.Add(this.txtİd);
            this.groupBox3.Controls.Add(this.cmbBranch);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(353, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 427);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appoinment Panel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(147, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 43);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(18, 366);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(123, 43);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chckState
            // 
            this.chckState.AutoSize = true;
            this.chckState.Location = new System.Drawing.Point(110, 328);
            this.chckState.Name = "chckState";
            this.chckState.Size = new System.Drawing.Size(89, 32);
            this.chckState.TabIndex = 14;
            this.chckState.Text = "State";
            this.chckState.UseVisualStyleBackColor = true;
            // 
            // mskHour
            // 
            this.mskHour.Location = new System.Drawing.Point(110, 137);
            this.mskHour.Mask = "90:00";
            this.mskHour.Name = "mskHour";
            this.mskHour.Size = new System.Drawing.Size(146, 36);
            this.mskHour.TabIndex = 13;
            this.mskHour.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(110, 234);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(146, 36);
            this.mskDate.TabIndex = 12;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // mmskTc
            // 
            this.mmskTc.Location = new System.Drawing.Point(110, 286);
            this.mmskTc.Mask = "00000000000";
            this.mmskTc.Name = "mmskTc";
            this.mmskTc.Size = new System.Drawing.Size(146, 36);
            this.mmskTc.TabIndex = 11;
            // 
            // txtİd
            // 
            this.txtİd.Location = new System.Drawing.Point(110, 48);
            this.txtİd.Name = "txtİd";
            this.txtİd.Size = new System.Drawing.Size(146, 36);
            this.txtİd.TabIndex = 10;
            this.txtİd.Leave += new System.EventHandler(this.txtİd_Leave);
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(110, 188);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(146, 36);
            this.cmbBranch.TabIndex = 9;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(110, 90);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(146, 36);
            this.cmbDoctor.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "Doctor :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tc :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "Hour :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Branch :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "İd :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.dgwBranches);
            this.groupBox4.Location = new System.Drawing.Point(677, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 245);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branches";
            // 
            // dgwBranches
            // 
            this.dgwBranches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwBranches.Location = new System.Drawing.Point(3, 32);
            this.dgwBranches.Name = "dgwBranches";
            this.dgwBranches.RowHeadersWidth = 51;
            this.dgwBranches.RowTemplate.Height = 24;
            this.dgwBranches.Size = new System.Drawing.Size(444, 210);
            this.dgwBranches.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.dgwDoctors);
            this.groupBox5.Location = new System.Drawing.Point(677, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(450, 350);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dgwDoctors
            // 
            this.dgwDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDoctors.Location = new System.Drawing.Point(3, 32);
            this.dgwDoctors.Name = "dgwDoctors";
            this.dgwDoctors.RowHeadersWidth = 51;
            this.dgwDoctors.RowTemplate.Height = 24;
            this.dgwDoctors.Size = new System.Drawing.Size(444, 315);
            this.dgwDoctors.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.btnNotifications);
            this.groupBox6.Controls.Add(this.btnBranchPanel);
            this.groupBox6.Controls.Add(this.btnApoinListed);
            this.groupBox6.Controls.Add(this.btnDctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 462);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(640, 165);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnNotifications.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNotifications.Location = new System.Drawing.Point(198, 95);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(163, 39);
            this.btnNotifications.TabIndex = 3;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnBranchPanel
            // 
            this.btnBranchPanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBranchPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBranchPanel.Location = new System.Drawing.Point(198, 35);
            this.btnBranchPanel.Name = "btnBranchPanel";
            this.btnBranchPanel.Size = new System.Drawing.Size(163, 39);
            this.btnBranchPanel.TabIndex = 2;
            this.btnBranchPanel.Text = "Branch Panel";
            this.btnBranchPanel.UseVisualStyleBackColor = false;
            this.btnBranchPanel.Click += new System.EventHandler(this.btnBranchPanel_Click);
            // 
            // btnApoinListed
            // 
            this.btnApoinListed.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnApoinListed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApoinListed.Location = new System.Drawing.Point(376, 33);
            this.btnApoinListed.Name = "btnApoinListed";
            this.btnApoinListed.Size = new System.Drawing.Size(202, 41);
            this.btnApoinListed.TabIndex = 1;
            this.btnApoinListed.Text = "Appoinment List";
            this.btnApoinListed.UseVisualStyleBackColor = false;
            this.btnApoinListed.Click += new System.EventHandler(this.btnApoinListed_Click);
            // 
            // btnDctorPanel
            // 
            this.btnDctorPanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDctorPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDctorPanel.Location = new System.Drawing.Point(16, 35);
            this.btnDctorPanel.Name = "btnDctorPanel";
            this.btnDctorPanel.Size = new System.Drawing.Size(163, 39);
            this.btnDctorPanel.TabIndex = 0;
            this.btnDctorPanel.Text = "Doctor Panel";
            this.btnDctorPanel.UseVisualStyleBackColor = false;
            this.btnDctorPanel.Click += new System.EventHandler(this.btnDctorPanel_Click);
            // 
            // FrmSecretaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1148, 668);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSecretaryDetails";
            this.Text = "Secretary Detail";
            this.Load += new System.EventHandler(this.FrmSecretaryDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBranches)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoctors)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RichTextBox rchNotice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgwBranches;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgwDoctors;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBranchPanel;
        private System.Windows.Forms.Button btnApoinListed;
        private System.Windows.Forms.Button btnDctorPanel;
        public System.Windows.Forms.CheckBox chckState;
        public System.Windows.Forms.MaskedTextBox mskHour;
        public System.Windows.Forms.MaskedTextBox mskDate;
        public System.Windows.Forms.MaskedTextBox mmskTc;
        public System.Windows.Forms.TextBox txtİd;
        public System.Windows.Forms.ComboBox cmbBranch;
        public System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Button btnNotifications;
    }
}