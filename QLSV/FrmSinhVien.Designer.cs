namespace QLSV
{
    partial class FrmSinhVien
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.cmbLopHoc = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChuyenFormLH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(248, 12);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(540, 426);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(32, 12);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(206, 22);
            this.txtTenSV.TabIndex = 1;
            this.txtTenSV.Text = "Tên Sinh viên";
            // 
            // cmbLopHoc
            // 
            this.cmbLopHoc.FormattingEnabled = true;
            this.cmbLopHoc.Location = new System.Drawing.Point(32, 55);
            this.cmbLopHoc.Name = "cmbLopHoc";
            this.cmbLopHoc.Size = new System.Drawing.Size(206, 24);
            this.cmbLopHoc.TabIndex = 2;
            this.cmbLopHoc.Text = "Lớp học";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(32, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(140, 286);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 38);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 286);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 38);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChuyenFormLH
            // 
            this.btnChuyenFormLH.Location = new System.Drawing.Point(32, 374);
            this.btnChuyenFormLH.Name = "btnChuyenFormLH";
            this.btnChuyenFormLH.Size = new System.Drawing.Size(210, 38);
            this.btnChuyenFormLH.TabIndex = 6;
            this.btnChuyenFormLH.Text = "Quản lý lớp học";
            this.btnChuyenFormLH.UseVisualStyleBackColor = true;
            this.btnChuyenFormLH.Click += new System.EventHandler(this.btnChuyenFormLH_Click);
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChuyenFormLH);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cmbLopHoc);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSinhVien";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.ComboBox cmbLopHoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChuyenFormLH;
    }
}