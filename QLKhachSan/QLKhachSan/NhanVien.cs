using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKhachSan
{
    public class NhanVien
    {
        public string maNV, hoTen, diaChi, queQuan, ngaySinh, soDienThoai, soCMND, luong;

        public NhanVien(string maNV, string hoTen, string diaChi, string queQuan, string ngaySinh, string soDienThoai, string soCMND,string luong)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh; 
            this.soDienThoai = soDienThoai; 
            this.soCMND = soCMND;
            this.luong = luong;
        }
    }
}
