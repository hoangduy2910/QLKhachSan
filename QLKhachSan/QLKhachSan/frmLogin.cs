using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (user == "admin" && pass == "123")
            {
                frmQuanLyKhachHang QLKH = new frmQuanLyKhachHang(this);
                this.Hide();
                QLKH.Show();    
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu", "Đăng nhập thất bại");
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }
    }
}
