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
    public partial class frmQuanLyKhachHang : Form
    {
        frmLogin login;
        frmThemKhachHang themKhachHang;

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        public frmQuanLyKhachHang(frmLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        public frmQuanLyKhachHang(frmThemKhachHang themKhachHang)
        {
            InitializeComponent();
            this.themKhachHang = themKhachHang;
        }

        List<KhachHang> listKH = new List<KhachHang>();

        private void khoiTaoKhachHang()
        {
            KhachHang kh1 = new KhachHang("KH1", "Nguyễn Văn A", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321");
            KhachHang kh2 = new KhachHang("KH2", "Trần Thị B", "456 TP.HCM", "Đà Nẵng", "02/06/2000", "123456789", "987654321");
            KhachHang kh3 = new KhachHang("KH3", "Lê Hoàng C", "789 TP.HCM", "Bảo Lộc", "03/04/1996", "123456789", "987654321");
            listKH.Add(kh1);
            listKH.Add(kh2);
            listKH.Add(kh3);
        }

        public void hienThiKhachHang()
        {
            listViewKH.Items.Clear();
            for (int i = 0; i < listKH.Count; i++)
            {
                string[] khachHang = { listKH[i].maKH, listKH[i].hoTen, listKH[i].diaChi, listKH[i].queQuan, listKH[i].ngaySinh, listKH[i].soDienThoai, listKH[i].soCMND };
                listViewKH.Items.Add(new ListViewItem(khachHang));
            }
        }

        public void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            khoiTaoKhachHang();
            hienThiKhachHang();  
        }

        private void themKH_Click(object sender, EventArgs e)
        {
            frmThemKhachHang themKH = new frmThemKhachHang(listKH, this);
            themKH.Show();
        }

        private void listViewKH_MouseClick(object sender, MouseEventArgs e)
        {
            string hoTen, diaChi, ngaySinh, queQuan, soDienThoai, soCMND;

            hoTen = listViewKH.SelectedItems[0].SubItems[1].Text;
            diaChi = listViewKH.SelectedItems[0].SubItems[2].Text;
            ngaySinh = listViewKH.SelectedItems[0].SubItems[3].Text;
            queQuan = listViewKH.SelectedItems[0].SubItems[4].Text;
            soDienThoai = listViewKH.SelectedItems[0].SubItems[5].Text;
            soCMND = listViewKH.SelectedItems[0].SubItems[6].Text;

            txtHoTenKH.Text = hoTen;
            txtDiaChiKH.Text = diaChi;
            txtNgaySinhKH.Text = ngaySinh;
            txtQueQuanKH.Text = queQuan;
            txtSoDienThoaiKH.Text = soDienThoai;
            txtSoCMNDKH.Text = soCMND;
        }

        private void frmQuanLyKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Close();
            themKhachHang.Close();
        }
    }
}
