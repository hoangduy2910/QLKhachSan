using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKhachSan;

namespace TestQLKhachSan
{
    [TestClass]
    public class UnitTestFrmLogin
    {
        private string user, pass;

        [TestInitialize]
        public void SetUp()
        {
            this.user = "admin";
            this.pass = "123";
        }

        [TestMethod]
        public void TestDangNhapThanhCong()
        {
            Assert.AreEqual(this.user, "admin");
            Assert.AreEqual(this.pass, "123");
        }

        [TestMethod]
        public void TestDangNhapSaiUsername()
        {
            Assert.AreNotEqual(this.user, "admin123");
            Assert.AreEqual(this.pass, "123");
        }

        [TestMethod]
        public void TestDangSaiPassword()
        {
            Assert.AreEqual(this.user, "admin");
            Assert.AreNotEqual(this.pass, "12345");
        }

        [TestMethod]
        public void TestKhongNhapUserName()
        {
            Assert.AreNotEqual(this.user, "");
            Assert.AreEqual(this.pass, "123");
        }

        [TestMethod]
        public void TestKhongNhapPassword()
        {
            Assert.AreEqual(this.user, "admin");
            Assert.AreNotEqual(this.pass, "");
        }

        [TestMethod]
        public void TestKhongNhapUserNameVaPassword()
        {
            Assert.AreNotEqual(this.user, "");
            Assert.AreNotEqual(this.pass, "");
        }
    }
}
