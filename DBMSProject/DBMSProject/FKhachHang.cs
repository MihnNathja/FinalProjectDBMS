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
    public partial class FKhachHang : Form
    {
        int maTaiKhoanKhachHang;
        int maMayTinh = 1;
        public FKhachHang()
        {
            InitializeComponent();
        }
        public FKhachHang(int maTaiKhoanKhachHang)
        {
            InitializeComponent();
            this.maTaiKhoanKhachHang = maTaiKhoanKhachHang;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            FDichVu dv = new FDichVu(maTaiKhoanKhachHang, maMayTinh);
            dv.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FDoiMatKhau fDoiMatKhau = new FDoiMatKhau(maTaiKhoanKhachHang);
            fDoiMatKhau.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            FThanhToanHoaDon fThanhToanHoaDon = new FThanhToanHoaDon();
            fThanhToanHoaDon.ShowDialog();
        }
    }
}
