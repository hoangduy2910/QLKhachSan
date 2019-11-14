using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKhachSan;

namespace TestFormLogin
{
    [TestClass]
    public class UnitTestFormLogin
    {
        private string user, pass;

        [TestInitialize]
        public void setup()
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
            Assert.AreEqual(this.user, "admin123");
            Assert.AreEqual(this.pass, "123");
        }

        [TestMethod]
        public void TestDangSaiPassword()
        {
            Assert.AreEqual(this.user, "admin");
            Assert.AreEqual(this.pass, "12345");
        }

        [TestMethod]
        public void TestKhongNhapUserName()
        {
            Assert.AreEqual(this.user, "");
            Assert.AreEqual(this.pass, "123");
        }

        [TestMethod]
        public void TestKhongNhapPassword()
        {
            Assert.AreEqual(this.user, "admin");
            Assert.AreEqual(this.pass, "");
        }

        [TestMethod]
        public void TestKhongNhapUserNameVaPassword()
        {
            Assert.AreEqual(this.user, "");
            Assert.AreEqual(this.pass, "");
        }
    }
}
