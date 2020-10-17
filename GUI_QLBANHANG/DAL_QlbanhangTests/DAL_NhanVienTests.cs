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
    public class DAL_NhanVienTests
    {
        public string email;
        [TestMethod()]
       
        public void getDanhSach()
        {

            DAL_NhanVien danhsach = new DAL_NhanVien();





            Assert.IsNotNull(danhsach.getNhanVien());
        }


       

        [TestMethod()]
       
        public void NVLogin001()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.EmailNV = "duydtps11681@fpt.edu.vn";
            nv.MatKhau = "362294414513824030813111198602102132";
            bool result = login.DangNhap(nv);
            Assert.IsTrue(result);
        }

        [TestMethod()]
       
        public void NVLogin002()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.EmailNV = "";
            nv.MatKhau = "12345";
            bool result = login.DangNhap(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        

        public void ThemNV()
        {

            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien add = new DAL_NhanVien();
            nv.EmailNV = "coolkakaduy@gmail.com";
            nv.TenNhanVien = "Thanh Duy";
            nv.TinhTrang = 1;
            nv.VaiTro = 1;
            nv.DiaChi = "Tây ninh";
            bool result = add.ThemNhanVien(nv);
            Assert.IsTrue(result);

        }

        [TestMethod()]
        

        public void updateNV01()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien update = new DAL_NhanVien();
            nv.EmailNV = "duydt@gmail.com";
            nv.TenNhanVien = "Thanh Duy";
            nv.TinhTrang = 1;
            nv.VaiTro = 1;
            nv.DiaChi = "Tây ninh";
            bool result = update.UpdateNhanVien(nv);
            Assert.IsTrue(result);

        }

        [TestMethod()]
       
        public void updateNV02()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien update = new DAL_NhanVien();
            nv.EmailNV = "";
            nv.TenNhanVien = "Thanh Duy";
            nv.TinhTrang = 1;
            nv.VaiTro = 1;
            nv.DiaChi = "Tây ninh";
            bool result = update.UpdateNhanVien(nv);
            Assert.IsFalse(result);

        }


        [TestMethod()]
       
        public void xoaNV02()
        {

            DAL_NhanVien delete = new DAL_NhanVien();

            bool result = delete.DeleteNhanVien("");
            Assert.IsFalse(result);

        }
        [TestMethod()]
        [Priority (0)]
        public void xoaNV01()
        {

            DAL_NhanVien delete = new DAL_NhanVien();

            bool result = delete.DeleteNhanVien("coolkakaduy@gmail.com");
            Assert.IsTrue(result);

        }


        [TestMethod()]
        
        public void TaoMatkhauMoi01()
        {

            DAL_NhanVien NewPasss = new DAL_NhanVien();


            bool result = NewPasss.TaoMatKhau("duydt@gmail.com", "aaaaa");
            Assert.IsTrue(result);

        }

        [TestMethod()]
        
        public void TaoMatkhauMoi02()
        {

            DAL_NhanVien NewPasss = new DAL_NhanVien();


            bool result = NewPasss.TaoMatKhau("", "aaaaa");
            Assert.IsFalse(result);

        }
    }
}