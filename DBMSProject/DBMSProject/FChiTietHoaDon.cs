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
    public partial class FChiTietHoaDon : Form
    {
        ClassChiTietHoaDonDAO chiTietHoaDonDAO = new ClassChiTietHoaDonDAO();
        ClassChiTietHoaDon chiTietHoaDon;
        public FChiTietHoaDon()
        {
            InitializeComponent();
        }

        public bool HideButton { get; set; } = false;
        private void FChiTietHoaDon_Load(object sender, EventArgs e)
        {
            if (HideButton == true)
            {
                btnXuatHoaDon.Visible = false;
            }
        }
        public void LoadChiTietHoaDon(int maHoaDon)
        {
            List<ClassChiTietHoaDon> danhSachChiTietHoaDon = chiTietHoaDonDAO.XemChiTietHoaDon(maHoaDon);
            lblMaHoaDon.Text = danhSachChiTietHoaDon[0].MaHoaDon.ToString();  
            lblMaMayTinh.Text = danhSachChiTietHoaDon[0].MaMayTinh.ToString();  
            lblNgayTao.Text = danhSachChiTietHoaDon[0].ThoiGianTao.ToString();  
            lblTenTaiKhoan.Text = danhSachChiTietHoaDon[0].TaiKhoan;  
            lblTriGia.Text = danhSachChiTietHoaDon[0].TriGia.ToString() + "VNĐ";

            dgvDichVuDaGoi.DataSource = danhSachChiTietHoaDon.Select(x => new
            {
                TenDichVu = x.TenDichVu,
                SoLuong = x.SoLuong,
                TongGiaTien = x.TongGiaTien
            }).ToList();


        }
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Đã xuất hoá đơn");
        }
    }
}
