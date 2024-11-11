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
    public partial class FUuDai : Form
    {
        ClassHoaDon HoaDon;
        string conn;
        int maTaiKhoanKhachHang;
        string loaiKhachHang;
        public FUuDai(ClassHoaDon hoadon, int maTaiKhoanKhachHang, string connStr)
        {
            InitializeComponent();
            HoaDon = hoadon;
            conn = connStr;
            this.maTaiKhoanKhachHang = maTaiKhoanKhachHang;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ClassUuDaiDAO uudaiDao = new ClassUuDaiDAO(maTaiKhoanKhachHang, conn);
            ClassKhachHangDAO khDAO = new ClassKhachHangDAO(conn);
            loaiKhachHang = khDAO.GetLoaiKhachHang(maTaiKhoanKhachHang);
            List<ClassUuDai> listUD;
            if (loaiKhachHang == "Thường")
            {
                listUD = uudaiDao.TimKiemUuDaiThuong(txtTimKiem.Text.Trim());
            }
            else
            {
                listUD = uudaiDao.TimKiemUuDaiVip(txtTimKiem.Text.Trim());
            }
            addFlowLayoutPanel(listUD);
        }

        private void FUuDai_Load(object sender, EventArgs e)
        {
            ClassUuDaiDAO uudaiDao = new ClassUuDaiDAO(maTaiKhoanKhachHang, conn);
            List<ClassUuDai> listUD;
            ClassKhachHangDAO khDAO = new ClassKhachHangDAO(conn);
            loaiKhachHang = khDAO.GetLoaiKhachHang(maTaiKhoanKhachHang);
            if (loaiKhachHang == "Thường")
            {
                listUD = uudaiDao.TruyXuatDanhSachUuDaiThuong();
            }
            else
            {
                listUD = uudaiDao.TruyXuatDanhSachUuDaiVip();
            }

            addFlowLayoutPanel(listUD);
        }
        public void addFlowLayoutPanel(List<ClassUuDai> listUD)
        {
            flpnlUuDai.Controls.Clear();
            foreach (var item in listUD)
            {
                UCUuDai uc = new UCUuDai(HoaDon, conn);
                uc.LoadUCUuDai(item);
                flpnlUuDai.Controls.Add(uc);
            }
        }
    }
}
