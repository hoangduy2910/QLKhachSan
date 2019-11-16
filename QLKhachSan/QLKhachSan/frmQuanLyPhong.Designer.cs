namespace QLKhachSan
{
    partial class frmQuanLyPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeNgayVao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.listViewPhong = new System.Windows.Forms.ListView();
            this.maPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayVao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayDi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.radioBtnTrong = new System.Windows.Forms.RadioButton();
            this.radioBtnDangO = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ Ngày";
            // 
            // dateTimeNgayVao
            // 
            this.dateTimeNgayVao.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayVao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayVao.Location = new System.Drawing.Point(90, 128);
            this.dateTimeNgayVao.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeNgayVao.Name = "dateTimeNgayVao";
            this.dateTimeNgayVao.Size = new System.Drawing.Size(227, 29);
            this.dateTimeNgayVao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(395, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến Ngày";
            // 
            // dateTimeNgayDi
            // 
            this.dateTimeNgayDi.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayDi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayDi.Location = new System.Drawing.Point(505, 128);
            this.dateTimeNgayDi.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeNgayDi.Name = "dateTimeNgayDi";
            this.dateTimeNgayDi.Size = new System.Drawing.Size(210, 29);
            this.dateTimeNgayDi.TabIndex = 2;
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrang.ForeColor = System.Drawing.Color.Blue;
            this.lbTinhTrang.Location = new System.Drawing.Point(501, 73);
            this.lbTinhTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(90, 22);
            this.lbTinhTrang.TabIndex = 1;
            this.lbTinhTrang.Text = "Tình trạng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Location = new System.Drawing.Point(298, 250);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(127, 42);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // listViewPhong
            // 
            this.listViewPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maPhong,
            this.loaiPhong,
            this.tinhTrang,
            this.ngayVao,
            this.ngayDi,
            this.tenKH,
            this.soCMND});
            this.listViewPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPhong.FullRowSelect = true;
            this.listViewPhong.Location = new System.Drawing.Point(13, 316);
            this.listViewPhong.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPhong.Name = "listViewPhong";
            this.listViewPhong.Size = new System.Drawing.Size(702, 169);
            this.listViewPhong.TabIndex = 6;
            this.listViewPhong.UseCompatibleStateImageBehavior = false;
            this.listViewPhong.View = System.Windows.Forms.View.Details;
            this.listViewPhong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewPhong_MouseClick);
            // 
            // maPhong
            // 
            this.maPhong.Text = "Mã Phòng";
            this.maPhong.Width = 98;
            // 
            // loaiPhong
            // 
            this.loaiPhong.Text = "Loại Phòng";
            this.loaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loaiPhong.Width = 100;
            // 
            // tinhTrang
            // 
            this.tinhTrang.Text = "Tình trạng";
            this.tinhTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tinhTrang.Width = 97;
            // 
            // ngayVao
            // 
            this.ngayVao.Text = "Ngày vào";
            this.ngayVao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngayVao.Width = 88;
            // 
            // ngayDi
            // 
            this.ngayDi.Text = "Ngày đi";
            this.ngayDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ngayDi.Width = 79;
            // 
            // tenKH
            // 
            this.tenKH.Text = "Khách hàng";
            this.tenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tenKH.Width = 143;
            // 
            // soCMND
            // 
            this.soCMND.Text = "CMND";
            this.soCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soCMND.Width = 90;
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.ForeColor = System.Drawing.Color.Blue;
            this.lbPhong.Location = new System.Drawing.Point(11, 73);
            this.lbPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(58, 22);
            this.lbPhong.TabIndex = 1;
            this.lbPhong.Text = "Phòng";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhong.Location = new System.Drawing.Point(90, 67);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(133, 30);
            this.txtPhong.TabIndex = 7;
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lbKhachHang.Location = new System.Drawing.Point(11, 189);
            this.lbKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(131, 22);
            this.lbKhachHang.TabIndex = 1;
            this.lbKhachHang.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(395, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "CMND";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKhachHang.Location = new System.Drawing.Point(147, 183);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(170, 30);
            this.txtKhachHang.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCMND.Location = new System.Drawing.Point(505, 183);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(209, 30);
            this.txtCMND.TabIndex = 7;
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong.ForeColor = System.Drawing.Color.Blue;
            this.lbLoaiPhong.Location = new System.Drawing.Point(254, 73);
            this.lbLoaiPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(99, 22);
            this.lbLoaiPhong.TabIndex = 1;
            this.lbLoaiPhong.Text = "Loại Phòng";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiPhong.Location = new System.Drawing.Point(358, 67);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.ReadOnly = true;
            this.txtLoaiPhong.Size = new System.Drawing.Size(105, 30);
            this.txtLoaiPhong.TabIndex = 7;
            // 
            // radioBtnTrong
            // 
            this.radioBtnTrong.AutoSize = true;
            this.radioBtnTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioBtnTrong.ForeColor = System.Drawing.Color.Blue;
            this.radioBtnTrong.Location = new System.Drawing.Point(610, 58);
            this.radioBtnTrong.Name = "radioBtnTrong";
            this.radioBtnTrong.Size = new System.Drawing.Size(68, 24);
            this.radioBtnTrong.TabIndex = 8;
            this.radioBtnTrong.TabStop = true;
            this.radioBtnTrong.Text = "Trống";
            this.radioBtnTrong.UseVisualStyleBackColor = true;
            // 
            // radioBtnDangO
            // 
            this.radioBtnDangO.AutoSize = true;
            this.radioBtnDangO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioBtnDangO.ForeColor = System.Drawing.Color.Blue;
            this.radioBtnDangO.Location = new System.Drawing.Point(610, 90);
            this.radioBtnDangO.Name = "radioBtnDangO";
            this.radioBtnDangO.Size = new System.Drawing.Size(79, 24);
            this.radioBtnDangO.TabIndex = 8;
            this.radioBtnDangO.TabStop = true;
            this.radioBtnDangO.Text = "Đang ở";
            this.radioBtnDangO.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 496);
            this.Controls.Add(this.radioBtnDangO);
            this.Controls.Add(this.radioBtnTrong);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.listViewPhong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dateTimeNgayDi);
            this.Controls.Add(this.dateTimeNgayVao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbLoaiPhong);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyPhong";
            this.Load += new System.EventHandler(this.frmQuanLyPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeNgayVao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDi;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ListView listViewPhong;
        private System.Windows.Forms.ColumnHeader maPhong;
        private System.Windows.Forms.ColumnHeader loaiPhong;
        private System.Windows.Forms.ColumnHeader tinhTrang;
        private System.Windows.Forms.ColumnHeader ngayVao;
        private System.Windows.Forms.ColumnHeader ngayDi;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.ColumnHeader tenKH;
        private System.Windows.Forms.ColumnHeader soCMND;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.RadioButton radioBtnTrong;
        private System.Windows.Forms.RadioButton radioBtnDangO;
    }
}