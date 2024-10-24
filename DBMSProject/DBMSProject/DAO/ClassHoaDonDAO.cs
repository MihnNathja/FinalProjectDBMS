using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable LoadHoaDonChuaThanhToan()
        {
            string sqlStr = string.Format("SELECT * FROM DichVuChuaThanhToanView");
            return TruyXuatHoaDon(sqlStr);
        }
        public DataTable LoadHoaDonDaThanhToan()
        {
            string sqlStr = string.Format("SELECT * FROM DichVuDaThanhToanView");
            return TruyXuatHoaDon(sqlStr);
        }
        public DataTable TruyXuatHoaDon(string sqlStr)
        {
            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand(sqlStr, dBConnection.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại khi truy xuất hóa đơn: " + ex.Message);
                return null;
            }
            finally
            {
                dBConnection.closeConnection();
            }
        }
    }
    
}

