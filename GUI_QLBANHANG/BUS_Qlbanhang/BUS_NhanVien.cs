using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Qlbanhang;
using DAL_Qlbanhang;
using System.Security.Cryptography;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace BUS_Qlbanhang
{
 
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();

        public void SendMailQuenMK(string email, string matkhau)
        {
            

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   //smtp.gmail.com // port 587




                NetworkCredential account = new NetworkCredential("testmailfptclient@gmail.com", "Online1@!");

                MailMessage Msg = new MailMessage();

                Msg.From = new MailAddress("duydtps11681@gfpt.edu.vn");

                Msg.To.Add(email);

                Msg.Subject = "Ban da su dung tinh nang quen Mat khau";

                Msg.Body = "Chào anh/chị. Mật khẩu moi truy cập phần mềm là " + matkhau;

                client.Credentials = account;

                client.EnableSsl = true;
                client.Send(Msg);

               
            
           
        }

        public void SendMailDoiMK(string email, string matkhau)
        {


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   //smtp.gmail.com // port 587




            NetworkCredential account = new NetworkCredential("testmailfptclient@gmail.com", "Online1@!");

            MailMessage Msg = new MailMessage();

            Msg.From = new MailAddress("duydtps11681@gfpt.edu.vn");

            Msg.To.Add(email);

            Msg.Subject = "Thay đổi mật khẩu";

            Msg.Body = "Chào bạn. Bạn vừa tiến hành dổi mật khẩu! Mật khẩu mới là: " + matkhau;

            client.Credentials = account;

            client.EnableSsl = true;
            client.Send(Msg);




        }

        public void SendMailNewNV(string email)
        {


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   //smtp.gmail.com // port 587




            NetworkCredential account = new NetworkCredential("testmailfptclient@gmail.com", "Online1@!");

            MailMessage Msg = new MailMessage();

            Msg.From = new MailAddress("testmailfptclient@gmail.com");

            Msg.To.Add(email);

            Msg.Subject = "Chào mừng bạn đến với DTL";

            Msg.Body = "Chào bạn! Mật khẩu đăng nhập phần mềm là: fpt123";

            client.Credentials = account;

            client.EnableSsl = true;
            client.Send(Msg);




        }
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.ThemNhanVien(nv);
        }
        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.UpdateNhanVien(nv);
        }
        public bool DeleteNhanVien(string tenDangNhap)
        {
            return dalNhanVien.DeleteNhanVien(tenDangNhap);
        }
        public DataTable SearchNhanVien(string tenNhanvien)
        {
            return dalNhanVien.SearchNhanVien(tenNhanvien);
        }

        //Bus lien quan den tai khoan
      
        public bool DangNhap(DTO_NhanVien nv)
        {
            return dalNhanVien.DangNhap(nv);
        }

        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();

            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();

            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
        public int VaiTroNhanVien(string email)
        {
            return dalNhanVien.VaiTro(email);
        }
        public bool UpdateMatKhau(string email, string matKhauCu, string matKhauMoi)
        {
            return dalNhanVien.DoiMatKhau(email, matKhauCu, matKhauMoi);
        }
        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanVien.QuenMatKhau(email);
        }
        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            return dalNhanVien.TaoMatKhau(email, matKhauMoi);
        }

    }
}
