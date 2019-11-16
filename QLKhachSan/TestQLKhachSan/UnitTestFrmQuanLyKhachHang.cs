using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKhachSan;

namespace TestQLKhachSan
{
    [TestClass]
    public class UnitTestFrmQuanLyKhachHang
    {
        List<KhachHang> listKH = new List<KhachHang>();
        frmQuanLyKhachHang QLKH;
        KhachHang kh1, kh4;

        [TestInitialize]
        public void SetUp()
        {
            kh1 = new KhachHang("KH1", "Nguyễn Văn A", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321");
            kh4 = new KhachHang("KH4", "Trần Thị B", "456 TP.HCM", "Đà Nẵng", "02/06/2000", "123456789", "987654321");
            QLKH = new frmQuanLyKhachHang();
            listKH = QLKH.layDSKH();
        }

        [TestMethod]
        public void TestThemKhachHangThanhCong()
        {
            for (int i = 0; i < listKH.Count; i++)
                Assert.AreNotEqual(listKH[i].maKH, kh4.maKH);
        }

        [TestMethod]
        public void TestThemKhachHangKhongThanhCongDoTrungMaKH()
        {
            for (int i = 0; i < listKH.Count; i++)
            {
                Assert.AreEqual(listKH[i].maKH, kh1.maKH);
                if (listKH[i].maKH == kh1.maKH)
                    break;
            }
        }
    }
}
