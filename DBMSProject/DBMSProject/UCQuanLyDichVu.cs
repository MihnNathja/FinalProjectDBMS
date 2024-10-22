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
    public partial class UCQuanLyDichVu : UserControl
    {
        public UCQuanLyDichVu()
        {
            InitializeComponent();
        }
        public void LoadDuLieu(List<ClassDichVu> listdv)
        {
            dgvQuanLyDichVu.DataSource = listdv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void UCQuanLyDichVu_Load(object sender, EventArgs e)
        {

        }
    }
}
