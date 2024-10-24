using DBMSProject.Object;
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
    public partial class UCDichVu : UserControl
    {
        public UCDichVu()
        {
            InitializeComponent();
        }
        public ClassDichVu Dichvu;
        private void UCDichVu_Load(object sender, EventArgs e)
        {

        }
        public void LoadUCDichVu(ClassDichVu dichvu)
        {
            lblTenDichVu.Text = dichvu.TenDichVu;
            lblDonGia.Text = dichvu.DonGia.ToString();
            Dichvu = dichvu;
        }
    }
}
