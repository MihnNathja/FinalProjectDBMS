using DBMSProject.DAO;
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
    public partial class FQuanLy : Form
    {
        int maTaiKhoanNguoiQuanLy;
        string conn;
        
        public FQuanLy(int maTaiKhoanNguoiQuanLy, string connStr)
        {
            InitializeComponent();
            conn = connStr;
            this.maTaiKhoanNguoiQuanLy = maTaiKhoanNguoiQuanLy;
            
        }
        
        private void MainScreenPtb_Click(object sender, EventArgs e)
        {
            FManHinhChinh mainScreenForm = new FManHinhChinh(maTaiKhoanNguoiQuanLy,conn);
            mainScreenForm.addUser();
            mainScreenForm.addComputer();
            mainScreenForm.addBill();
            mainScreenForm.ShowDialog();              
        }

        private void categoryManagementPtb_Click(object sender, EventArgs e)
        {
            FQuanLyDichVu servicesForm = new FQuanLyDichVu(maTaiKhoanNguoiQuanLy,conn);
            servicesForm.ShowDialog();
        }
    }
}
