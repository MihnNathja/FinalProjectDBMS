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
        string conn;
        public FQuanLyDichVu(string connStr)
        {
            InitializeComponent();
            conn = connStr;
        }

        private void ServiceTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UCQuanLyDichVu ucQuanLyDoAn = new UCQuanLyDichVu(conn);
            //UCQuanLyDichVu ucQuanLyThucUong = new UCQuanLyDichVu(conn);
            //UCQuanLyDichVu ucQuanLyTheCao = new UCQuanLyDichVu(conn);
            //ucQuanLyDoAn.Location = new System.Drawing.Point(0, 0);
            //ucQuanLyDoAn.Name = "ucQuanLyDoAn";
            //ucQuanLyDoAn.Size = new System.Drawing.Size(1028, 576);
            //ucQuanLyThucUong.Location = new System.Drawing.Point(0, 0);
            //ucQuanLyThucUong.Name = "ucQuanLyThucUong";
            //ucQuanLyThucUong.Size = new System.Drawing.Size(1028, 576);
            //ucQuanLyThucUong.TabIndex = 0;
            //ucQuanLyDoAn.TabIndex = 0;
            ucQuanLyDoAn.LoadDuLieu(tabDichVu.SelectedTab.Text, conn);
            ucQuanLyThucUong.LoadDuLieu(tabDichVu.SelectedTab.Text, conn);
            ucQuanLyTheCao.LoadDuLieu(tabDichVu.SelectedTab.Text, conn);
        }

        private void FQuanLyDichVu_Load(object sender, EventArgs e)
        {
            ServiceTab_SelectedIndexChanged(sender, e);
        }
    }
}
