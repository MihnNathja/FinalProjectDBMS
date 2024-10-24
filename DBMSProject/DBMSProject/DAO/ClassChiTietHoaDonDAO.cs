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
        DBConnection dBConnection = new DBConnection();

        string sqlStr = string.Format("XemChiTietHoaDonProcedure");
        public List<ClassChiTietHoaDon> XemChiTietHoaDon(int maHoaDon)
        {
            List<ClassChiTietHoaDon> listChiTietHoaDon = new List<ClassChiTietHoaDon>();
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand(sqlStr, dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   ClassChiTietHoaDon chiTietHoaDon = new ClassChiTietHoaDon
                        (Convert.ToInt32(reader["maHoaDon"]), Convert.ToInt32(reader["maMayTinh"]),
                         Convert.ToDateTime(reader["thoiGianTao"]), reader["tenDichVu"].ToString(),
                         reader["TenKhachHang"].ToString(), Convert.ToInt32(reader["soLuong"]),
                         Convert.ToDecimal(reader["tongGiaTien"]),
                         Convert.ToDecimal(reader["triGia"]), reader["trangThai"].ToString());
                    listChiTietHoaDon.Add(chiTietHoaDon);
                };
                reader.Close();
                return listChiTietHoaDon;
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


