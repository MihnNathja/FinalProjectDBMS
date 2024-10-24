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
        DBConnection dBConnection = new DBConnection();
        public ClassPhienDangNhapDAO()
        {

        }
        /*public int LayMayTinh()
        {
            try
            {
                dBConnection.openConnection();

                SqlCommand cmdLayMayTinh = new SqlCommand("LayMayTinhTrong", dBConnection.getConnection);
                cmdLayMayTinh.CommandType = CommandType.StoredProcedure;
                SqlDataReader readerMayTinh = cmdLayMayTinh.ExecuteReader();

                int maMayTinh = -1;
                
                maMayTinh = Convert.ToInt32(readerMayTinh["maMayTinh"]);
                
                if (maMayTinh == -1)
                {
                    MessageBox.Show("Không có máy tính trống!", "Thông báo");
                    readerMayTinh.Close();
                    return -1;
                }
                else
                {
                    readerMayTinh.Close();
                    return maMayTinh;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
                return -1;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }*/

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
    }
}
