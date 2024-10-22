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
    public partial class FChiTietHoaDon : Form
    {
        public FChiTietHoaDon()
        {
            InitializeComponent();
        }

        public bool HideButton { get; set; } = false;
        private void FChiTietHoaDon_Load(object sender, EventArgs e)
        {
            if (HideButton == true)
            {
                btnDaNhanThanToan.Visible = false;
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã xuất hoá đơn");
        }
    }
}
