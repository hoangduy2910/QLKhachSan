using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKhachSan
{
    public class Phong
    {
        public string maPhong, loaiPhong, tinhTrang, ngayVao, ngayDi, tenKH, soCMND;

        public Phong(string maPhong, string loaiPhong, string tinhTrang, string ngayVao, string ngayDi, string tenKH, string soCMND)
        {
            this.maPhong = maPhong;
            this.loaiPhong = loaiPhong;
            this.tinhTrang = tinhTrang;
            this.ngayVao = ngayVao;
            this.ngayDi = ngayDi;
            this.tenKH = tenKH;
            this.soCMND = soCMND;
        }
    }
}
