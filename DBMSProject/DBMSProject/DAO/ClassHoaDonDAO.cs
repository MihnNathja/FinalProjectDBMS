using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    internal class ClassHoaDonDAO
    {
        DBConnection dBConnection = new DBConnection();
        public List<ClassHoaDon> LoadHoaDonChuaThanhToan()
        {
            string sqlStr = string.Format("SELECT * FROM DichVuChuaThanhToanView");
            return TruyXuatHoaDon(sqlStr);
        }
        public List<ClassHoaDon> LoadHoaDonDaThanhToan()
        {
            string sqlStr = string.Format("SELECT * FROM DichVuDaThanhToanView");
            return TruyXuatHoaDon(sqlStr);
        }
        public List<ClassHoaDon> TruyXuatHoaDon(string sqlStr)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand(sqlStr, dBConnection.getConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ClassHoaDon> listHoaDon = new List<ClassHoaDon>();
                while (reader.Read())
                {
                    ClassHoaDon hoaDon = new ClassHoaDon(Convert.ToInt32(reader["maHoaDon"]),
                        Convert.ToDateTime(reader["thoiGianTao"]), Convert.ToString(reader["trangThai"]),
                        Convert.ToString(reader["tenTaiKhoan"]), Convert.ToDecimal(reader["triGia"]));
                    listHoaDon.Add(hoaDon);
                }
                reader.Close();
                return listHoaDon;
            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai truy xuất hoá đơn" + ex.Message);
                return null;
            }
            finally { dBConnection.closeConnection(); }
        }
    }
    
}

