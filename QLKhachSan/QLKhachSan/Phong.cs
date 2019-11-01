using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKhachSan
{
    public class Phong
    {
        public string maPh, tinhTrang, checkin, checkout, tenPh, ghiChu;
        public Phong(string maPh, string tinhTrang, string checkin, string checkout, string tenPh, string ghiChu)
        {
            this.maPh = maPh;
            this.tinhTrang = tinhTrang;
            this.checkin = checkin;
            this.checkout = checkout;
            this.tenPh = tenPh;
            this.ghiChu = ghiChu;
        }
    }
}
