using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKhachSan
{
    public class KhachHang
    {
        public string maKH, hoTen, diaChi, queQuan, ngaySinh, soDienThoai, soCMND;

        public KhachHang(string maKH, string hoTen, string diaChi, string queQuan, string ngaySinh, string soDienThoai, string soCMND)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh; 
            this.soDienThoai = soDienThoai; 
            this.soCMND = soCMND;
        }
    }
}
