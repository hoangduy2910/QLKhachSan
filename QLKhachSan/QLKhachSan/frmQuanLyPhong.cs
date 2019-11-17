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

        public List<Phong> layDSPhong()
        {
            khoiTaoPhong();
            return listPhong;
        }

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
            txtKhachHang.Text = "";
            txtCMND.Text = "";
            radioBtnDangO.Checked = false;
            radioBtnTrong.Checked = false;
            listViewPhong.SelectedItems.Clear();
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
            txtKhachHang.Text = listViewPhong.SelectedItems[0].SubItems[5].Text;
            txtCMND.Text = listViewPhong.SelectedItems[0].SubItems[6].Text;
            if (listViewPhong.SelectedItems[0].SubItems[2].Text == "Trống")
                radioBtnTrong.Checked = true;
            else
                radioBtnDangO.Checked = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (listViewPhong.SelectedItems.Count > 0)
            {
                listViewPhong.SelectedItems[0].SubItems[2].Text = radioBtnDangO.Text;
                listViewPhong.SelectedItems[0].SubItems[3].Text = dateTimeNgayVao.Text;
                listViewPhong.SelectedItems[0].SubItems[4].Text = dateTimeNgayDi.Text;
                listViewPhong.SelectedItems[0].SubItems[5].Text = txtKhachHang.Text;
                listViewPhong.SelectedItems[0].SubItems[6].Text = txtCMND.Text;

                MessageBox.Show("Cập nhật phòng thành công", "Cập nhật phòng");
                clearTxt();
            }
            else
                MessageBox.Show("Bạn phải chọn phòng cần cập nhật", "Cập nhật phòng");
            listViewPhong.SelectedItems.Clear();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (listViewPhong.SelectedItems.Count > 0)
            {
                DialogResult dR = MessageBox.Show("Bạn có chắc muốn khôi phục phòng trở về tình trạng ban đầu", "Khôi phục phòng", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                    listViewPhong.SelectedItems[0].SubItems[2].Text = radioBtnTrong.Text;
                    listViewPhong.SelectedItems[0].SubItems[3].Text = "";
                    listViewPhong.SelectedItems[0].SubItems[4].Text = "";
                    listViewPhong.SelectedItems[0].SubItems[5].Text = "";
                    listViewPhong.SelectedItems[0].SubItems[6].Text = "";
                    clearTxt();
                } 
            }
            else
                MessageBox.Show("Bạn phải chọn phòng cần khôi phục", "Khôi phục phòng");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearTxt();
        }
    }
}
