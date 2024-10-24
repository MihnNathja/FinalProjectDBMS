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
        FNapTien timeExtendForm = new FNapTien();
        public static int maKHofUCKH;
        public static string typeAdd;
        public UCKhachHang()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ThemThoiGianBtn_Click(object sender, EventArgs e)
        {
            timeExtendForm.loadTaiKhoangKH(lblTaiKhoan.Text);
            maKHofUCKH = Convert.ToInt32(lblMaKH.Text);
            typeAdd = "khachHang";
            timeExtendForm.ShowDialog();
        }
        public UCKhachHang UCKhachHangLoad(UCKhachHang ucKhachHang, ClassKhachHang classKhachHang)
        {
            ClassTaiKhoanDAO classTaiKhoanDAO = new ClassTaiKhoanDAO();
            ucKhachHang.lblMaKH.Text = classKhachHang.MaKhachHang.ToString();
            ucKhachHang.lblTaiKhoan.Text = classTaiKhoanDAO.GetTenTaiKhoan(classKhachHang.MaTaiKhoan);
            ucKhachHang.lblLoaiThanhVien.Text = classKhachHang.LoaiKhachHang.ToString();
            ucKhachHang.lblThoiGianConLai.Text = classKhachHang.ThoiGianConLai.ToString();
            ucKhachHang.lblDiemTichLuy.Text = classKhachHang.DiemTichLuy.ToString();
            return ucKhachHang;
        }
    }
}
