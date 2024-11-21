using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMSProject.DAO;


namespace DBMSProject
{
    public partial class FDatabaseConnection : Form
    {
        DBConnection dBConnection = new DBConnection();
        public FDatabaseConnection()
        {
            InitializeComponent();
        }
        private void checkWindowCheckedChangedEventHandler(object sender, EventArgs e)
        {
            if (checkWindow.Checked)
            {
                txtTaiKhoan.Enabled = false;
                txtMatKhau.Enabled = false;
                DBMSProject.Properties.Settings.Default.ConnectType = true;
            }
            else
            {
                txtTaiKhoan.Enabled = true;
                txtMatKhau.Enabled = true;
                DBMSProject.Properties.Settings.Default.ConnectType = false;

            }
        }
        



        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            
            // Chuỗi kết nối
            string connStr = "";
            if (checkWindow.Checked)
            {
                // Connection string bên dưới là để kết nối vào database local
                //connStr = string.Format("Data Source=26.221.50.203;Initial Catalog=QuanLyDichVuQuanNet;Persist Security Info=True;User ID=sqlDependency;Password=sqlDependency;");
                connStr = string.Format(@"Data Source={0};Initial Catalog=QuanLyDichVuQuanNet;Integrated Security=True;User ID=sqlDependency;Password=sqlDependency;", cboServer.SelectedItem.ToString());

            }
            else
            {
                connStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3};",
                                        cboServer.SelectedItem.ToString(), cboDatabase.Text, txtTaiKhoan.Text, txtMatKhau.Text);
                //connStr = string.Format(@"Data Source=26.221.50.203;Initial Catalog=QuanLyDichVuQuanNet;Persist Security Info=True;User ID={0};Password={1};",txtTaiKhoan.Text, txtMatKhau.Text);
                //connStr = string.Format(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyDichVuQuanNet;Persist Security Info=True;User ID={0};Password={1};", txtTaiKhoan.Text, txtMatKhau.Text);

                //Data Source = HARRY; Initial Catalog = QuanLyDichVuQuanNet; Integrated Security = True; Encrypt = True; Trust Server Certificate = True

            }

            // Khởi tạo đối tượng DBConnection với chuỗi kết nối
            dBConnection = new DBConnection(connStr); 

            


            // Kiểm tra kết nối
            if (!dBConnection.testConnection())
            {
                MessageBox.Show("Kết nối thất bại!\r\nHãy thử lại!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kết nối thành công!");

                // Chuyển sang form đăng nhập nếu kết nối thành công
                FDangNhap fDangNhap = new FDangNhap(connStr);
                this.Hide();
                fDangNhap.ShowDialog();
            }
        }

        // Đoạn code bên dưới sẽ không chạy trong luồng đăng nhập của khách hàng
        private void CboServerDropDownEventHandler(object sender, EventArgs e)
        {
            /*if (cboServer.Items.Count == 0)
            {
                FLoadingDatabase fLoadingDatabase = new FLoadingDatabase();
                fLoadingDatabase.ShowDialog();
                while (!fLoadingDatabase.IsFinish) { }
                cboServer.Items.AddRange(fLoadingDatabase.Servers.ToArray());

            }*/
        }

        private void cboDatabaseDropDownEventHandler(object sender, EventArgs e)
        {
            string serverName = "26.221.50.203";
            List<string> databases = GetDatabases(serverName);

            cboDatabase.Items.Clear();
            cboDatabase.Items.AddRange(databases.ToArray());
        }

        private List<string> GetDatabases(string serverName)
        {
            List<string> databases = new List<string>();
            string connectionString = $"Data Source={serverName};Persist Security Info=True;User ID=sa;Password=123456;";
            MessageBox.Show(connectionString);
            dBConnection = new DBConnection(connectionString); // truyền chuỗi kết nối vào DBConnection

            try
            {
                dBConnection.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", dBConnection.getConnection);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    databases.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                dBConnection.closeConnection();
            }

            return databases;
        }

    }
}
