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
            dgvLopHoc.DataSource = db.LopHocs.Select(l => new { l.MaLop, l.TenLop }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHoc lopMoi = new LopHoc { TenLop = txtTenLop.Text };
            db.LopHocs.InsertOnSubmit(lopMoi);
            db.SubmitChanges();
            LoadData();
            txtTenLop.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var lop = db.LopHocs.SingleOrDefault(l => l.MaLop == idLopHocDangChon);
            if (lop != null)
            {
                lop.TenLop = txtTenLop.Text;
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
            }
        }

        private void btnChuyenFormSV_Click(object sender, EventArgs e)
        {
            FrmSinhVien fSinhVien = new FrmSinhVien();
            fSinhVien.ShowDialog();
        }
    }
}