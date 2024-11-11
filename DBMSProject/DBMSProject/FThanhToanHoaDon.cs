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

namespace DBMSProject
{
    public partial class FThanhToanHoaDon : Form
    {
        string conn;
        int maTaiKhoanKhachHang;
        public bool HoaDonTonTai = true;
        public FThanhToanHoaDon(int maTaiKhoanKhachHang, string connStr)
        {
            InitializeComponent();
            conn = connStr;
            this.maTaiKhoanKhachHang = maTaiKhoanKhachHang;
            LoadChiTietHoaDon();
        }

        ClassHoaDon hoadon;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ClassHoaDonDAO hdDAO = new ClassHoaDonDAO(conn);
            hdDAO.CapNhatTinhTrangHoaDon(Convert.ToInt32(lblMaHoaDon.Text));
            this.Close();
        }

        private void btnUuDai_Click(object sender, EventArgs e)
        {
            FUuDai fUD = new FUuDai(hoadon, maTaiKhoanKhachHang, conn);
            fUD.ShowDialog();
            LoadChiTietHoaDon();
        }
        private void LoadChiTietHoaDon()
        {
            ClassTaiKhoanDAO tkDAO = new ClassTaiKhoanDAO(conn);
            int makh = tkDAO.ChuyenDoiMaTaiKhoanSangMaKhachHang(maTaiKhoanKhachHang);

            ClassChiTietHoaDonDAO cthdDAO = new ClassChiTietHoaDonDAO(conn);
            ClassHoaDon classHoaDon = cthdDAO.LayHoaDon_KhachHang(makh);
            if(classHoaDon == null)
            {
                this.Close();
                HoaDonTonTai = false;
                return;
            }
            this.hoadon = classHoaDon;
            
            lblMaHoaDon.Text = classHoaDon.MaHoaDon.ToString();
            lblMaMayTinh.Text = classHoaDon.MaMayTinh.ToString();
            lblNgayTao.Text = classHoaDon.ThoiGianTao.ToString();
            lblTenTaiKhoan.Text = classHoaDon.MaKhachHang.ToString();
            lblTriGia.Text = classHoaDon.TriGia.ToString() + "VNĐ";


            dgvDichVuDaGoi.DataSource = cthdDAO.LayChiTietHoaDon(Convert.ToInt32(lblMaHoaDon.Text));


        }
    }
}
