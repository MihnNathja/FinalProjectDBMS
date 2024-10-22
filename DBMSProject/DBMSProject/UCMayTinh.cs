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
    public partial class UCMayTinh : UserControl
    {
        FNapTien timeExtendForm = new FNapTien();
        public UCMayTinh()
        {
            InitializeComponent();
        }

        private void ThemThoiGianBtn_Click(object sender, EventArgs e)
        {
            timeExtendForm.ShowDialog();
        }
        bool checkBaoTri = false;
        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            if(checkBaoTri == false)
            {
                checkBaoTri = true;
                lblTinhTrang.Text = "Đang bảo trì";
                btnBaoTri.Text = "Đang bảo trì";
            }
            else
            {
                checkBaoTri = false;
                lblTinhTrang.Text = "Trống";
                btnBaoTri.Text = "Bảo trì";
            }
        }
    }
}
