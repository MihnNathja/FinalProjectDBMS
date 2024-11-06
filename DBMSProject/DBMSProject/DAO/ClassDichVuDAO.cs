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
    public class ClassDichVuDAO
    {
        DBConnection dBConnection = new DBConnection();
        public ClassDichVuDAO() { }
        public List<ClassDichVu> TruyXuatDanhSachDichVu(string loaiDichVu)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand(string.Format($"SELECT * FROM {loaiDichVu}"), dBConnection.getConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ClassDichVu> listdv = new List<ClassDichVu>();
                while (reader.Read())
                {
                    ClassDichVu dv = new ClassDichVu(Convert.ToInt32(reader["maDichVu"]),
                        reader["tenDichVu"].ToString(), reader["loaiDichVu"].ToString(),
                        Convert.ToDouble(reader["donGia"]), Convert.ToInt32(reader["soLuong"]));
                    listdv.Add(dv);
                }
                reader.Close();
                return listdv;
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (TruyXuatDichVu)" + exc);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }

        public void ThemDichVu(ClassDichVu dichvu, int maTaiKhoanNguoiQuanLy)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("ThemDichVuProcedure", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDichVu", dichvu.TenDichVu);
                cmd.Parameters.AddWithValue("@loaiDichVu", dichvu.LoaiDichVu);
                cmd.Parameters.AddWithValue("@donGia", dichvu.DonGia);
                cmd.Parameters.AddWithValue("@soLuong", dichvu.SoLuong);
                cmd.Parameters.AddWithValue("@maNguoiQuanLy", maTaiKhoanNguoiQuanLy);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dịch vụ thành công");
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (ThemDichVu)" + exc);

            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public void XoaDichVu(int madichvu)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("XoaDichVuProcedure", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDichVu", madichvu));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dịch vụ thành công");
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (XoadichVu)" + exc);
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public void SuaDichVu(ClassDichVu dichvu)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("SuaDichVuProcedure", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maDichVu", dichvu.MaDichVu);
                cmd.Parameters.AddWithValue("@tenDichVu", dichvu.TenDichVu);
                cmd.Parameters.AddWithValue("@loaiDichVu", dichvu.LoaiDichVu);
                cmd.Parameters.AddWithValue("@donGia", dichvu.DonGia);
                cmd.Parameters.AddWithValue("@soLuong", dichvu.SoLuong);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa dịch vụ thành công");
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (SuaDichVu)" + exc);
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
        public List<ClassDichVu> TimKiemDichVu(string timkiem, string loaiDichVu)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("TimKiemDichVuProcedure", dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenDichVu", timkiem);
                cmd.Parameters.AddWithValue("@loaiDichVu", loaiDichVu);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ClassDichVu> listdv = new List<ClassDichVu>();
                while (reader.Read())
                {
                    ClassDichVu dv = new ClassDichVu(Convert.ToInt32(reader["maDichVu"]),
                        reader["tenDichVu"].ToString(), reader["loaiDichVu"].ToString(),
                        Convert.ToDouble(reader["donGia"]), Convert.ToInt32(reader["soLuong"]));
                    listdv.Add(dv);
                }
                reader.Close();
                return listdv;
            }
            catch (Exception exc)
            {
                MessageBox.Show("that bai (TimKiemDichVu)" + exc);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
    }
}
