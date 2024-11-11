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
