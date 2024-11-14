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
    internal class ClassNguoiQuanLyDAO
    {
        DBConnection dBConnection;
        public ClassNguoiQuanLyDAO(string connStr)
        {
            dBConnection = new DBConnection(connStr);
        }
        public DataTable GetThongKeDoanhThu()
        {
            try
            {
                dBConnection.openConnection();
                DataTable dataTable = new DataTable();
                SqlCommand cmd = new SqlCommand("sp_ThongKeDoanhThuTheoNgayTrongTuan", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (GetThongKeDoanhThu)" + exc);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public string AddQuanLy(string taiKhoan, string matKhau)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("sp_AddQuanLy", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                dBConnection.openConnection();

                // Thực thi stored procedure
                cmd.ExecuteNonQuery();

                return "Thêm quản lý thành công";
            }
            catch (SqlException ex)
            {
                return "Lỗi: " + ex.Message;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
    }
}
