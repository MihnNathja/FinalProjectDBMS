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
    public partial class FQuanLy : Form
    {
        public FQuanLy()
        {
            InitializeComponent();
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
