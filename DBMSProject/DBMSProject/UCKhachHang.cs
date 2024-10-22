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
    public partial class UCKhachHang : UserControl
    {
        FNapTien timeExtendForm = new FNapTien();
        public UCKhachHang()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ThemThoiGianBtn_Click(object sender, EventArgs e)
        {
            timeExtendForm.ShowDialog();
        }
    }
}
