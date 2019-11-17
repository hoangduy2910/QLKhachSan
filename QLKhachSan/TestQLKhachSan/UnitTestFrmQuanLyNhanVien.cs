using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKhachSan;

namespace TestQLKhachSan
{
    [TestClass]
    public class UnitTestFrmQuanLyNhanVien
    {  
        frmQuanLyNhanVien QLNV;
        List<NhanVien> listNV;
        NhanVien nVThemDuoc, nVKhongThemDuoc, nVCapNhat, nVXoaDuoc, nVKhongXoaDuoc;

        [TestInitialize]
        public void SetUp()
        {
            nVThemDuoc = new NhanVien("NV3", "Lương Xuân Bảo", "456 TP.HCM", "TP.HCM", "02/06/2000", "123456789", "987654321", "200000", "Đầu bếp");
            nVKhongThemDuoc = new NhanVien("NV1", "Nguyễn Hoàng Duy", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321", "100000", "Tiếp tân");
            nVCapNhat = new NhanVien("NV1", "Nguyễn Hoàng Duy", "123465 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321", "100000", "Tiếp tân");
            nVXoaDuoc = new NhanVien("NV1", "Nguyễn Hoàng Duy", "123465 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321", "100000", "Tiếp tân");
            nVKhongXoaDuoc = new NhanVien("NV10", "Nguyễn Văn B", "123465 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321", "100000", "Tiếp tân");

            QLNV = new frmQuanLyNhanVien();
            listNV = QLNV.layDSNV();
        }
     
        [TestMethod]
        public void TestThemNhanVienThanhCong()
        {
            for (int i = 0; i < listNV.Count; i++)
                Assert.AreNotEqual(listNV[i].maNV, nVThemDuoc.maNV);
        }

        [TestMethod]
        public void TestThemNhanVienKhongThanhCongDoTrungMaNV()
        {
            for (int i = 0; i < listNV.Count; i++)
            {
                Assert.AreEqual(listNV[i].maNV, nVKhongThemDuoc.maNV);
                if (listNV[i].maNV == nVKhongThemDuoc.maNV)
                    break;
            }
        }

        [TestMethod]
        public void TestCapNhatNhanVienThanhCong()
        {
            for (int i = 0; i < listNV.Count; i++)
            {
                if (listNV[i].maNV == nVCapNhat.maNV)
                {
                    Assert.AreNotEqual(listNV[i], nVCapNhat.maNV);
                    break;
                }
            }
        }

        [TestMethod]
        public void TestXoaNhanVienThanhCong()
        {
            for (int i = 0; i < listNV.Count; i++)
            {
                Assert.AreEqual(listNV[i].maNV, nVXoaDuoc.maNV);
                if (listNV[i].maNV == nVXoaDuoc.maNV)
                    break;
            }
        }

        [TestMethod]
        public void TestXoaNhanVienKhongThanhCong()
        {
            for (int i = 0; i < listNV.Count; i++)
                Assert.AreNotEqual(listNV[i].maNV, nVKhongXoaDuoc.maNV);
        }
    }
}
