using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject.DAO
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        /*public List<ClassDichVu> TruyXuatDanhSachDichVu(string sqlSTR)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlSTR, conn);
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
                conn.Close();
            }
        }*/
        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
