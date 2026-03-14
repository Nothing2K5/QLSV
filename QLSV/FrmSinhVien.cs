using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FrmSinhVien : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();
        int idSVDangChon = -1;

        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, System.EventArgs e)
        {
            cmbLopHoc.DataSource = db.LopHocs.ToList();
            cmbLopHoc.DisplayMember = "TenLop";
            cmbLopHoc.ValueMember = "MaLop";

            LoadData();
        }

        private void LoadData()
        {
            var data = from sv in db.SinhViens
                       join lop in db.LopHocs on sv.MaLop equals lop.MaLop
                       select new
                       {
                           sv.MaSV,
                           sv.TenSV,
                           sv.NgaySinh,
                           sv.GioiTinh,
                           lop.TenLop,
                           sv.MaLop
                       };
            dgvSinhVien.DataSource = data.ToList();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            SinhVien svMoi = new SinhVien
            {
                TenSV = txtTenSV.Text,
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = cmbGioiTinh.Text,
                MaLop = Convert.ToInt32(cmbLopHoc.SelectedValue)
            };
            db.SinhViens.InsertOnSubmit(svMoi);
            db.SubmitChanges();
            LoadData();
            txtTenSV.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSVDangChon = Convert.ToInt32(dgvSinhVien.Rows[e.RowIndex].Cells["MaSV"].Value);
                txtTenSV.Text = dgvSinhVien.Rows[e.RowIndex].Cells["TenSV"].Value.ToString();
                cmbLopHoc.SelectedValue = dgvSinhVien.Rows[e.RowIndex].Cells["MaLop"].Value;

                // Xử lý Ngày sinh
                if (dgvSinhVien.Rows[e.RowIndex].Cells["NgaySinh"].Value != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(dgvSinhVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);
                }
                else
                {
                    dtpNgaySinh.Value = DateTime.Now; // Mặc định nếu null
                }

                // Xử lý Giới tính
                cmbGioiTinh.Text = dgvSinhVien.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString() ?? "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sv = db.SinhViens.SingleOrDefault(s => s.MaSV == idSVDangChon);
            if (sv != null)
            {
                sv.TenSV = txtTenSV.Text;
                sv.NgaySinh = dtpNgaySinh.Value.Date;
                sv.GioiTinh = cmbGioiTinh.Text;
                sv.MaLop = Convert.ToInt32(cmbLopHoc.SelectedValue);
                db.SubmitChanges();
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sv = db.SinhViens.SingleOrDefault(s => s.MaSV == idSVDangChon);
            if (sv != null)
            {
                db.SinhViens.DeleteOnSubmit(sv);
                db.SubmitChanges();
                LoadData();
                txtTenSV.Clear();
                dtpNgaySinh.Value = DateTime.Now;
            }
        }

        private void btnChuyenFormLH_Click(object sender, EventArgs e)
        {
            FrmLopHoc frmLopHoc = new FrmLopHoc();
            frmLopHoc.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSV.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            if (cmbLopHoc.Items.Count > 0)
            {
                cmbLopHoc.SelectedIndex = 0;
            }
            if (cmbGioiTinh.Items.Count > 0)
            {
                cmbGioiTinh.SelectedIndex = 0;
            }
            idSVDangChon = -1;
            dgvSinhVien.ClearSelection();
            txtTenSV.Focus();

            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            // Tìm kiếm theo tên Sinh viên chứa từ khóa
            var ketQua = from sv in db.SinhViens
                         join lop in db.LopHocs on sv.MaLop equals lop.MaLop
                         where sv.TenSV.ToLower().Contains(tuKhoa)
                         select new
                         {
                             sv.MaSV,
                             sv.TenSV,
                             sv.NgaySinh,
                             sv.GioiTinh,
                             lop.TenLop,
                             sv.MaLop
                         };

            dgvSinhVien.DataSource = ketQua.ToList();
        }
    }
}