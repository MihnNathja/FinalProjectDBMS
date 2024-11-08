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
    public class ClassMayTinhDAO
    {
        DBConnection dBConnection;
        public ClassMayTinhDAO(string connStr) 
        {
            dBConnection = new DBConnection(connStr);
        }

        public List<ClassMayTinh> loadMayTinh()
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM QuanLyMayTinhView", dBConnection.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                List<ClassMayTinh> mayTinhs = new List<ClassMayTinh>();

                foreach (DataRow row in dataTable.Rows)
                {
                    int maKhachHang = row.IsNull("maKhachHang") ? -1 : Convert.ToInt32(row["maKhachHang"]);

                    ClassMayTinh mayTinh = new ClassMayTinh(
                        maMayTinh: Convert.ToInt32(row["maMayTinh"]),
                        maKhachHang: maKhachHang, 
                        tinhTrang: row["tinhTrang"].ToString(),
                        ghiChu: row["ghiChu"].ToString(),
                        thoiGianBatDau: TimeSpan.Parse(row["thoiGianBatDau"].ToString()),
                        thoiGianDaDung: TimeSpan.Parse(row["thoiGianSuDung"].ToString()),
                        thoiGianConLai: TimeSpan.Parse(row["thoiGianConLai"].ToString())
                    );

                    mayTinhs.Add(mayTinh);
                }

                return mayTinhs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\n" + ex.StackTrace,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public void CapNhatTinhTrangMayTinh(int maMayTinh, string tinhTrang)
        {
            try
            {
                using (SqlConnection conn = dBConnection.getConnection)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateTinhTrangMayTinh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);
                        cmd.Parameters.AddWithValue("@tinhTrang", tinhTrang);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái máy tính: " + ex.Message);
            }
        }
    }

}
