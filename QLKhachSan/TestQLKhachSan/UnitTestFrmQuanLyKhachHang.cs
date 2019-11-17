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
        frmQuanLyKhachHang QLKH;
        List<KhachHang> listKH;
        KhachHang kHThemDuoc, kHKhongThemDuoc, kHCapNhat, kHXoaDuoc, kHKhongXoaDuoc;

        [TestInitialize]
        public void SetUp()
        {
            kHThemDuoc = new KhachHang("KH4", "Trần Thị B", "456 TP.HCM", "Đà Nẵng", "02/06/2000", "123456789", "987654321");
            kHKhongThemDuoc = new KhachHang("KH1", "Nguyễn Văn A", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321");
            kHCapNhat = new KhachHang("KH1", "Nguyễn Văn A", "123456 TP.HCM", "TP.HCM", "01/01/1999", "123454321", "987654321");
            kHXoaDuoc = new KhachHang("KH1", "Nguyễn Văn A", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321");
            kHKhongXoaDuoc = new KhachHang("KH10", "Nguyễn Văn D", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321");
            
            QLKH = new frmQuanLyKhachHang();
            listKH = QLKH.layDSKH();
        }

        [TestMethod]
        public void TestThemKhachHangThanhCong()
        {
            for (int i = 0; i < listKH.Count; i++)
                Assert.AreNotEqual(listKH[i].maKH, kHThemDuoc.maKH);
        }

        [TestMethod]
        public void TestThemKhachHangKhongThanhCongDoTrungMaKH()
        {
            for (int i = 0; i < listKH.Count; i++)
            {
                Assert.AreEqual(listKH[i].maKH, kHKhongThemDuoc.maKH);
                if (listKH[i].maKH == kHKhongThemDuoc.maKH)
                    break;
            }
        }

        [TestMethod]
        public void TestCapNhatKhachHangThanhCong()
        {
            for (int i = 0; i < listKH.Count; i++)
            {
                if (listKH[i].maKH == kHCapNhat.maKH)
                {
                    Assert.AreNotEqual(listKH[i], kHCapNhat);
                    break;
                }
            }
        }

        [TestMethod]
        public void TestXoaKhachHangThanhCong()
        {
            for (int i = 0; i < listKH.Count; i++)
            {
                Assert.AreEqual(listKH[i].maKH, kHXoaDuoc.maKH);
                if (listKH[i].maKH == kHXoaDuoc.maKH)
                    break;
            }
        }

        [TestMethod]
        public void TestXoaKhachHangKhongThanhCong()
        {
            for (int i = 0; i < listKH.Count; i++)
                Assert.AreNotEqual(listKH[i].maKH, kHKhongXoaDuoc.maKH);
        }
    }
}
