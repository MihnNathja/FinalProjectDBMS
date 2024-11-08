using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    internal class ClassPhienDangNhapDAO
    {
        DBConnection dBConnection;

        public ClassPhienDangNhapDAO(string connStr)
        {
            dBConnection = new DBConnection(connStr);
        }

        public ClassPhienDangNhap LapPhienDangNhap(int maTaiKhoan)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.LayPhienDangNhap(@maTaiKhoan)", dBConnection.getConnection);
                cmd.Parameters.AddWithValue("@maTaiKhoan", maTaiKhoan);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ClassPhienDangNhap classPhienDangNhap = new ClassPhienDangNhap
                        (Convert.ToInt32(reader["maKhachHang"]), Convert.ToInt32(reader["maMayTinh"]),
                         TimeSpan.Parse(reader["thoiGianBatDau"].ToString()), TimeSpan.Parse(reader["thoiGianSuDung"].ToString()),
                         TimeSpan.Parse(reader["thoiGianConLai"].ToString())
                         );


                return classPhienDangNhap;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public string getTenTaiKhoan(int maTaiKhoan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.GetTenTaiKhoan(@maTaiKhoan)", dBConnection.getConnection);
                cmd.Parameters.AddWithValue("@maTaiKhoan", maTaiKhoan);
                dBConnection.openConnection();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản với mã này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public void ThemPhienDangNhap(int maKhachHang)
        {
            try
            {
                dBConnection.openConnection();


                SqlCommand cmdLayMayTinh = new SqlCommand("LayMayTinhTrong", dBConnection.getConnection);
                cmdLayMayTinh.CommandType = CommandType.StoredProcedure;
                SqlDataReader readerMayTinh = cmdLayMayTinh.ExecuteReader();

                int maMayTinh = -1;
                if (readerMayTinh.Read())
                {
                    maMayTinh = Convert.ToInt32(readerMayTinh["maMayTinh"]);
                }
                readerMayTinh.Close();

                if (maMayTinh == -1)
                {
                    MessageBox.Show("Không có máy tính trống!", "Thông báo");
                    return;
                }


                SqlCommand cmd = new SqlCommand("ThemPhienDangNhap", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm phiên đăng nhập thành công vào máy: " + maMayTinh, "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
            finally
            {
                dBConnection.closeConnection();
            }

        }
        public void XoaPhienDangNhap(int maKhachHang, TimeSpan thoiGianConLai)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("XoaPhienDangNhap", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maKhachHang", maKhachHang);
                cmd.Parameters.AddWithValue("@thoiGianConLai", thoiGianConLai);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã đăng xuất thành công!");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { dBConnection.closeConnection();}
        }

    }
}
