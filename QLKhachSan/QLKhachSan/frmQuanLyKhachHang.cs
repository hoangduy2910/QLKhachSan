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
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        List<KhachHang> listKH = new List<KhachHang>();

        private void khoiTaoKhachHang()
        {
            KhachHang kh1 = new KhachHang("KH1", "Nguyễn Văn A", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321");
            KhachHang kh2 = new KhachHang("KH2", "Trần Thị B", "123 TP.HCM", "TP.HCM", "02/06/2000", "123456789", "987654321");
            KhachHang kh3 = new KhachHang("KH3", "Lê Hoàng C", "123 TP.HCM", "TP.HCM", "03/04/1996", "123456789", "987654321");
            listKH.Add(kh1);
            listKH.Add(kh2);
            listKH.Add(kh3);
        }

        private void hienThiKhachHang()
        {
            listViewKH.Items.Clear();
            for (int i = 0; i < listKH.Count; i++)
            {
                string[] khachHang = { listKH[i].maKH, listKH[i].hoTen, listKH[i].diaChi, listKH[i].queQuan, listKH[i].ngaySinh, listKH[i].soDienThoai, listKH[i].soCMND };
                listViewKH.Items.Add(new ListViewItem(khachHang));
            }
            Console.WriteLine("123");
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;
            frmLogin frmLogin = new frmLogin();
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
            }
            else
            {
                Application.Exit();
            }
            khoiTaoKhachHang();
            hienThiKhachHang();  
        }

        private void themKH_Click(object sender, EventArgs e)
        {
            frmThemKhachHang themKH = new frmThemKhachHang(listKH);
            this.Hide();
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
    }
}
