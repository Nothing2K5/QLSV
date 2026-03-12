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
                MaLop = Convert.ToInt32(cmbLopHoc.SelectedValue)
            };
            db.SinhViens.InsertOnSubmit(svMoi);
            db.SubmitChanges();
            LoadData();
            txtTenSV.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sv = db.SinhViens.SingleOrDefault(s => s.MaSV == idSVDangChon);
            if (sv != null)
            {
                sv.TenSV = txtTenSV.Text;
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
            }
        }

        private void btnChuyenFormLH_Click(object sender, EventArgs e)
        {
            FrmLopHoc frmLopHoc = new FrmLopHoc();
            frmLopHoc.ShowDialog();
        }
    }
}