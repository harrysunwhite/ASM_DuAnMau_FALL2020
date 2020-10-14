using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Qlbanhang;
using BUS_Qlbanhang;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;

namespace GUI_QLBANHANG
{
    public partial class FrmDangNhap : Form
    {
        private BUS_NhanVien busNV = new BUS_NhanVien();

        public int vaitro { get; set; }
        public FrmDangNhap()
        {
            InitializeComponent();
        }
   
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            FrmMain.CheckLogin = 0;
            try
            {
                string startupPath = Environment.CurrentDirectory;
                string txtpath = Directory.GetParent(startupPath).Parent.Parent.FullName;
                string file = txtpath + @"\UserInfor.txt";
               
                using (FileStream fsr = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fsr))
                    {
                        txtemail.Text = sr.ReadToEnd();
                       
                    }
                }




            }
            catch
            {
                
            }
        }

        private void writeUserInfor(DTO_NhanVien nv)
        {

            try
            {
                string startupPath = Environment.CurrentDirectory;
                string txtpath = Directory.GetParent(startupPath).Parent.Parent.FullName;
                string file = txtpath + @"\UserInfor.txt";
                if (!File.Exists(file))
                {
                    using (var stream = File.Create(file))
                    {

                    }
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        sw.Write(nv.EmailNV);
                    }
                }
                else
                    using (StreamWriter sw = new StreamWriter(file, false))
                    {
                        sw.Write(nv.EmailNV);
                    }




            }





            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private bool sendMail(StringBuilder builder)
        {

            try
            {
                busNV.SendMailQuenMK(txtemail.Text, builder.ToString());
                return true;

            }
            catch
            {
                return false;

            }
           
        }

       
        //public void SendMail(string email, string matkhau)
        //{
        //    try
        //    {

        //        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   //smtp.gmail.com // port 587




        //        NetworkCredential account = new NetworkCredential("testmailfptclient@gmail.com", "Online1@!");

        //        MailMessage Msg = new MailMessage();

        //        Msg.From = new MailAddress("duydtps11681@gfpt.edu.vn");

        //        Msg.To.Add(email);

        //        Msg.Subject = "Ban da su dung tinh nang quen Mat khau";

        //        Msg.Body = "Chào anh/chị. Mật khẩu moi truy cập phần mềm là " + matkhau;

        //        client.Credentials = account;
               
        //        client.EnableSsl = true;
        //        client.Send(Msg);

        //        MessageBox.Show("Vui lòng kiểm tra hòm thư, Một email với thông tin mật khẩu đã được gửi tới bạn!");
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //public string encryption(string password)
        //{
        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    byte[] encrypt;
        //    UTF8Encoding encode = new UTF8Encoding();
            
        //    encrypt = md5.ComputeHash(encode.GetBytes(password));
        //    StringBuilder encryptdata = new StringBuilder();
            
        //    for (int i = 0; i < encrypt.Length; i++)
        //    {
        //        encryptdata.Append(encrypt[i].ToString());
        //    }
        //    return encryptdata.ToString();
        //}

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.EmailNV = txtemail.Text;
            nv.MatKhau = busNV.encryption(txtmatkhau.Text);

           
            if (busNV.DangNhap(nv))
            {
                if (busNV.TinhTrangNV(nv.EmailNV) == 1)
                {
                 

                    if (chkbSave.Checked == true) writeUserInfor(nv);
                   

                        FrmMain.mail = nv.EmailNV;
                        FrmMain.Role = busNV.VaiTroNhanVien(txtemail.Text);

                        MessageBox.Show("Đăng nhập thành công");
                        FrmMain.CheckLogin = 1;
                    if (busNV.CheckDoiMatkhau(nv.EmailNV) == 1)
                    {
                        FrmMain.CheckDoiMatKhau = 1;
                        
                    }
                    else
                    {
                        FrmMain.CheckDoiMatKhau = 0;
                        MessageBox.Show("Bạn là nhân viên mới vui lòng vào hổ sơ nhân viên dể đổi mật khẩu ở lần đầu đăng nhập");
                        
                    }
                    this.Close();




                }

                else MessageBox.Show("Tài khoản này đang bị ngưng hoạt động vui lòng liên hệ quản lý!");
               
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, kiểm tra lại email hoặc mật khẩu");
              
                txtmatkhau.Text = null;
                txtmatkhau.Focus();
            }
        }

        private void btnQuenmk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtemail.Text))
            {
                if (busNV.NhanVienQuenMatKhau(txtemail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                   
                    string matkhaumoi = busNV.encryption(builder.ToString());
                    if (busNV.TaoMatKhau(txtemail.Text, matkhaumoi)&& sendMail(builder))
                    {
                        MessageBox.Show("Vui lòng kiểm tra hòm thư, Một email với thông tin mật khẩu đã được gửi tới bạn!");
                    }
                        

                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công");
                    }    
                    
                }
                else
                {
                    MessageBox.Show("Email không tồn tại vui lòng nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email đã đăng ký để nhận mật khẩu khôi phục!");
                txtemail.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
