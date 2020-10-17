using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_Qlbanhang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Qlbanhang;
namespace DAL_Qlbanhang.Tests
{
    [TestClass()]
    public class DAL_KhachHangTests
    {
        [TestMethod()]
        [Priority(1)]
        public void XoaKH01()
        {
            
            DAL_KhachHang delete = new DAL_KhachHang();
           
            bool result = delete.DeleteKhach("0909878655");

            Assert.IsTrue(result);

        }

        [TestMethod()]
        [Priority(1)]
        public void XoaKH02()
        {

            DAL_KhachHang delete = new DAL_KhachHang();

            bool result = delete.DeleteKhach("");

            Assert.IsFalse(result);

        }




        [TestMethod()]
        [Priority(3)]
        public void THemKH01()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang add = new DAL_KhachHang();
            kh.SoDienThoai = "0909878655";
            kh.TenKhach = "Thị Nhung";
            kh.DiaChi = "Tây Ninh";
            kh.EmailNV = "duydtps11681@fpt.edu.vn";
            kh.Phai = "Nữ";
            bool result = add.ThemKhach(kh);

            Assert.IsTrue(result);

        }




        [TestMethod()]
        [Priority(3)]
        public void ThemKhach002()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang add = new DAL_KhachHang();
            kh.SoDienThoai = "";
            kh.TenKhach = "Thị Nhung";
            kh.DiaChi = "Tây Ninh";
            kh.EmailNV = "";
            kh.Phai = "Nữ";
            bool result = add.ThemKhach(kh);

            Assert.IsFalse(result);

        }
        [TestMethod()]
        [Priority(2)]
        public void Upadate01()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang Upd = new DAL_KhachHang();
            kh.SoDienThoai = "0909878655";
            kh.TenKhach = "Thị Nhung";
            kh.DiaChi = "Tây Ninh";
            kh.EmailNV = "duydtps11681@fpt.edu.vn";
            kh.Phai = "Nữ";
            bool result = Upd.UpdateKhach(kh);

            Assert.IsTrue(result);

        }

        [TestMethod()]
        [Priority(2)]
        public void Upadate02()
        {
            DTO_KhachHang kh = new DTO_KhachHang();
            DAL_KhachHang Upd = new DAL_KhachHang();
            kh.SoDienThoai = "";
            kh.TenKhach = "Thị Nhung";
            kh.DiaChi = "Tây Ninh";
            kh.EmailNV = "duydtps11681@fpt.edu.vn";
            kh.Phai = "Nữ";
            bool result = Upd.UpdateKhach(kh);

            Assert.IsFalse(result);

        }


    }
}
