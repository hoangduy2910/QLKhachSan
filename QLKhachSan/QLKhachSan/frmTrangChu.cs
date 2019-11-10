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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        frmLogin login;

        public frmTrangChu(frmLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien QLNV = new frmQuanLyNhanVien();
            QLNV.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang QLKH = new frmQuanLyKhachHang();
            QLKH.Show();
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            frmQuanLyPhong QLP = new frmQuanLyPhong();
            QLP.Show();
        }

        private void frmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Close();
        }
    }
}
