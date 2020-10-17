using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_Qlbanhang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Qlbanhang;
using System.IO;
using System.Data;

namespace DAL_Qlbanhang.Tests
{
     
    [TestClass()]
    public class DAL_HangTests
    {
       static DAL_Hang danhsach = new DAL_Hang();
      
       static  int Mahang = int.Parse(danhsach.getHang().Rows[0][0].ToString());
       static int Mahangupdate = int.Parse(danhsach.getHang().Rows[1][0].ToString());
        



        [TestMethod()]
        [Priority(3)]
        public void getHangTest()
        {
            DAL_Hang danhsach = new DAL_Hang();
           


            Assert.IsNotNull(danhsach.getHang());
        }

        
       

        [TestMethod()]
        [Priority(0)]
        public void XoaHang02()
        {

            

            DAL_Hang delete = new DAL_Hang();

            bool result = delete.DeleteHang(Mahang);

            Assert.IsTrue(result);

        }




        [TestMethod()]
        public void ThemHang01()
        {
            DTO_Hang hang = new DTO_Hang();
            DAL_Hang add = new DAL_Hang();
            hang.TenHang = "Chuột Mitsumi";
            hang.SoLuong = 20;
            hang.DonGiaNhap = 100000;
            hang.DonGiaBan = 120000;
            hang.GhiChu = "";
            hang.EmailNV = "duydtps11681@fpt.edu.vn";
            string startupPath = Environment.CurrentDirectory;
            string file = startupPath + @"\Shopping.png";

            byte[] bytes = Encoding.ASCII.GetBytes(file);
            hang.HinhAnh = bytes;
            bool result = add.ThemHang(hang);

            Assert.IsTrue(result);

        }




        [TestMethod()]
       
        public void ThemKhach002()
        {
            DTO_Hang hang = new DTO_Hang();
            DAL_Hang add = new DAL_Hang();
            hang.TenHang = "Chuột Mitsumi";
            hang.SoLuong = 10;
            hang.DonGiaNhap = 100000;
            hang.DonGiaBan = 120000;
            hang.GhiChu = "";
            hang.EmailNV = "";
            string startupPath = Environment.CurrentDirectory;
            string file = startupPath + @"\Shopping.png";

            byte[] bytes = Encoding.ASCII.GetBytes(file);
            hang.HinhAnh = bytes;
            bool result = add.ThemHang(hang);

            Assert.IsFalse(result);
        }
        [TestMethod()]
       
        public void Upadate01()
        {
            DTO_Hang hang = new DTO_Hang();
            DAL_Hang update = new DAL_Hang();
            hang.MaHang = Mahangupdate;
            hang.TenHang = "Chuột Mitsumi";

            hang.SoLuong = 10;
            hang.DonGiaNhap = 100000;
            hang.DonGiaBan = 120000;
            hang.GhiChu = "";
            hang.EmailNV = "duydtps11681@fpt.edu.vn";
            string startupPath = Environment.CurrentDirectory;
            string file = startupPath + @"\Shopping.png";

            byte[] bytes = Encoding.ASCII.GetBytes(file);
            hang.HinhAnh = bytes;
            bool result = update.UpdateHang(hang);

            Assert.IsTrue(result);

        }

        //[TestMethod()]
        //[Priority(2)]
        //public void Upadate02()
        //{
        //    DTO_KhachHang kh = new DTO_KhachHang();
        //    DAL_KhachHang Upd = new DAL_KhachHang();
        //    kh.SoDienThoai = "";
        //    kh.TenKhach = "Thị Nhung";
        //    kh.DiaChi = "Tây Ninh";
        //    kh.EmailNV = "duydtps11681@fpt.edu.vn";
        //    kh.Phai = "Nữ";
        //    bool result = Upd.UpdateKhach(kh);

        //    Assert.IsFalse(result);

        //}

    }
}