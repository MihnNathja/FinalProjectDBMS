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
    public partial class UCKhachHang : UserControl
    {
 
        public static int maKHofUCKH;
        public static string typeAdd;
        string conn;
        ClassTaiKhoanDAO classTaiKhoanDAO;
        public int maNguoiQuanLy;
        public UCKhachHang(string connStr, int maNguoiQuanLy)
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            conn = connStr;
            classTaiKhoanDAO = new ClassTaiKhoanDAO(conn);
            this.maNguoiQuanLy = maNguoiQuanLy;
        }

        private void ThemThoiGianBtn_Click(object sender, EventArgs e)
        {
            FNapTien fNapTien = new FNapTien(conn, maNguoiQuanLy);
            fNapTien.loadTaiKhoangKH(lblTaiKhoan.Text);
            maKHofUCKH = Convert.ToInt32(lblMaKH.Text);
            typeAdd = "khachHang";
            fNapTien.ShowDialog();
        }
        public UCKhachHang UCKhachHangLoad(UCKhachHang ucKhachHang, ClassKhachHang classKhachHang)
        {
            
            ucKhachHang.lblMaKH.Text = classKhachHang.MaKhachHang.ToString();
            ucKhachHang.lblTaiKhoan.Text = classTaiKhoanDAO.GetTenTaiKhoan(classKhachHang.MaTaiKhoan);
            ucKhachHang.lblLoaiThanhVien.Text = classKhachHang.LoaiKhachHang.ToString();
            ucKhachHang.lblThoiGianConLai.Text = classKhachHang.ThoiGianConLai.ToString();
            ucKhachHang.lblDiemTichLuy.Text = classKhachHang.DiemTichLuy.ToString();
            return ucKhachHang;
        }
    }
}
