namespace hastane_proje_1.SECRETARY
{
    partial class FrmAppoinmentList
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
            this.dgwApoinmentListed = new System.Windows.Forms.DataGridView();
            this.returnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwApoinmentListed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwApoinmentListed
            // 
            this.dgwApoinmentListed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwApoinmentListed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwApoinmentListed.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwApoinmentListed.Location = new System.Drawing.Point(0, 0);
            this.dgwApoinmentListed.Name = "dgwApoinmentListed";
            this.dgwApoinmentListed.RowHeadersWidth = 51;
            this.dgwApoinmentListed.RowTemplate.Height = 24;
            this.dgwApoinmentListed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwApoinmentListed.Size = new System.Drawing.Size(1413, 593);
            this.dgwApoinmentListed.TabIndex = 0;
           
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(0, 621);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(1413, 68);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // FrmAppoinmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1413, 756);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.dgwApoinmentListed);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimizeBox = false;
            this.Name = "FrmAppoinmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAppoinmentList";
            this.Load += new System.EventHandler(this.FrmAppoinmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwApoinmentListed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwApoinmentListed;
        private System.Windows.Forms.Button returnBtn;
    }
}