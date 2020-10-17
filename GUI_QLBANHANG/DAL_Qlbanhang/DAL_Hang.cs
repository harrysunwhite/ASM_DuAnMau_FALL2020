using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_Qlbanhang;

namespace DAL_Qlbanhang
{
    
    public class DAL_Hang : Dbconnect
        {
        public DataTable getHang()
        {


            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DanhSachHang";
                cm.Connection = _conn;
                DataTable dtHang = new DataTable();
                dtHang.Load(cm.ExecuteReader());
                return dtHang;
            }
            finally
            {

                _conn.Close();
            }

        }
        public bool ThemHang(DTO_Hang hang)
        {


            try
            {

                _conn.Open();

                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_InsertHang";
                cm.Parameters.AddWithValue("TenHang", hang.TenHang);
                cm.Parameters.AddWithValue("SoLuong", hang.SoLuong);
                cm.Parameters.AddWithValue("DonGiaNhap", hang.DonGiaNhap);
                cm.Parameters.AddWithValue("DonGiaBan", hang.DonGiaBan);
                cm.Parameters.AddWithValue("HinhAnh", hang.HinhAnh);
                cm.Parameters.AddWithValue("GhiChu", hang.GhiChu);
                cm.Parameters.AddWithValue("Email", hang.EmailNV);

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

        public bool UpdateHang(DTO_Hang hang)
        {

            try
            {

                _conn.Open();

                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_UpdateHang";
                cm.Parameters.AddWithValue("MaHang", hang.MaHang);
                cm.Parameters.AddWithValue("TenHang", hang.TenHang);
                cm.Parameters.AddWithValue("SoLuong", hang.SoLuong);
                cm.Parameters.AddWithValue("DonGiaNhap", hang.DonGiaNhap);
                cm.Parameters.AddWithValue("DonGiaBan", hang.DonGiaBan);
                cm.Parameters.AddWithValue("HinhAnh", hang.HinhAnh);
                cm.Parameters.AddWithValue("GhiChu", hang.GhiChu);

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

        public bool DeleteHang(int maHang)
        {

            try
            {

                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DeleteHang";
                cm.Parameters.AddWithValue("MaHang", maHang);
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

        public DataTable SearchHang(string tenHang)
        {


            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_SearchHang";
                cm.Connection = _conn;
                cm.Parameters.AddWithValue("TenHang", tenHang);
                DataTable dtHang = new DataTable();
                dtHang.Load(cm.ExecuteReader());
                return dtHang;
            }
            finally
            {

                _conn.Close();
            }
        }

        public DataTable ThongKeTon()
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_ThongKeTonKho";
                cm.Connection = _conn;
                
                DataTable dtHang = new DataTable();
                dtHang.Load(cm.ExecuteReader());
                return dtHang;
            }
            
            finally
            {
                _conn.Close();
            }
           
        }

        public DataTable ThongKeNhapHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_ThongKeNhap";
                cm.Connection = _conn;

                DataTable dtHang = new DataTable();
                dtHang.Load(cm.ExecuteReader());
                return dtHang;
            }

            finally
            {
                _conn.Close();
            }
        }

        public byte[] gethinhHang(string id)
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_LayHinhHangHoa";
                cm.Parameters.AddWithValue("MaHang", id);
               
                var hinh = (byte[])cm.ExecuteScalar();

                return hinh;
            }
            catch
            {

                return null;

            }
            finally
            {
                _conn.Close();
            }
        }


    }

}
