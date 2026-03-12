namespace QLSV
{
    partial class FrmLopHoc
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
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChuyenFormSV = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(32, 12);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(211, 22);
            this.txtTenLop.TabIndex = 0;
            this.txtTenLop.Text = "Tên lớp";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 284);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(140, 284);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(32, 328);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuyenFormSV
            // 
            this.btnChuyenFormSV.Location = new System.Drawing.Point(32, 372);
            this.btnChuyenFormSV.Name = "btnChuyenFormSV";
            this.btnChuyenFormSV.Size = new System.Drawing.Size(210, 38);
            this.btnChuyenFormSV.TabIndex = 4;
            this.btnChuyenFormSV.Text = "Quản lý Sinh Viên";
            this.btnChuyenFormSV.UseVisualStyleBackColor = true;
            this.btnChuyenFormSV.Click += new System.EventHandler(this.btnChuyenFormSV_Click);
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Location = new System.Drawing.Point(249, 12);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.RowTemplate.Height = 24;
            this.dgvLopHoc.Size = new System.Drawing.Size(539, 426);
            this.dgvLopHoc.TabIndex = 5;
            // 
            // FrmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.btnChuyenFormSV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenLop);
            this.Name = "FrmLopHoc";
            this.Text = "FrmLopHoc";
            this.Load += new System.EventHandler(this.FrmLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChuyenFormSV;
        private System.Windows.Forms.DataGridView dgvLopHoc;
    }
}