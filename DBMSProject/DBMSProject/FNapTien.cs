using DBMSProject.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMSProject
{
    public partial class FNapTien : Form
    {
        public FNapTien()
        {
            InitializeComponent();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            try
            {
                ClassNapTien classNapTien = new ClassNapTien();

                if (UCMayTinh.typeAdd == "mayTinh")
                {
                    classNapTien.MaKhachHang = UCMayTinh.maKHofUCMT; // Lấy mã khách hàng từ UCMayTinh
                    UCMayTinh.typeAdd = null; // Đặt lại về null sau khi sử dụng
                }
                else if (UCKhachHang.typeAdd == "khachHang")
                {
                    classNapTien.MaKhachHang = UCKhachHang.maKHofUCKH; // Lấy mã khách hàng từ UCKhachHang
                    UCKhachHang.typeAdd = null; // Đặt lại về null sau khi sử dụng
                }

                classNapTien.ThoiGianNapTien = DateTime.Now;
                decimal soTienNap = Convert.ToDecimal(txbSoTienNap.Text);
                classNapTien.GiaTriNap = soTienNap;

                double soGioChoi = (double)(soTienNap / 5000);
                classNapTien.ThoiGianQuyDoi = TimeSpan.FromHours(soGioChoi);
                classNapTien.GhiChu = null;

                ClassNapTienDAO classNapTienDAO = new ClassNapTienDAO();
                classNapTienDAO.napTien(classNapTien);
                txbSoTienNap.Text = "";
                this.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số tiền nạp hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadTaiKhoangKH(String taikhoan)
        {
            txbTenTaiKhoan.Text = taikhoan;
        }
    }
}
