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
    public partial class frmThemKhachHang : Form
    {
        List<KhachHang> listKH;

        internal frmThemKhachHang(List<KhachHang> list)
        {
            InitializeComponent();
            listKH = list;
        }

        private void btThemKH_Click(object sender, EventArgs e)
        {
            string maKH, hoTen, diaChi, ngaySinh, queQuan, soDienThoai, soCMND;

            maKH = "KH" + (listKH.Count + 1).ToString(); 
            hoTen = txtHoTenKH.Text;
            diaChi = txtDiaChiKH.Text;
            ngaySinh = txtNgaySinhKH.Text;
            queQuan = txtQueQuanKH.Text;
            soDienThoai = txtSoDienThoaiKH.Text;
            soCMND = txtSoCMNDKH.Text;

            listKH.Add(new KhachHang(maKH, hoTen, diaChi, ngaySinh, queQuan, soDienThoai, soCMND));
            MessageBox.Show("Thêm khách hàng thành công");
            this.Close();
            frmQuanLyKhachHang QLKH = new frmQuanLyKhachHang();
            QLKH.Show();
        }
    }
}
