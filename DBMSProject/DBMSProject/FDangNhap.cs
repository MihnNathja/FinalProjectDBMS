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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        FQuanLy selectForm = new FQuanLy();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            selectForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FKhachHang kh = new FKhachHang();
            kh.ShowDialog();
        }
    }
}
