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
            string connectionString = "Server=HARRY;Database=QuanLyDichVuQuanNet;Trusted_Connection=True;";

            // Nhập tháng hiện tại và tháng trước
            //string thang = "2024-10";
            string thang = cbbNam1.SelectedItem.ToString() + "-" +  cbbThangTruoc.SelectedItem.ToString();
            string thangTruoc = cbbNam2.SelectedItem.ToString() + "-" + cbbThang.SelectedItem.ToString();

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
            string connectionString = "Server=HARRY;Database=QuanLyDichVuQuanNet;Trusted_Connection=True;";

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
                            DataSet dataSet = new DataSet();

                           
                            adapter.Fill(dataSet, "DuDoan");

                            
                            dataGridViewDuDoan.DataSource = dataSet.Tables["DuDoan"];
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
    }
}
