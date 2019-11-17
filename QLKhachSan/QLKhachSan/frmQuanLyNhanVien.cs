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

        public List<NhanVien> layDSNV()
        {
            khoiTaoNhanVien();
            return listNV;
        }

        private void khoiTaoNhanVien()
        {
            NhanVien nv1 = new NhanVien("NV1", "Nguyễn Hoàng Duy", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321", "100000", "Tiếp tân");
            NhanVien nv2 = new NhanVien("NV2", "Nguyễn Phương Nam", "456 TP.HCM", "Đà Nẵng", "02/06/2000", "123456789", "987654321", "200000", "Đầu bếp");
            listNV.Add(nv1);
            listNV.Add(nv2);
        }

        public void hienThiNhanVien()
        {
            listViewNV.Items.Clear();
            for (int i = 0; i < listNV.Count; i++)
            {
                string[] nhanVien = { listNV[i].maNV, listNV[i].hoTen, listNV[i].diaChi, listNV[i].queQuan, listNV[i].ngaySinh, listNV[i].soDienThoai, listNV[i].soCMND, listNV[i].luong, listNV[i].chucVu };
                listViewNV.Items.Add(new ListViewItem(nhanVien));
            }
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            khoiTaoNhanVien();
            hienThiNhanVien();
        }

        private void clearTxt()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtNgaySinh.Text = "";
            txtQueQuan.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtLuong.Text = "";
            txtChucVu.Text = "";
            listViewNV.SelectedItems.Clear();
        }

        private void listViewNV_MouseClick(object sender, MouseEventArgs e)
        {
            txtHoTen.Text = listViewNV.SelectedItems[0].SubItems[1].Text;
            txtDiaChi.Text = listViewNV.SelectedItems[0].SubItems[2].Text;
            txtNgaySinh.Text = listViewNV.SelectedItems[0].SubItems[3].Text;
            txtQueQuan.Text = listViewNV.SelectedItems[0].SubItems[4].Text;
            txtSDT.Text = listViewNV.SelectedItems[0].SubItems[5].Text;
            txtCMND.Text = listViewNV.SelectedItems[0].SubItems[6].Text;
            txtLuong.Text = listViewNV.SelectedItems[0].SubItems[7].Text;
            txtChucVu.Text = listViewNV.SelectedItems[0].SubItems[8].Text;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtNgaySinh.Text == "" || txtQueQuan.Text == "" || txtSDT.Text == "" || txtCMND.Text == "" || txtLuong.Text == "" || txtChucVu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin của nhân viên", "Thêm nhân viên");
                return;
            }

            string maNV, hoTen, diaChi, ngaySinh, queQuan, soDienThoai, soCMND, luong, chucVu;

            maNV = "NV" + (listNV.Count + 1).ToString();
            hoTen = txtHoTen.Text;
            diaChi = txtDiaChi.Text;
            ngaySinh = txtNgaySinh.Text;
            queQuan = txtQueQuan.Text;
            soDienThoai = txtSDT.Text;
            soCMND = txtCMND.Text;
            luong = txtLuong.Text;
            chucVu = txtChucVu.Text;

            listNV.Add(new NhanVien(maNV, hoTen, diaChi, ngaySinh, queQuan, soDienThoai, soCMND, luong, chucVu));
            MessageBox.Show("Thêm nhân viên thành công", "Thêm nhân viên");

            hienThiNhanVien();
            clearTxt();
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)
            {
                listViewNV.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
                listViewNV.SelectedItems[0].SubItems[2].Text = txtDiaChi.Text;
                listViewNV.SelectedItems[0].SubItems[3].Text = txtNgaySinh.Text;
                listViewNV.SelectedItems[0].SubItems[4].Text = txtQueQuan.Text;
                listViewNV.SelectedItems[0].SubItems[5].Text = txtSDT.Text;
                listViewNV.SelectedItems[0].SubItems[6].Text = txtCMND.Text;

                MessageBox.Show("Cập nhật nhân viên thành công", "Cập nhật nhân viên");
                clearTxt();
            }
            else
                MessageBox.Show("Bạn phải chọn nhân viên cần cập nhật", "Cập nhật nhân viên");
            listViewNV.SelectedItems.Clear();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (listViewNV.SelectedItems.Count > 0)
            {
                DialogResult dR = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này ?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    listViewNV.SelectedItems[0].Remove();
                    clearTxt();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn nhân viên cần xóa", "Xóa nhân viên"); 
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearTxt();
        }
    }
}
