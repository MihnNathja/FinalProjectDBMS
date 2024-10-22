using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMSProject
{
    public partial class FNapTien : Form
    {
        public FNapTien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa có code gì đâu");
        }

        private void txbSoTienNap_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbSoTienNap.Text, out decimal inputValue) && inputValue != 0)
            {
                decimal convertedValue = inputValue / 5000;
                txbThoiGianQuyDoi.Text = convertedValue.ToString() +"h";
            }
            else
            {
                txbThoiGianQuyDoi.Text = "0h";
            }
        }
    }
}
