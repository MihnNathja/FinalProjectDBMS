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
        public FQuanLy()
        {
            InitializeComponent();
        }
        public FQuanLy(int maTaiKhoanNguoiQuanLy)
        {
            InitializeComponent();
            this.maTaiKhoanNguoiQuanLy = maTaiKhoanNguoiQuanLy;
        }
        FManHinhChinh mainScreenForm = new FManHinhChinh();
        FQuanLyDichVu servicesForm = new FQuanLyDichVu();
        private void MainScreenPtb_Click(object sender, EventArgs e)
        {
            mainScreenForm.addUser();
            
            mainScreenForm.addComputer();

            mainScreenForm.addBill();
            mainScreenForm.ShowDialog();              
        }

        private void categoryManagementPtb_Click(object sender, EventArgs e)
        {
            servicesForm.ShowDialog();
        }
    }
}
