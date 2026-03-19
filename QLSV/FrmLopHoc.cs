using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FrmLopHoc : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();
        int idLopHocDangChon = -1;

        public FrmLopHoc()
        {
            InitializeComponent();
        }

        private void FrmLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvLopHoc.DataSource = db.LopHocs.Select(l => new { l.MaLop, l.TenLop, l.Khoa }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHoc lopMoi = new LopHoc
            {
                TenLop = txtTenLop.Text,
                Khoa = txtKhoa.Text
            };
            db.LopHocs.InsertOnSubmit(lopMoi);
            db.SubmitChanges();
            LoadData();
            txtTenLop.Clear();
            txtKhoa.Clear();
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idLopHocDangChon = Convert.ToInt32(dgvLopHoc.Rows[e.RowIndex].Cells["MaLop"].Value);
                txtTenLop.Text = dgvLopHoc.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
                txtKhoa.Text = dgvLopHoc.Rows[e.RowIndex].Cells["Khoa"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var lop = db.LopHocs.SingleOrDefault(l => l.MaLop == idLopHocDangChon);
            if (lop != null)
            {
                lop.TenLop = txtTenLop.Text;
                lop.Khoa = txtKhoa.Text;
                db.SubmitChanges();
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var lop = db.LopHocs.SingleOrDefault(l => l.MaLop == idLopHocDangChon);
            if (lop != null)
            {
                db.LopHocs.DeleteOnSubmit(lop);
                db.SubmitChanges();
                LoadData();
                txtTenLop.Clear();
                txtKhoa.Clear();
            }
        }

        private void btnChuyenFormSV_Click(object sender, EventArgs e)
        {
            FrmSinhVien fSinhVien = new FrmSinhVien();
            this.Hide();
            fSinhVien.ShowDialog();
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenLop.Clear();
            txtKhoa.Clear();
            idLopHocDangChon = -1;
            dgvLopHoc.ClearSelection();
            txtTenLop.Focus();

            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            var ketQua = db.LopHocs.Where(l => l.TenLop.ToLower().Contains(tuKhoa) ||
                                               l.Khoa.ToLower().Contains(tuKhoa))
                                   .Select(l => new { l.MaLop, l.TenLop, l.Khoa }).ToList();

            dgvLopHoc.DataSource = ketQua;
        }
    }
}