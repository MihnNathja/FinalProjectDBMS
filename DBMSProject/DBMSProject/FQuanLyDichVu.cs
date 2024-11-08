using DBMSProject.DAO;
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
    public partial class FQuanLyDichVu : Form
    {
        int maTaiKhoanNguoiQuanLy;
        string conn;
        public FQuanLyDichVu(int maTaiKhoanNguoiQuanLy, string connStr)
        {
            InitializeComponent();
            this.maTaiKhoanNguoiQuanLy = maTaiKhoanNguoiQuanLy;
            conn = connStr;
        }

        private void ServiceTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucQuanLyDoAn.LoadDuLieu(tabDichVu.SelectedTab.Text, conn, maTaiKhoanNguoiQuanLy);
            ucQuanLyThucUong.LoadDuLieu(tabDichVu.SelectedTab.Text, conn, maTaiKhoanNguoiQuanLy);
            ucQuanLyTheCao.LoadDuLieu(tabDichVu.SelectedTab.Text, conn, maTaiKhoanNguoiQuanLy);
        }

        private void FQuanLyDichVu_Load(object sender, EventArgs e)
        {
            ServiceTab_SelectedIndexChanged(sender, e);
        }
    }
}
