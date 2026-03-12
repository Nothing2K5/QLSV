using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FrmLogin : Form
    {

        DataClassesDataContext db = new DataClassesDataContext();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            var taikhoan = db.Users.SingleOrDefault(u => u.Username == user && u.Password == pass);

            if (taikhoan != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                FrmLopHoc fLopHoc = new FrmLopHoc();
                this.Hide();
                fLopHoc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
            }
        }
    }
}
