using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    public class ClassKhachHangDAO
    {
        DBConnection db = new DBConnection();

        public List<ClassKhachHang> loadKhachHang()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM QuanLyKhachHangView", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                List<ClassKhachHang> khachHangs = new List<ClassKhachHang>();

                // Lặp qua từng dòng trong DataTable để chuyển thành đối tượng ClassKhachHang
                foreach (DataRow row in dataTable.Rows)
                {
                    ClassKhachHang khachHang = new ClassKhachHang(
                        maKhachHang: Convert.ToInt32(row["maKhachHang"]),
                        taiKhoan: row["taiKhoan"].ToString(),
                        thoiGianConLai: TimeSpan.Parse(row["thoiGianConLai"].ToString()),
                        loaiKhachHang: row["loaiKhachHang"].ToString(),
                        diemTichLuy: Convert.ToInt32(row["diemTichLuy"])
                    );

                    khachHangs.Add(khachHang);
                }
                return khachHangs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\n" + ex.StackTrace,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public List<ClassKhachHang> searchKhachHang(string taiKhoan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_SearchKhachHangByTaiKhoan", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                List<ClassKhachHang> khachHangs = new List<ClassKhachHang>();
                foreach (DataRow row in dataTable.Rows)
                {
                    ClassKhachHang khachHang = new ClassKhachHang(
                        maKhachHang: Convert.ToInt32(row["maKhachHang"]),
                        taiKhoan: row["taiKhoan"].ToString(),
                        thoiGianConLai: TimeSpan.Parse(row["thoiGianConLai"].ToString()),
                        loaiKhachHang: row["loaiKhachHang"].ToString(),
                        diemTichLuy: Convert.ToInt32(row["diemTichLuy"])
                    );
                    khachHangs.Add(khachHang);
                }

                return khachHangs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\n" + ex.StackTrace,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public string AddKhachHang(string taiKhoan, string matKhau)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_AddKhachHang", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                db.openConnection();

                // Thực thi stored procedure
                cmd.ExecuteNonQuery();

                return "Thêm khách hàng thành công";
            }
            catch (SqlException ex)
            {
                // Kiểm tra nếu tài khoản đã tồn tại dựa trên thông báo RAISERROR từ SQL
                if (ex.Number == 50000)  // Mã lỗi 50000 là mã mặc định của RAISERROR
                {
                    return "Tài khoản đã tồn tại";
                }
                else
                {
                    return "Lỗi: " + ex.Message;
                }
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}

