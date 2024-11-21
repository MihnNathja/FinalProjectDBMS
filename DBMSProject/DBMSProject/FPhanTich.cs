using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class FPhanTich : Form
    {
        public FPhanTich()
        {
            InitializeComponent();
        }

        private void btnPhanTich_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối SQL
            string connectionString = "Server=26.221.50.203;Database=QuanLyDichVuQuanNet;Persist Security Info=True;User ID=sa;Password=123456;";

            // Nhập tháng hiện tại và tháng trước
            //string thang = "2024-10";
            string thang = cbbNam1.SelectedItem.ToString() + "-" +  cbbThang.SelectedItem.ToString();
            string thangTruoc = cbbNam1.SelectedItem.ToString() + "-" + (int.Parse(cbbThang.SelectedItem.ToString()) - 1).ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.PhanTichDoanhThuThang(@Thang, @ThangTruoc)", connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Thang", thang);
                        command.Parameters.AddWithValue("@ThangTruoc", thangTruoc);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridViewPhanTich.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuDoan_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối SQL
            string connectionString = "Server=26.221.50.203;Database=QuanLyDichVuQuanNet;Persist Security Info=True;User ID=sa;Password=123456;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DuDoanDoanhThuTuPhanTichPhucTap", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);

                            // Check if two result sets are returned
                            if (ds.Tables.Count >= 2)
                            {
                                // Bind first table to Phân Tích Doanh Thu
                                dataGridViewDuDoan.DataSource = ds.Tables[0];

                                // Bind second table to Dự Đoán Doanh Thu
                                dataGridViewDuDoan1.DataSource = ds.Tables[1];
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu phù hợp từ procedure.", "Thông báo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FPhanTich_Load(object sender, EventArgs e)
        {

        }
    }
}
