using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    internal class ClassChiTietHoaDonDAO
    {
        DBConnection dBConnection;

        List<ClassChiTietHoaDon> listChiTietHoaDon = new List<ClassChiTietHoaDon>();
        string sqlStr = string.Format("XemChiTietHoaDonProcedure");

        public ClassChiTietHoaDonDAO(string connStr)
        {
            dBConnection = new DBConnection(connStr);
        }
        public ClassHoaDon LayHoaDon(int maHoaDon)
        {
            
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand(sqlStr, dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ClassHoaDon classHoaDon = new ClassHoaDon(maHoaDon, Convert.ToInt32(reader["maKhachHang"]), Convert.ToInt32(reader["maMayTinh"]),
                    DateTime.Parse(reader["thoiGianTao"].ToString()), Convert.ToString(reader["trangThai"]), Convert.ToDecimal(reader["triGia"]),
                    reader.IsDBNull(reader.GetOrdinal("maUuDai")) ? (int?)null : Convert.ToInt32(reader["maUuDai"]));

                    reader.Close();
                    return classHoaDon;
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Không tìm thấy hóa đơn với mã: " + maHoaDon);
                    return null;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }  
        }
        public DataTable LayChiTietHoaDon(int maHoaDon)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM ChiTietHoaDonView WHERE maHoaDon = {maHoaDon}", dBConnection.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public int LayMaKhachHang(int maTaiKhoan)
        {
            try
            {
                object maKhachHang = -1;
                dBConnection.openConnection();


                using (SqlCommand cmd = new SqlCommand("SELECT dbo.fn_LayMaKhachHang(@maTaiKhoan)", dBConnection.getConnection))
                {
                    cmd.Parameters.AddWithValue("@maTaiKhoan", maTaiKhoan);

                    maKhachHang = cmd.ExecuteScalar();
                }

                return Convert.ToInt32(maKhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại (LayMaKhachHang): " + ex);
                return -1;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }

        public bool ThemDichVu_ChiTietHoaDon(int maTaiKhoan, int maMayTinh, int maDichVu, int soLuong)
        {
            int maKhachHang = LayMaKhachHang(maTaiKhoan);
            
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("sp_ThemDichVuVaoChiTietHoaDon", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);
                cmd.Parameters.AddWithValue("@maDichVu", maDichVu);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Dịch vụ không tồn tại"))
                {
                    MessageBox.Show("Dịch vụ không tồn tại");
                }
                else if (ex.Message.Contains("Số lượng dịch vụ không đủ"))
                {
                    MessageBox.Show("Số lượng dịch vụ không đủ");
                }
                else
                {
                    MessageBox.Show("that bai (ThemDichVu_ChiTietHoaDon)" + ex);
                }
                return false;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }

    }
}


