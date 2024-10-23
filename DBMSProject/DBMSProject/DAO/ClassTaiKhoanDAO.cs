using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    internal class ClassTaiKhoanDAO
    {
        
        public int KiemTraKhachHangDangNhap(ClassTaiKhoan classTaiKhoan)
        {
            
            string SQLFunctionName = "KiemTraKhachHangDangNhap";
            return KiemTraDangNhap(classTaiKhoan, SQLFunctionName); ;
        }
        public int KiemTraNguoiQuanLyDangNhap(ClassTaiKhoan classTaiKhoan)
        {
            
            string SQLFunctionName = "KiemTraNguoiQuanLyDangNhap";
            return KiemTraDangNhap(classTaiKhoan, SQLFunctionName);
        }
        public int KiemTraDangNhap(ClassTaiKhoan classTaiKhoan, string SQLFunctionName)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                try
                {
                    conn.Open();

                    // Tạo một đối tượng SqlCommand để gọi hàm SQL
                    string SQL = $"SELECT dbo.{SQLFunctionName}(@taiKhoan, @matKhau)";
                    using (SqlCommand cmd = new SqlCommand(SQL, conn))
                    {
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
                            // Nếu không tìm thấy tài khoản hợp lệ
                            return -1; // hoặc một giá trị khác để chỉ tài khoản không hợp lệ
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                    return -1; // Trả về -1 nếu có lỗi xảy ra
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public string GetTenTaiKhoan(int maTaiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                try
                {
                    conn.Open();

                    // Tạo một đối tượng SqlCommand để gọi hàm SQL
                    string SQL = "SELECT dbo.GetTenTaiKhoan(@maTaiKhoan)";
                    using (SqlCommand cmd = new SqlCommand(SQL, conn))
                    {
                        // Thêm tham số cho hàm
                        cmd.Parameters.AddWithValue("@maTaiKhoan", maTaiKhoan);

                        // Thực thi câu lệnh và lấy giá trị trả về
                        object result = cmd.ExecuteScalar();
                        return result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                    return ""; 
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void DoiMatKhau(ClassTaiKhoan classTaiKhoan, string matKhauMoi)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                try
                {
                    conn.Open();

                    // Tạo một đối tượng SqlCommand để gọi hàm SQL
                    using (SqlCommand command = new SqlCommand("DoiMatKhau", conn))
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
                    conn.Close();
                }
            }
        }
        public ClassTaiKhoanDAO() { }
    }
}
