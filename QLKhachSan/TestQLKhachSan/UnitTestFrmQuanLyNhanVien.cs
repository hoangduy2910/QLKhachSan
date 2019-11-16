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
        List<NhanVien> listNV = new List<NhanVien>();
        frmQuanLyNhanVien QLNV;
        NhanVien nv1, nv3;

        [TestInitialize]
        public void SetUp()
        {
            nv1 = new NhanVien("NV1", "Nguyễn Hoàng Duy", "123 TP.HCM", "TP.HCM", "01/01/1999", "123456789", "987654321", "100000", "Tiếp tân");
            nv3 = new NhanVien("NV3", "Lương Xuân Bảo", "456 TP.HCM", "TP.HCM", "02/06/2000", "123456789", "987654321", "200000", "Đầu bếp");
            QLNV = new frmQuanLyNhanVien();
            listNV = QLNV.layDSNV();
        }
     
        [TestMethod]
        public void TestThemNhanVienThanhCong()
        {
            for (int i = 0; i < listNV.Count; i++)
                Assert.AreNotEqual(listNV[i].maNV, nv3.maNV);
        }

        [TestMethod]
        public void TestThemNhanVienKhongThanhCongDoTrungMaNV()
        {
            for (int i = 0; i < listNV.Count; i++)
            {
                Assert.AreEqual(listNV[i].maNV, nv1.maNV);
                if (listNV[i].maNV == nv1.maNV)
                    break;
            }
        }
    }
}
