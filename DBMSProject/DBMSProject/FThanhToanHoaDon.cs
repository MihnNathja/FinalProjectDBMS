using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class FThanhToanHoaDon : Form
    {
        string conn;
        public FThanhToanHoaDon(string connStr)
        {
            InitializeComponent();
            conn = connStr;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn đã sử dụng dịch vụ");
            this.Close();
        }

        private void btnUuDai_Click(object sender, EventArgs e)
        {
            ClassHoaDon hoadon = new ClassHoaDon(1,8,1, Convert.ToDateTime("10/25/2024 10:05:43 AM"), "ChuaThanhToan",160000,null); // Tạm thời
            FUuDai fUD = new FUuDai(hoadon, conn);
            fUD.ShowDialog();
        }
    }
}
