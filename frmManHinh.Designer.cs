namespace QuanLyPhongMay
{
    partial class frmManHinh
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
            System.Windows.Forms.Panel panel2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenManHinh = new System.Windows.Forms.TextBox();
            this.txtMaManHinh = new System.Windows.Forms.TextBox();
            this.lblTenManHinh = new System.Windows.Forms.Label();
            this.lblMaManHinh = new System.Windows.Forms.Label();
            this.lblManHinh = new System.Windows.Forms.Label();
            this.dgvManHinh = new System.Windows.Forms.DataGridView();
            this.MaManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 166);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(this.txtTenManHinh);
            panel2.Controls.Add(this.txtMaManHinh);
            panel2.Controls.Add(this.lblTenManHinh);
            panel2.Controls.Add(this.lblMaManHinh);
            panel2.Controls.Add(this.lblManHinh);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Enabled = false;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(908, 310);
            panel2.TabIndex = 1;
            // 
            // txtTenManHinh
            // 
            this.txtTenManHinh.Location = new System.Drawing.Point(222, 202);
            this.txtTenManHinh.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenManHinh.Name = "txtTenManHinh";
            this.txtTenManHinh.Size = new System.Drawing.Size(110, 42);
            this.txtTenManHinh.TabIndex = 4;
            // 
            // txtMaManHinh
            // 
            this.txtMaManHinh.Location = new System.Drawing.Point(222, 107);
            this.txtMaManHinh.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaManHinh.Name = "txtMaManHinh";
            this.txtMaManHinh.Size = new System.Drawing.Size(115, 42);
            this.txtMaManHinh.TabIndex = 3;
            // 
            // lblTenManHinh
            // 
            this.lblTenManHinh.AutoSize = true;
            this.lblTenManHinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenManHinh.Location = new System.Drawing.Point(47, 212);
            this.lblTenManHinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTenManHinh.Name = "lblTenManHinh";
            this.lblTenManHinh.Size = new System.Drawing.Size(130, 25);
            this.lblTenManHinh.TabIndex = 2;
            this.lblTenManHinh.Text = "Tên màn hình";
            // 
            // lblMaManHinh
            // 
            this.lblMaManHinh.AutoSize = true;
            this.lblMaManHinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaManHinh.Location = new System.Drawing.Point(47, 117);
            this.lblMaManHinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaManHinh.Name = "lblMaManHinh";
            this.lblMaManHinh.Size = new System.Drawing.Size(125, 25);
            this.lblMaManHinh.TabIndex = 1;
            this.lblMaManHinh.Text = "Mã màn hình";
            // 
            // lblManHinh
            // 
            this.lblManHinh.AutoSize = true;
            this.lblManHinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManHinh.Location = new System.Drawing.Point(462, 33);
            this.lblManHinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblManHinh.Name = "lblManHinh";
            this.lblManHinh.Size = new System.Drawing.Size(175, 35);
            this.lblManHinh.TabIndex = 0;
            this.lblManHinh.Text = "MÀN HÌNH";
            // 
            // dgvManHinh
            // 
            this.dgvManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManHinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaManHinh,
            this.TenManHinh});
            this.dgvManHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManHinh.Location = new System.Drawing.Point(0, 310);
            this.dgvManHinh.Margin = new System.Windows.Forms.Padding(6);
            this.dgvManHinh.Name = "dgvManHinh";
            this.dgvManHinh.RowHeadersWidth = 51;
            this.dgvManHinh.RowTemplate.Height = 24;
            this.dgvManHinh.Size = new System.Drawing.Size(908, 164);
            this.dgvManHinh.TabIndex = 2;
            this.dgvManHinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManHinh_CellClick);
            // 
            // MaManHinh
            // 
            this.MaManHinh.DataPropertyName = "MaManHinh";
            this.MaManHinh.HeaderText = "Mã màn hình";
            this.MaManHinh.MinimumWidth = 6;
            this.MaManHinh.Name = "MaManHinh";
            this.MaManHinh.Width = 125;
            // 
            // TenManHinh
            // 
            this.TenManHinh.DataPropertyName = "TenManHinh";
            this.TenManHinh.HeaderText = "Tên màn hình";
            this.TenManHinh.MinimumWidth = 6;
            this.TenManHinh.Name = "TenManHinh";
            this.TenManHinh.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyPhongMay.Properties.Resources.Thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(15, 69);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 52);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(689, 69);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 56);
            this.btnThoat.TabIndex = 72;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLyPhongMay.Properties.Resources.btnHuy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(548, 69);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 56);
            this.btnHuy.TabIndex = 71;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyPhongMay.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(411, 69);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 52);
            this.btnLuu.TabIndex = 70;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyPhongMay.Properties.Resources.btnXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(281, 69);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 52);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyPhongMay.Properties.Resources.btnSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(145, 69);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 52);
            this.btnSua.TabIndex = 68;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 640);
            this.Controls.Add(this.dgvManHinh);
            this.Controls.Add(panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmManHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÀN HÌNH";
            this.Load += new System.EventHandler(this.frmManHinh_Load);
            this.panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvManHinh;
        private System.Windows.Forms.Label lblTenManHinh;
        private System.Windows.Forms.Label lblMaManHinh;
        private System.Windows.Forms.Label lblManHinh;
        private System.Windows.Forms.TextBox txtTenManHinh;
        private System.Windows.Forms.TextBox txtMaManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenManHinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}