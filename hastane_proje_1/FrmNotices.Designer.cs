namespace hastane_proje_1
{
    partial class FrmNotices
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
            this.dgswNotices = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgswNotices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgswNotices
            // 
            this.dgswNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgswNotices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgswNotices.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgswNotices.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgswNotices.Location = new System.Drawing.Point(0, 0);
            this.dgswNotices.Name = "dgswNotices";
            this.dgswNotices.RowHeadersWidth = 51;
            this.dgswNotices.RowTemplate.Height = 24;
            this.dgswNotices.Size = new System.Drawing.Size(1101, 396);
            this.dgswNotices.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(0, 413);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(1101, 51);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return Secretary";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1101, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Return Doctor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNotices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgswNotices);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNotices";
            this.Text = "FrmNotices";
            this.Load += new System.EventHandler(this.FrmNotices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgswNotices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgswNotices;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
    }
}