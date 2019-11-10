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
    public partial class frmQuanLyPhong : Form
    {
        public frmQuanLyPhong()
        {
            InitializeComponent();
        }

        List<Phong> listPhong = new List<Phong>();

        public void khoiTaoPhong()
        {
            Phong phong101 = new Phong("101", "Đơn", "Trống", "", "", "", "");
            Phong phong102 = new Phong("102", "Đơn", "Trống", "", "", "", "");
            Phong phong103 = new Phong("103", "Đơn", "Trống", "", "", "", "");

            Phong phong201 = new Phong("201", "Đôi", "Trống", "", "", "", "");
            Phong phong202 = new Phong("202", "Đôi", "Trống", "", "", "", "");
            Phong phong203 = new Phong("203", "Đôi", "Trống", "", "", "", "");

            listPhong.Add(phong101);
            listPhong.Add(phong102);
            listPhong.Add(phong103);
            listPhong.Add(phong201);
            listPhong.Add(phong202);
            listPhong.Add(phong203);
        }

        public void hienThiPhong()
        {
            listViewPhong.Items.Clear();
            for (int i = 0; i < listPhong.Count; i++)
            {
                string[] phong = { listPhong[i].maPhong, listPhong[i].loaiPhong, listPhong[i].tinhTrang, listPhong[i].ngayVao, listPhong[i].ngayDi, listPhong[i].tenKH, listPhong[i].soCMND };
                listViewPhong.Items.Add(new ListViewItem(phong));
            }
        }

        private void clearTxt()
        {
            txtPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtTinhTrang.Text = "";
            txtKhachHang.Text = "";
            txtCMND.Text = "";
        }

        private void frmQuanLyPhong_Load(object sender, EventArgs e)
        {
            khoiTaoPhong();
            hienThiPhong();
        }

        private void listViewPhong_MouseClick(object sender, MouseEventArgs e)
        {
            txtPhong.Text = listViewPhong.SelectedItems[0].SubItems[0].Text;
            txtLoaiPhong.Text = listViewPhong.SelectedItems[0].SubItems[1].Text;
            txtTinhTrang.Text = listViewPhong.SelectedItems[0].SubItems[2].Text;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtPhong.Text == "" || txtLoaiPhong.Text == "" || txtTinhTrang.Text == "" || txtKhachHang.Text == "" || txtCMND.Text == "")
                return;
                
            listViewPhong.SelectedItems[0].SubItems[2].Text = txtTinhTrang.Text;
            listViewPhong.SelectedItems[0].SubItems[3].Text = dateTimeNgayVao.Text;
            listViewPhong.SelectedItems[0].SubItems[4].Text = dateTimeNgayDi.Text;
            listViewPhong.SelectedItems[0].SubItems[5].Text = txtKhachHang.Text;
            listViewPhong.SelectedItems[0].SubItems[6].Text = txtCMND.Text;

            MessageBox.Show("Cập nhật phòng thành công", "Cập nhật phòng");
            clearTxt();
        }
    }
}
