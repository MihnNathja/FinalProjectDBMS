using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace DBMSProject.DAO
{
    internal class ClassTaiKhoanDAO
    {
        DBConnection dBConnection;

        public ClassTaiKhoanDAO(string connStr)
        {
            dBConnection = new DBConnection(connStr);

        }
        public int KiemTraKhachHangDangNhap(ClassTaiKhoan classTaiKhoan)
        {
            
            string SQLFunctionName = "KiemTraKhachHangDangNhap";
            return KiemTraDangNhap(classTaiKhoan, SQLFunctionName);
        }
        public int KiemTraNguoiQuanLyDangNhap(ClassTaiKhoan classTaiKhoan)
        {
            
            string SQLFunctionName = "KiemTraNguoiQuanLyDangNhap";
            return KiemTraDangNhap(classTaiKhoan, SQLFunctionName);
        }
        public int KiemTraDangNhap(ClassTaiKhoan classTaiKhoan, string SQLFunctionName)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand($"SELECT dbo.{SQLFunctionName}(@taiKhoan, @matKhau)", dBConnection.getConnection);
                
                // Thêm tham số cho hàm
                cmd.Parameters.AddWithValue("@taiKhoan", classTaiKhoan.TenTaiKhoan);
                cmd.Parameters.AddWithValue("@matKhau", classTaiKhoan.MatKhau);
                // Thực thi câu lệnh và lấy giá trị trả về
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    // Chuyển đổi kết quả trả về thành int (maTaiKhoan)
                    return Convert.ToInt32(result.ToString());
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return -1; // Trả về -1 nếu có lỗi xảy ra
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        

        public string GetTenTaiKhoan(int maTaiKhoan)
        {
            try
            {
                dBConnection.openConnection();

                // Tạo một đối tượng SqlCommand để gọi hàm SQL
                string SQL = "SELECT dbo.GetTenTaiKhoan(@maTaiKhoan)";
                SqlCommand cmd = new SqlCommand(SQL, dBConnection.getConnection);
                    // Thêm tham số cho hàm
                cmd.Parameters.AddWithValue("@maTaiKhoan", maTaiKhoan);

                // Thực thi câu lệnh và lấy giá trị trả về
                object result = cmd.ExecuteScalar();
                return result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return "";
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }

        public void DoiMatKhau(ClassTaiKhoan classTaiKhoan, string matKhauMoi)
        {
            
                try
                {
                    dBConnection.openConnection();

                    // Tạo một đối tượng SqlCommand để gọi hàm SQL
                    using (SqlCommand command = new SqlCommand("DoiMatKhau", dBConnection.getConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào command
                        command.Parameters.Add(new SqlParameter("@taiKhoan", classTaiKhoan.TenTaiKhoan));
                        command.Parameters.Add(new SqlParameter("@matKhau", classTaiKhoan.MatKhau));
                        command.Parameters.Add(new SqlParameter("@matKhauMoi", matKhauMoi));

                        // Thực thi thủ tục
                        command.ExecuteNonQuery();

                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
                finally
                {
                    dBConnection.closeConnection();
                }
            
        }
        public int ChuyenDoiMaKhachHangSangMaTaiKhoan(int maKhachHang)
        {
            
            
                try
                {
                    dBConnection.openConnectionAdmin();
                    using (SqlCommand command = new SqlCommand("sp_ChuyenDoiMaKhachHangSangMaTaiKhoan", dBConnection.getConnectionAdmin))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@maKhachHang", maKhachHang));
                        SqlParameter outputParam = new SqlParameter("@maTaiKhoan", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);
                        command.ExecuteNonQuery();
                        int maTaiKhoan = (int)command.Parameters["@maTaiKhoan"].Value;
                        return maTaiKhoan;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                    return -1; 
                }
                finally
                {
                    dBConnection.closeConnectionAdmin();
                }
            
        }
        public int ChuyenDoiMaTaiKhoanSangMaKhachHang(int maTaiKhoan)
        {
            
            try
            {
                object maKhachHang = -1;
                dBConnection.openConnectionAdmin();

                using (SqlCommand cmd = new SqlCommand("SELECT dbo.fn_LayMaKhachHang(@maTaiKhoan)", dBConnection.getConnectionAdmin))
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
        public bool KiemTraThoiGianConLai(int maKhachHang)
        {
            bool result = false;
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = dBConnection.getConnectionAdmin;
                dBConnection.openConnectionAdmin();

                cmd = new SqlCommand("sp_KiemTraThoiGianConLai", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@maKhachHang", maKhachHang);

                SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();

                result = Convert.ToBoolean(outputParam.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra thời gian còn lại: " + ex.Message);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                dBConnection.closeConnectionAdmin();
            }

            return result;
        }


    }
}
