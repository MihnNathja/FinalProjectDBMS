using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    internal class ClassChiTietHoaDonDAO
    {
        DBConnection dBConnection = new DBConnection();

        List<ClassChiTietHoaDon> listChiTietHoaDon = new List<ClassChiTietHoaDon>();
        string sqlStr = string.Format("XemChiTietHoaDonProcedure");
        public ClassHoaDon LayHoaDon(int maHoaDon)
        {
            
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand(sqlStr, dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ClassHoaDon classHoaDon = new ClassHoaDon(maHoaDon, Convert.ToInt32(reader["maKhachHang"]), Convert.ToInt32(reader["maMayTinh"]),
                    DateTime.Parse(reader["thoiGianTao"].ToString()), Convert.ToString(reader["trangThai"]), Convert.ToDecimal(reader["triGia"]),
                    reader.IsDBNull(reader.GetOrdinal("maUuDai")) ? (int?)null : Convert.ToInt32(reader["maUuDai"]));

                    reader.Close();
                    return classHoaDon;
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Không tìm thấy hóa đơn với mã: " + maHoaDon);
                    return null;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }  
        }
        public DataTable LayChiTietHoaDon(int maHoaDon)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM ChiTietHoaDonView WHERE maHoaDon = {maHoaDon}", dBConnection.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }


    }
}


