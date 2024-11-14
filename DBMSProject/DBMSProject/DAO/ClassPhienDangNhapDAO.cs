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
using System.Collections.ObjectModel;

namespace DBMSProject.DAO
{
    internal class ClassPhienDangNhapDAO
    {
        DBConnection dBConnection;
        ClassPhienDangNhap classPhienDangNhap;

        public ClassPhienDangNhapDAO(string connStr)
        {
            dBConnection = new DBConnection(connStr);
        }

        public ClassPhienDangNhap LapPhienDangNhap(int maTaiKhoan)
        {
            try
            {
                dBConnection.openConnectionAdmin();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.LayPhienDangNhap(@maTaiKhoan)", dBConnection.getConnectionAdmin);
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
                dBConnection.closeConnectionAdmin();
            }
        }
        public string getTenTaiKhoan(int maTaiKhoan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.GetTenTaiKhoan(@maTaiKhoan)", dBConnection.getConnectionAdmin);
                cmd.Parameters.AddWithValue("@maTaiKhoan", maTaiKhoan);
                dBConnection.openConnectionAdmin();
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
                dBConnection.closeConnectionAdmin();
            }
        }
        public void ThemPhienDangNhap(int maKhachHang)
        {
            try
            {
                dBConnection.openConnectionAdmin();

                int maMayTinh = 0;


                SqlCommand cmd = new SqlCommand("ThemPhienDangNhap", dBConnection.getConnectionAdmin);
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
                dBConnection.closeConnectionAdmin();
            }

        }
        public void CapNhatPhienDangNhap(int maKhachHang, TimeSpan thoiGianSuDung, TimeSpan thoiGianConLai)
        {
            dBConnection.openConnectionAdmin();
            try
            {
                
                dBConnection.openConnectionAdmin();

                // Tạo đối tượng SqlCommand để gọi stored procedure
                using (SqlCommand command = new SqlCommand("CapNhatPhienDangNhap", dBConnection.getConnectionAdmin))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    
                    command.Parameters.AddWithValue("@maKhachHang", maKhachHang);
                    command.Parameters.AddWithValue("@thoiGianSuDung", thoiGianSuDung);
                    command.Parameters.AddWithValue("@thoiGianConLai", thoiGianConLai);

                    command.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { dBConnection.closeConnectionAdmin(); }

        }
        public void XoaPhienDangNhap(int maKhachHang, TimeSpan thoiGianConLai)
        {
            try
            {
                dBConnection.openConnectionAdmin();
                SqlCommand cmd = new SqlCommand("XoaPhienDangNhap", dBConnection.getConnectionAdmin);
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
            finally { dBConnection.closeConnectionAdmin();}
        }

    }
}
