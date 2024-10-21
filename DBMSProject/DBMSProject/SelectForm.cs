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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        MainScreenForm mainScreenForm = new MainScreenForm();
        ServicesForm servicesForm = new ServicesForm();
        private void MainScreenPtb_Click(object sender, EventArgs e)
        {
            mainScreenForm.addUser();
            mainScreenForm.addComputer();
            mainScreenForm.addBill();
            mainScreenForm.ShowDialog();              
        }

        private void categoryManagementPtb_Click(object sender, EventArgs e)
        {
            servicesForm.addService();
            servicesForm.ShowDialog();
        }
    }
}
