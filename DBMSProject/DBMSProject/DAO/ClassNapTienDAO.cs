using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    public  class ClassNapTienDAO
    {
        DBConnection dBConnection;
        public ClassNapTienDAO(string connStr)
        {
            dBConnection = new DBConnection(connStr);
        }
        public void napTien(ClassNapTien classNapTien)
        {
            try
            {

                dBConnection.openConnection();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO NapTien (maKhachHang, thoiGianNapTien, giaTriNap, thoiGianQuyDoi, ghiChu) VALUES (@maKhachHang, @thoiGianNapTien, @giaTriNap, @thoiGianQuyDoi, @ghiChu)", dBConnection.getConnection))
                {
                    cmd.Parameters.AddWithValue("@maKhachHang", classNapTien.MaKhachHang);
                    cmd.Parameters.AddWithValue("@thoiGianNapTien", classNapTien.ThoiGianNapTien);
                    cmd.Parameters.AddWithValue("@giaTriNap", classNapTien.GiaTriNap);
                    cmd.Parameters.AddWithValue("@thoiGianQuyDoi", classNapTien.ThoiGianQuyDoi);
                    cmd.Parameters.AddWithValue("@ghiChu", (object)classNapTien.GhiChu ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
                
                MessageBox.Show("Nạp tiền thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp tiền vào tài khoản khách hàng: " + ex.Message);
            }
        }
    }
}
