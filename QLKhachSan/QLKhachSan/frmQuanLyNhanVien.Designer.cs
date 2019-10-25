namespace QLKhachSan
{
    partial class frmQuanLyNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewNV = new System.Windows.Forms.ListView();
            this.maNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.luong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbHoTenNV = new System.Windows.Forms.Label();
            this.lbDiaChiNV = new System.Windows.Forms.Label();
            this.lbQueQuanNV = new System.Windows.Forms.Label();
            this.lbNgaySinhNV = new System.Windows.Forms.Label();
            this.lbSoDTNV = new System.Windows.Forms.Label();
            this.lbSoCMNDNV = new System.Windows.Forms.Label();
            this.lbChucVuNV = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.lbQLKH = new System.Windows.Forms.Label();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnCapNhatNV = new System.Windows.Forms.Button();
            this.lbLuongNV = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewNV
            // 
            this.listViewNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maNV,
            this.hoTen,
            this.diaChi,
            this.queQuan,
            this.ngaySinh,
            this.soDienThoai,
            this.soCMND,
            this.luong,
            this.chucVu});
            this.listViewNV.FullRowSelect = true;
            this.listViewNV.Location = new System.Drawing.Point(12, 297);
            this.listViewNV.Name = "listViewNV";
            this.listViewNV.Size = new System.Drawing.Size(839, 241);
            this.listViewNV.TabIndex = 0;
            this.listViewNV.UseCompatibleStateImageBehavior = false;
            this.listViewNV.View = System.Windows.Forms.View.Details;
            this.listViewNV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewNV_MouseClick);
            // 
            // maNV
            // 
            this.maNV.Text = "Mã NV";
            // 
            // hoTen
            // 
            this.hoTen.Text = "Họ và Tên";
            this.hoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoTen.Width = 117;
            // 
            // diaChi
            // 
            this.diaChi.Text = "Địa chỉ";
            this.diaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.diaChi.Width = 99;
            // 
            // queQuan
            // 
            this.queQuan.Text = "Quê quán";
            this.queQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.queQuan.Width = 98;
            // 
            // ngaySinh
            // 
            this.ngaySinh.Text = "Ngày sinh";
            this.ngaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngaySinh.Width = 90;
            // 
            // soDienThoai
            // 
            this.soDienThoai.Text = "Số điện thoại";
            this.soDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soDienThoai.Width = 117;
            // 
            // soCMND
            // 
            this.soCMND.Text = "Số CMND";
            this.soCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soCMND.Width = 96;
            // 
            // luong
            // 
            this.luong.Text = "Lương";
            this.luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.luong.Width = 64;
            // 
            // chucVu
            // 
            this.chucVu.Text = "Chức vụ";
            this.chucVu.Width = 76;
            // 
            // lbHoTenNV
            // 
            this.lbHoTenNV.AutoSize = true;
            this.lbHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTenNV.ForeColor = System.Drawing.Color.Blue;
            this.lbHoTenNV.Location = new System.Drawing.Point(12, 61);
            this.lbHoTenNV.Name = "lbHoTenNV";
            this.lbHoTenNV.Size = new System.Drawing.Size(81, 20);
            this.lbHoTenNV.TabIndex = 1;
            this.lbHoTenNV.Text = "Họ và Tên";
            // 
            // lbDiaChiNV
            // 
            this.lbDiaChiNV.AutoSize = true;
            this.lbDiaChiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChiNV.ForeColor = System.Drawing.Color.Blue;
            this.lbDiaChiNV.Location = new System.Drawing.Point(14, 102);
            this.lbDiaChiNV.Name = "lbDiaChiNV";
            this.lbDiaChiNV.Size = new System.Drawing.Size(57, 20);
            this.lbDiaChiNV.TabIndex = 1;
            this.lbDiaChiNV.Text = "Địa chỉ";
            // 
            // lbQueQuanNV
            // 
            this.lbQueQuanNV.AutoSize = true;
            this.lbQueQuanNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQueQuanNV.ForeColor = System.Drawing.Color.Blue;
            this.lbQueQuanNV.Location = new System.Drawing.Point(12, 148);
            this.lbQueQuanNV.Name = "lbQueQuanNV";
            this.lbQueQuanNV.Size = new System.Drawing.Size(79, 20);
            this.lbQueQuanNV.TabIndex = 1;
            this.lbQueQuanNV.Text = "Quê quán";
            // 
            // lbNgaySinhNV
            // 
            this.lbNgaySinhNV.AutoSize = true;
            this.lbNgaySinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgaySinhNV.ForeColor = System.Drawing.Color.Blue;
            this.lbNgaySinhNV.Location = new System.Drawing.Point(15, 188);
            this.lbNgaySinhNV.Name = "lbNgaySinhNV";
            this.lbNgaySinhNV.Size = new System.Drawing.Size(78, 20);
            this.lbNgaySinhNV.TabIndex = 1;
            this.lbNgaySinhNV.Text = "Ngày sinh";
            // 
            // lbSoDTNV
            // 
            this.lbSoDTNV.AutoSize = true;
            this.lbSoDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoDTNV.ForeColor = System.Drawing.Color.Blue;
            this.lbSoDTNV.Location = new System.Drawing.Point(494, 61);
            this.lbSoDTNV.Name = "lbSoDTNV";
            this.lbSoDTNV.Size = new System.Drawing.Size(102, 20);
            this.lbSoDTNV.TabIndex = 1;
            this.lbSoDTNV.Text = "Số điện thoại";
            // 
            // lbSoCMNDNV
            // 
            this.lbSoCMNDNV.AutoSize = true;
            this.lbSoCMNDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoCMNDNV.ForeColor = System.Drawing.Color.Blue;
            this.lbSoCMNDNV.Location = new System.Drawing.Point(494, 105);
            this.lbSoCMNDNV.Name = "lbSoCMNDNV";
            this.lbSoCMNDNV.Size = new System.Drawing.Size(78, 20);
            this.lbSoCMNDNV.TabIndex = 1;
            this.lbSoCMNDNV.Text = "Số CNND";
            // 
            // lbChucVuNV
            // 
            this.lbChucVuNV.AutoSize = true;
            this.lbChucVuNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucVuNV.ForeColor = System.Drawing.Color.Blue;
            this.lbChucVuNV.Location = new System.Drawing.Point(494, 194);
            this.lbChucVuNV.Name = "lbChucVuNV";
            this.lbChucVuNV.Size = new System.Drawing.Size(66, 20);
            this.lbChucVuNV.TabIndex = 1;
            this.lbChucVuNV.Text = "Chức vụ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(131, 55);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 26);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(133, 99);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(243, 26);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(133, 145);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(243, 26);
            this.txtQueQuan.TabIndex = 2;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(133, 188);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(243, 26);
            this.txtNgaySinh.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(605, 58);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(246, 26);
            this.txtSDT.TabIndex = 2;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(605, 102);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(246, 26);
            this.txtCMND.TabIndex = 2;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(605, 191);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(246, 26);
            this.txtChucVu.TabIndex = 2;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(209, 233);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(132, 45);
            this.btnThemNV.TabIndex = 3;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // lbQLKH
            // 
            this.lbQLKH.AutoSize = true;
            this.lbQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLKH.ForeColor = System.Drawing.Color.Red;
            this.lbQLKH.Location = new System.Drawing.Point(320, 9);
            this.lbQLKH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbQLKH.Name = "lbQLKH";
            this.lbQLKH.Size = new System.Drawing.Size(252, 29);
            this.lbQLKH.TabIndex = 4;
            this.lbQLKH.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.ForeColor = System.Drawing.Color.Red;
            this.btnXoaNV.Location = new System.Drawing.Point(517, 233);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(132, 45);
            this.btnXoaNV.TabIndex = 3;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCapNhatNV.Location = new System.Drawing.Point(364, 233);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(132, 45);
            this.btnCapNhatNV.TabIndex = 3;
            this.btnCapNhatNV.Text = "Cập nhật";
            this.btnCapNhatNV.UseVisualStyleBackColor = true;
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // lbLuongNV
            // 
            this.lbLuongNV.AutoSize = true;
            this.lbLuongNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLuongNV.ForeColor = System.Drawing.Color.Blue;
            this.lbLuongNV.Location = new System.Drawing.Point(494, 151);
            this.lbLuongNV.Name = "lbLuongNV";
            this.lbLuongNV.Size = new System.Drawing.Size(54, 20);
            this.lbLuongNV.TabIndex = 1;
            this.lbLuongNV.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(605, 148);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(246, 26);
            this.txtLuong.TabIndex = 2;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 550);
            this.Controls.Add(this.lbQLKH);
            this.Controls.Add(this.btnCapNhatNV);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbQueQuanNV);
            this.Controls.Add(this.lbDiaChiNV);
            this.Controls.Add(this.lbLuongNV);
            this.Controls.Add(this.lbChucVuNV);
            this.Controls.Add(this.lbSoCMNDNV);
            this.Controls.Add(this.lbSoDTNV);
            this.Controls.Add(this.lbNgaySinhNV);
            this.Controls.Add(this.lbHoTenNV);
            this.Controls.Add(this.listViewNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyNhanVien";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNV;
        private System.Windows.Forms.ColumnHeader maNV;
        private System.Windows.Forms.ColumnHeader hoTen;
        private System.Windows.Forms.ColumnHeader diaChi;
        private System.Windows.Forms.ColumnHeader queQuan;
        private System.Windows.Forms.ColumnHeader ngaySinh;
        private System.Windows.Forms.ColumnHeader soDienThoai;
        private System.Windows.Forms.ColumnHeader soCMND;
        private System.Windows.Forms.ColumnHeader luong;
        private System.Windows.Forms.Label lbHoTenNV;
        private System.Windows.Forms.Label lbDiaChiNV;
        private System.Windows.Forms.Label lbQueQuanNV;
        private System.Windows.Forms.Label lbNgaySinhNV;
        private System.Windows.Forms.Label lbSoDTNV;
        private System.Windows.Forms.Label lbSoCMNDNV;
        private System.Windows.Forms.Label lbChucVuNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label lbQLKH;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnCapNhatNV;
        private System.Windows.Forms.Label lbLuongNV;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.ColumnHeader chucVu;

    }
}