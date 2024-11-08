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
    public class ClassUuDaiDAO
    {
        DBConnection dBConnection;
        public ClassUuDaiDAO(string connStr)
        {
            dBConnection = new DBConnection(connStr);
        }
        public List<ClassUuDai> TruyXuatDanhSachUuDai()
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand(string.Format($"SELECT * FROM ViewUuDai"), dBConnection.getConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ClassUuDai> listud = new List<ClassUuDai>();
                while (reader.Read())
                {
                    ClassUuDai dv = new ClassUuDai(Convert.ToInt32(reader["maUuDai"]),
                        reader["tenUuDai"].ToString(), Convert.ToDouble(reader["giaTri"]),
                        Convert.ToDateTime(reader["thoiGianBatDau"]), Convert.ToDateTime(reader["thoiGianKetThuc"]),
                        reader["dieuKien"].ToString(), Convert.ToInt32(reader["soLuong"]), reader["tinhTrang"].ToString());
                    listud.Add(dv);
                }
                reader.Close();
                return listud;
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (TruyXuatDanhSachUuDai)" + exc);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }

        public void ThemUuDai(ClassUuDai UuDai, int maTaiKhoanNguoiQuanLy)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("ThemUuDaiProcedure", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenUuDai", UuDai.TenUuDai);
                cmd.Parameters.AddWithValue("@giaTri", UuDai.GiaTri);
                cmd.Parameters.AddWithValue("@thoiGianBatDau", UuDai.ThoiGianBatDau);
                cmd.Parameters.AddWithValue("@thoiGianKetThuc", UuDai.ThoiGianKetThuc);
                cmd.Parameters.AddWithValue("@dieuKien", UuDai.DieuKien);
                cmd.Parameters.AddWithValue("@soLuong", UuDai.SoLuong);
                cmd.Parameters.AddWithValue("@tinhTrang", UuDai.TinhTrang);
                cmd.Parameters.AddWithValue("@maNguoiQuanLy", maTaiKhoanNguoiQuanLy);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm ưu đãi thành công");
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (ThemUuDai)" + exc);
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public void XoaUuDai(int maUuDai)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("XoaUuDaiProcedure", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maUuDai", maUuDai));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dịch vụ thành công");
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (XoaUuDai)" + exc);
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public void SuaUuDai(ClassUuDai UuDai)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("SuaUuDaiProcedure", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maUuDai", UuDai.MaUuDai);
                cmd.Parameters.AddWithValue("@tenUuDai", UuDai.TenUuDai);
                cmd.Parameters.AddWithValue("@giaTri", UuDai.GiaTri);
                cmd.Parameters.AddWithValue("@thoiGianBatDau", UuDai.ThoiGianBatDau);
                cmd.Parameters.AddWithValue("@thoiGianKetThuc", UuDai.ThoiGianKetThuc);
                cmd.Parameters.AddWithValue("@dieuKien", UuDai.DieuKien);
                cmd.Parameters.AddWithValue("@soLuong", UuDai.SoLuong);
                cmd.Parameters.AddWithValue("@tinhTrang", UuDai.TinhTrang);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa ưu đãi thành công");
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (SuaUuDai)" + exc);
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public List<ClassUuDai> TimKiemUuDai(string timkiem)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("TimKiemUuDaiProcedure", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenUuDai", timkiem);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ClassUuDai> listud = new List<ClassUuDai>();
                while (reader.Read())
                {
                    ClassUuDai dv = new ClassUuDai(Convert.ToInt32(reader["maUuDai"]),
                        reader["tenUuDai"].ToString(), Convert.ToDouble(reader["giaTri"]),
                        Convert.ToDateTime(reader["thoiGianBatDau"]), Convert.ToDateTime(reader["thoiGianKetThuc"]),
                        reader["dieuKien"].ToString(), Convert.ToInt32(reader["soLuong"]), reader["tinhTrang"].ToString());
                    listud.Add(dv);
                }
                reader.Close();
                return listud;
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (TimKiemUuDai)" + exc);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
    }
}
