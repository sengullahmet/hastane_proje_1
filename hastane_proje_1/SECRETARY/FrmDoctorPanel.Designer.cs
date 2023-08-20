namespace hastane_proje_1.SECRETARY
{
    partial class FrmDoctorPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dgwDoctorList = new System.Windows.Forms.DataGridView();
            this.doctorİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBranchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbldoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalProjectDataSet = new hastane_proje_1.MedicalProjectDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbl_doctorsTableAdapter = new hastane_proje_1.MedicalProjectDataSetTableAdapters.tbl_doctorsTableAdapter();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoctorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldoctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 36);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(176, 82);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(184, 36);
            this.txtSurname.TabIndex = 2;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(176, 139);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(184, 36);
            this.cmbBranch.TabIndex = 3;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(176, 197);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(184, 36);
            this.mskTc.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(176, 252);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 36);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // dgwDoctorList
            // 
            this.dgwDoctorList.AutoGenerateColumns = false;
            this.dgwDoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDoctorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorİdDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorSurnameDataGridViewTextBoxColumn,
            this.doctorBranchDataGridViewTextBoxColumn,
            this.doctorTcDataGridViewTextBoxColumn,
            this.doctorPassDataGridViewTextBoxColumn});
            this.dgwDoctorList.DataSource = this.tbldoctorsBindingSource;
            this.dgwDoctorList.Location = new System.Drawing.Point(394, 31);
            this.dgwDoctorList.Name = "dgwDoctorList";
            this.dgwDoctorList.RowHeadersWidth = 51;
            this.dgwDoctorList.RowTemplate.Height = 24;
            this.dgwDoctorList.Size = new System.Drawing.Size(448, 257);
            this.dgwDoctorList.TabIndex = 10;
            this.dgwDoctorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDoctorList_CellClick);
            // 
            // doctorİdDataGridViewTextBoxColumn
            // 
            this.doctorİdDataGridViewTextBoxColumn.DataPropertyName = "doctorİd";
            this.doctorİdDataGridViewTextBoxColumn.HeaderText = "doctorİd";
            this.doctorİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorİdDataGridViewTextBoxColumn.Name = "doctorİdDataGridViewTextBoxColumn";
            this.doctorİdDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorİdDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "doctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "doctorName";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorSurnameDataGridViewTextBoxColumn
            // 
            this.doctorSurnameDataGridViewTextBoxColumn.DataPropertyName = "doctorSurname";
            this.doctorSurnameDataGridViewTextBoxColumn.HeaderText = "doctorSurname";
            this.doctorSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorSurnameDataGridViewTextBoxColumn.Name = "doctorSurnameDataGridViewTextBoxColumn";
            this.doctorSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorBranchDataGridViewTextBoxColumn
            // 
            this.doctorBranchDataGridViewTextBoxColumn.DataPropertyName = "doctorBranch";
            this.doctorBranchDataGridViewTextBoxColumn.HeaderText = "doctorBranch";
            this.doctorBranchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorBranchDataGridViewTextBoxColumn.Name = "doctorBranchDataGridViewTextBoxColumn";
            this.doctorBranchDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorTcDataGridViewTextBoxColumn
            // 
            this.doctorTcDataGridViewTextBoxColumn.DataPropertyName = "doctorTc";
            this.doctorTcDataGridViewTextBoxColumn.HeaderText = "doctorTc";
            this.doctorTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorTcDataGridViewTextBoxColumn.Name = "doctorTcDataGridViewTextBoxColumn";
            this.doctorTcDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorPassDataGridViewTextBoxColumn
            // 
            this.doctorPassDataGridViewTextBoxColumn.DataPropertyName = "doctorPass";
            this.doctorPassDataGridViewTextBoxColumn.HeaderText = "doctorPass";
            this.doctorPassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorPassDataGridViewTextBoxColumn.Name = "doctorPassDataGridViewTextBoxColumn";
            this.doctorPassDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbldoctorsBindingSource
            // 
            this.tbldoctorsBindingSource.DataMember = "tbl_doctors";
            this.tbldoctorsBindingSource.DataSource = this.medicalProjectDataSet;
            // 
            // medicalProjectDataSet
            // 
            this.medicalProjectDataSet.DataSetName = "MedicalProjectDataSet";
            this.medicalProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(232, 306);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(105, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(232, 352);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 35);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbl_doctorsTableAdapter
            // 
            this.tbl_doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(393, 306);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(448, 39);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmDoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(853, 410);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgwDoctorList);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Panel";
            this.Load += new System.EventHandler(this.FrmDoctorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoctorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldoctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dgwDoctorList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private MedicalProjectDataSet medicalProjectDataSet;
        private System.Windows.Forms.BindingSource tbldoctorsBindingSource;
        private MedicalProjectDataSetTableAdapters.tbl_doctorsTableAdapter tbl_doctorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorBranchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReturn;
    }
}