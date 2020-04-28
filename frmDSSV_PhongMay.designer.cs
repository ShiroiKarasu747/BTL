namespace QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh
{
    partial class frmDSSV_PhongMay
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
            this.dataGridView_Dssv = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaPhongMay = new System.Windows.Forms.Label();
            this.txtPhongMay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dssv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Dssv
            // 
            this.dataGridView_Dssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dssv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV});
            this.dataGridView_Dssv.Location = new System.Drawing.Point(18, 66);
            this.dataGridView_Dssv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Dssv.Name = "dataGridView_Dssv";
            this.dataGridView_Dssv.RowHeadersWidth = 62;
            this.dataGridView_Dssv.RowTemplate.Height = 28;
            this.dataGridView_Dssv.Size = new System.Drawing.Size(676, 228);
            this.dataGridView_Dssv.TabIndex = 11;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 8;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 150;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên sinh viên";
            this.TenSV.MinimumWidth = 8;
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 150;
            // 
            // lblMaPhongMay
            // 
            this.lblMaPhongMay.AutoSize = true;
            this.lblMaPhongMay.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhongMay.Location = new System.Drawing.Point(23, 27);
            this.lblMaPhongMay.Name = "lblMaPhongMay";
            this.lblMaPhongMay.Size = new System.Drawing.Size(142, 25);
            this.lblMaPhongMay.TabIndex = 12;
            this.lblMaPhongMay.Text = "Mã phòng máy";
            // 
            // txtPhongMay
            // 
            this.txtPhongMay.Location = new System.Drawing.Point(171, 31);
            this.txtPhongMay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhongMay.Name = "txtPhongMay";
            this.txtPhongMay.Size = new System.Drawing.Size(115, 22);
            this.txtPhongMay.TabIndex = 13;
            // 
            // frmDSSV_PhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 322);
            this.Controls.Add(this.txtPhongMay);
            this.Controls.Add(this.lblMaPhongMay);
            this.Controls.Add(this.dataGridView_Dssv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDSSV_PhongMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDSSV_PhongMay";
            this.Load += new System.EventHandler(this.frmDSSV_PhongMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dssv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Dssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.Label lblMaPhongMay;
        private System.Windows.Forms.TextBox txtPhongMay;
    }
}