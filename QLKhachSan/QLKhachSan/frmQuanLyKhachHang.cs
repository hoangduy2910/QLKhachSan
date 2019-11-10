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

        private void listViewKH_MouseClick(object sender, MouseEventArgs e)
        {
            txtHoTenKH.Text = listViewKH.SelectedItems[0].SubItems[1].Text;
            txtDiaChiKH.Text = listViewKH.SelectedItems[0].SubItems[2].Text;
            txtNgaySinhKH.Text = listViewKH.SelectedItems[0].SubItems[3].Text;
            txtQueQuanKH.Text = listViewKH.SelectedItems[0].SubItems[4].Text;
            txtSoDienThoaiKH.Text = listViewKH.SelectedItems[0].SubItems[5].Text;
            txtSoCMNDKH.Text = listViewKH.SelectedItems[0].SubItems[6].Text;
        }

        private void clearTxt()
        {
            txtHoTenKH.Text = "";
            txtDiaChiKH.Text = "";
            txtNgaySinhKH.Text = "";
            txtQueQuanKH.Text = "";
            txtSoDienThoaiKH.Text = "";
            txtSoCMNDKH.Text = "";
        }

        private void btnThemKH_Click(object sender, EventArgs e)
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
            MessageBox.Show("Thêm khách hàng thành công", "Thêm khách hàng");

            hienThiKhachHang();
            clearTxt();
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            listViewKH.SelectedItems[0].SubItems[1].Text = txtHoTenKH.Text;
            listViewKH.SelectedItems[0].SubItems[2].Text = txtDiaChiKH.Text;
            listViewKH.SelectedItems[0].SubItems[3].Text = txtNgaySinhKH.Text;
            listViewKH.SelectedItems[0].SubItems[4].Text = txtQueQuanKH.Text;
            listViewKH.SelectedItems[0].SubItems[5].Text = txtSoDienThoaiKH.Text;
            listViewKH.SelectedItems[0].SubItems[6].Text = txtSoCMNDKH.Text;

            MessageBox.Show("Cập nhật khách hàng thành công", "Cập nhật khách hàng");
            clearTxt();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này ?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == DialogResult.Yes)
            {
                listViewKH.SelectedItems[0].Remove();
                clearTxt();
            }
        }
    }
}
