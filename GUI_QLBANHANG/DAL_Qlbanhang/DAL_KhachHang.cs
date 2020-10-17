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
    public class DAL_KhachHang:Dbconnect
    {
        public DataTable getKhach()
        {

           
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DanhSachKhach";
                cm.Connection = _conn;
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cm.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                
                _conn.Close();
            }
        }

        public bool ThemKhach(DTO_KhachHang kh)
        {
            
            try
            {
               
                _conn.Open();
              
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_InsertKhach";
                cm.Parameters.AddWithValue("Dienthoai", kh.SoDienThoai);
                cm.Parameters.AddWithValue("TenKhach", kh.TenKhach);
                cm.Parameters.AddWithValue("DiaChi", kh.DiaChi);
                cm.Parameters.AddWithValue("phai", kh.Phai);
                cm.Parameters.AddWithValue("Email", kh.EmailNV);
                
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public bool UpdateKhach(DTO_KhachHang kh)
        {
           
            try
            {
               
                _conn.Open();
               
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_UpdateKhach";
                cm.Parameters.AddWithValue("Dienthoai", kh.SoDienThoai);
                cm.Parameters.AddWithValue("TenKhach", kh.TenKhach);
                cm.Parameters.AddWithValue("DiaChi", kh.DiaChi);
                cm.Parameters.AddWithValue("phai", kh.Phai);
                
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

        public bool DeleteKhach(string SDT)
        {
           
            try
            {
               
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DeleteKhach";
                cm.Parameters.AddWithValue("dienthoai", SDT);
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

        public DataTable SearchKhach(string soDT)
        {
           
            try
            {
                
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_SearchKhach";
                cm.Parameters.AddWithValue("Dienthoai", soDT);
                cm.Connection = _conn;
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cm.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                
                _conn.Close();
            }
        }
    }
}
