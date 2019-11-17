using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKhachSan;

namespace TestQLKhachSan
{
    [TestClass]
    public class UnitTestFrmQuanLyPhong
    {
        frmQuanLyPhong QLPhong;
        List<Phong> listPhong;
        Phong phongCapNhat;

        [TestInitialize]
        public void SetUp()
        {
            phongCapNhat = new Phong("101", "Đơn", "Đang ở", "17/11/2019", "20/11/2019", "Nguyễn Văn A", "987654321");

            QLPhong = new frmQuanLyPhong();
            listPhong = QLPhong.layDSPhong();
        }

        [TestMethod]
        public void TestCapNhatPhongThanhCong()
        {
            for (int i = 0; i < listPhong.Count; i++)
            {
                if (listPhong[i].maPhong == phongCapNhat.maPhong)
                {
                    Assert.AreNotEqual(listPhong[i], phongCapNhat);
                    break;
                }
            }
        }
    }
}
