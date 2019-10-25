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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        List<NhanVien> listNV = new List<NhanVien>();

        private void khoiTaoNhanVien()
        {
            NhanVien nv1 = new NhanVien("NV1", "Duy", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321","100000");
            NhanVien nv2 = new NhanVien("NV2", "Nam", "456 TP.HCM", "Đà Nẵng", "02/06/2000", "123456789", "987654321", "200000");
            listNV.Add(nv1);
            listNV.Add(nv1);
        }

        public void hienThiKhachHang()
        {
            listView1.Items.Clear();
            for (int i = 0; i < listNV.Count; i++)
            {
                string[] NhanVien = { listNV[i].maNV, listNV[i].hoTen, listNV[i].diaChi, listNV[i].queQuan, listNV[i].ngaySinh, listNV[i].soDienThoai, listNV[i].soCMND,listNV[i].luong };
                listView1.Items.Add(new ListViewItem(NhanVien));
            }
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            khoiTaoNhanVien();
            hienThiKhachHang();
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            var hoTen = txtHoTen.Text;
            var maNV = txtMaNV.Text;
            var diaChi = txtDiaChi.Text;
            var queQuan = txtQueQuan.Text;
            var ngaySinh = txtNgaySinh.Text;
            var soDienThoai = txtSDT.Text;
            var soCMND = txtCMND.Text;
            var luong = txtLuong.Text;
            NhanVien nv = new NhanVien(maNV, hoTen, diaChi, queQuan, ngaySinh, soDienThoai, soCMND, luong);
            listNV.Add(nv);
            hienThiKhachHang();
        }


    }
}
