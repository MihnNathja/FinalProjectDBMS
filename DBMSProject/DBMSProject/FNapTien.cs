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
        string conn;
        ClassTaiKhoanDAO classTaiKhoanDAO;
        ClassNapTienDAO classNapTienDAO;
        public int maNguoiQuanLy;
        public int maKhachHang;
        public FNapTien(string connStr, int maKhachHang, int maNguoiQuanLy)
        {
            InitializeComponent();
            conn = connStr;
            classNapTienDAO = new ClassNapTienDAO(conn);
            classTaiKhoanDAO = new ClassTaiKhoanDAO(conn);
            this.maNguoiQuanLy = maNguoiQuanLy;
            this.maKhachHang = maKhachHang;
        }

        private void txbSoTienNap_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbSoTienNap.Text, out decimal inputValue) && inputValue > 0)
            {
                try
                {
                    int tongBonus = classNapTienDAO.tongBonus(maKhachHang, Convert.ToDecimal(txbSoTienNap.Text));

                    decimal soTienSauBonus = inputValue * (1 + (decimal)tongBonus / 100);
                    decimal convertedValue = soTienSauBonus / 5000;

                    txbThoiGianQuyDoi.Text = $"{convertedValue:F2}h";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tính toán giờ chơi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                classNapTien.MaKhachHang = maKhachHang;
                classNapTien.ThoiGianNapTien = DateTime.Now;
                decimal soTienNap = Convert.ToDecimal(txbSoTienNap.Text);
                classNapTien.GiaTriNap = soTienNap;

                int tongBonus = classNapTienDAO.tongBonus(maKhachHang, Convert.ToDecimal(txbSoTienNap.Text));
                decimal tongThoiGian = Convert.ToDecimal(txbSoTienNap.Text) * (1 + (decimal)tongBonus / 100);
                tongThoiGian = (tongThoiGian / 5000);
                classNapTien.ThoiGianQuyDoi = TimeSpan.FromHours((double)tongThoiGian);

                /*ClassNapTienDAO classNapTienDAO = new ClassNapTienDAO(conn);*/
                classNapTienDAO.napTien(classNapTien, maNguoiQuanLy);
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