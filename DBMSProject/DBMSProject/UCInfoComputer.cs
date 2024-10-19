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
    public partial class UCInfoComputer : UserControl
    {
        TimeExtendForm timeExtendForm = new TimeExtendForm();
        public UCInfoComputer()
        {
            InitializeComponent();
        }

        private void ThemThoiGianBtn_Click(object sender, EventArgs e)
        {
            timeExtendForm.ShowDialog();
        }
    }
}
