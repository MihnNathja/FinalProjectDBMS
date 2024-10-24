using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    public  class ClassNapTienDAO
    {
        public void napTien(ClassNapTien classNapTien)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO NapTien (maKhachHang, thoiGianNapTien, giaTriNap, thoiGianQuyDoi, ghiChu) VALUES (@maKhachHang, @thoiGianNapTien, @giaTriNap, @thoiGianQuyDoi, @ghiChu)", conn))
                    {
                        cmd.Parameters.AddWithValue("@maKhachHang", classNapTien.MaKhachHang);
                        cmd.Parameters.AddWithValue("@thoiGianNapTien", classNapTien.ThoiGianNapTien);
                        cmd.Parameters.AddWithValue("@giaTriNap", classNapTien.GiaTriNap);
                        cmd.Parameters.AddWithValue("@thoiGianQuyDoi", classNapTien.ThoiGianQuyDoi);
                        cmd.Parameters.AddWithValue("@ghiChu", (object)classNapTien.GhiChu ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
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
