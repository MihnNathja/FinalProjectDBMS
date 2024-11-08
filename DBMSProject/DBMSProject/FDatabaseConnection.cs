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
        private void FDatabaseConnectionLoadEventHandler(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
            DBMSProject.Properties.Settings.Default.ConnectType = true;
            MessageBox.Show("Bạn hãy chắc chắn đã bật Server Browser của SQL trước thì mới tải được Server lên\r\nĐể bật, hãy vào CMD gõ: net start SQLBrowser ", "Nhắc Nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối
            string connStr = "";
            if (checkWindow.Checked)
            {
                connStr = string.Format(@"Server={0};Database=QuanLyDichVuQuanNet;Trusted_Connection=True;", cboServer.Text);
            }
            else
            {
                connStr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3};",
                                        cboServer.Text, cboDatabase.Text, txtTaiKhoan.Text, txtMatKhau.Text);
            }

            // Khởi tạo đối tượng DBConnection với chuỗi kết nối
            /*dBConnection = new DBConnection(connStr);*/

            // Hiển thị chuỗi kết nối cho người dùng để kiểm tra
            MessageBox.Show("Chuỗi kết nối: " + connStr);

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

        private void CboServerDropDownEventHandler(object sender, EventArgs e)
        {
            if (cboServer.Items.Count == 0)
            {
                FLoadingDatabase fLoadingDatabase = new FLoadingDatabase();
                fLoadingDatabase.ShowDialog();
                while (!fLoadingDatabase.IsFinish) { }
                cboServer.Items.AddRange(fLoadingDatabase.Servers.ToArray());

            }
        }

        private void CboServerSelectedIndexChanged(object sender, EventArgs e)
        {
            string serverName = cboServer.SelectedItem.ToString();
            List<string> databases = GetDatabases(serverName);
            MessageBox.Show(databases.ToString());
            cboDatabase.Items.Clear();
            cboDatabase.Items.AddRange(databases.ToArray());
        }

        private List<string> GetDatabases(string serverName)
        {
            List<string> databases = new List<string>();
            string connectionString = $"Server={serverName};Trusted_Connection=True;";
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
