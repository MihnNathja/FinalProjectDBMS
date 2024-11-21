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

    public class DBConnection
    {
        private SqlConnection conn;
        //static SqlConnection connAdmin = new SqlConnection("Data Source=26.221.50.203;Initial Catalog=QuanLyDichVuQuanNet;Persist Security Info=True;User ID=sqlDependency;Password=sqlDependency;");
        static SqlConnection connAdmin = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=QuanLyDichVuQuanNet;Integrated Security=True;User ID=sqlDependency;Password=sqlDependency;");
        public DBConnection(string connStr)
        {

            conn = new SqlConnection(connStr);
        }
        public DBConnection()
        { 
            
        }

        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }
        public SqlConnection getConnectionAdmin
        {
            get
            {
                return connAdmin;
            }
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void openConnectionAdmin()
        {
            if (connAdmin.State == ConnectionState.Closed)
            {
                connAdmin.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public void closeConnectionAdmin()
        {
            if (connAdmin.State == ConnectionState.Open)
            {
                connAdmin.Close();
            }
        }


        public bool testConnection()
        {
            try
            {
                openConnection();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
