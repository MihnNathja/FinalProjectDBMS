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

        string sqlStr = string.Format("XemChiTietHoaDonProcedure");
        public List<ClassChiTietHoaDon> XemChiTietHoaDon(int maHoaDon)
        {
            List<ClassChiTietHoaDon> listChiTietHoaDon = new List<ClassChiTietHoaDon>();
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand(sqlStr, dBConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   ClassChiTietHoaDon chiTietHoaDon = new ClassChiTietHoaDon
                        (Convert.ToInt32(reader["maHoaDon"]), Convert.ToInt32(reader["maMayTinh"]),
                         Convert.ToDateTime(reader["thoiGianTao"]), reader["tenDichVu"].ToString(),
                         reader["TenKhachHang"].ToString(), Convert.ToInt32(reader["soLuong"]),
                         Convert.ToDecimal(reader["tongGiaTien"]),
                         Convert.ToDecimal(reader["triGia"]), reader["trangThai"].ToString());
                    listChiTietHoaDon.Add(chiTietHoaDon);
                };
                reader.Close();
                return listChiTietHoaDon;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
        }

    }
}


