using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Qlbanhang;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Qlbanhang
{
    public class DAL_NhanVien:Dbconnect
    {
        public DataTable getNhanVien()
        {
            
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DanhSachNV";
                cm.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cm.ExecuteReader());
                return dtNV;
            }
            finally
            {
               
                _conn.Close();
            }

        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {  
            try
            {
                _conn.Open(); 
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_InsertNhanVien";
                cm.Parameters.AddWithValue("email", nv.EmailNV);
                cm.Parameters.AddWithValue("tennv", nv.TenNhanVien);
                cm.Parameters.AddWithValue("diachi", nv.DiaChi);
                cm.Parameters.AddWithValue("vaiTro", nv.VaiTro);
                cm.Parameters.AddWithValue("tinhTrang", nv.TinhTrang);
            
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                
                _conn.Close();
            }
            return false;
        }

        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            try
            {       
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_UpdateNhanVien";
                cm.Parameters.AddWithValue("email", nv.EmailNV);
                cm.Parameters.AddWithValue("Tennv", nv.TenNhanVien);
                cm.Parameters.AddWithValue("diaChi", nv.DiaChi);
                cm.Parameters.AddWithValue("vaiTro", nv.VaiTro);
                cm.Parameters.AddWithValue("tinhTrang", nv.TinhTrang);
               
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                
                _conn.Close();
            }
            return false;
        }

        public bool DeleteNhanVien(string email)
        {
           
            try
            {
                
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DeleteNhanVien";
                cm.Parameters.AddWithValue("email", email);
                cm.Connection = _conn;
                
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                
                _conn.Close();
            }
            return false;
        }
        public DataTable SearchNhanVien(string tenNhanvien)
        {
           
            try
            {
               
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_SearchNhanVien";
                cm.Parameters.AddWithValue("tenNV", tenNhanvien);
                cm.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cm.ExecuteReader());
                return dtNV;
            }
            finally
            {
               
                _conn.Close();
            }
        }

        // DAL lien quan den tai khoan
        public bool DangNhap(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DangNhap";
                cm.Parameters.AddWithValue("email", nv.EmailNV);
                cm.Parameters.AddWithValue("matKhau", nv.MatKhau);
                if ((int)(cm.ExecuteScalar()) > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                _conn.Close();
            }
            return false;
        }
        public int VaiTro(string email)
        {

            try
            {

                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_LayVaiTroNV";
                cm.Parameters.AddWithValue("email", email);
                cm.Connection = _conn;

                return int.Parse(cm.ExecuteScalar().ToString());
            }
            finally
            {

                _conn.Close();
            }
        }

        public bool DoiMatKhau(string email, string passOld, string passNew)
        {

            try
            {

                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DoiMatKhau";
                cm.Parameters.AddWithValue("email", email);
                cm.Parameters.AddWithValue("@opwd", passOld);
                cm.Parameters.AddWithValue("@npwd", passNew);

                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                _conn.Close();
            }
            return false;
        }

        public bool QuenMatKhau(string email)
        {

            try
            {

                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_QuenMatKhau";
                cm.Parameters.AddWithValue("email", email);
                if ((int)(cm.ExecuteScalar()) > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool TaoMatKhau(string email, string passNew)
        {

            try
            {

                _conn.Open();

                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_TaoMatKhauMoi";
                cm.Parameters.AddWithValue("email", email);
                cm.Parameters.AddWithValue("matkhau", passNew);
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                _conn.Close();
            }
            return false;
        }

    }
}
