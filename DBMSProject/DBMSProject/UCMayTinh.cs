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
    public partial class UCMayTinh : UserControl
    {
        ClassTaiKhoanDAO classTaiKhoanDAO = new ClassTaiKhoanDAO();
        FNapTien timeExtendForm = new FNapTien();
        public static int maKHofUCMT;
        public static string typeAdd;
        private Timer timer;
        private TimeSpan thoiGianConLai;
        private TimeSpan thoiGianDaDung;
        public UCMayTinh()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick; 
        }


        private void ThemThoiGianBtn_Click(object sender, EventArgs e)
        {
            int maKH = classTaiKhoanDAO.ChuyenDoiMaKhachHangSangMaTaiKhoan(Convert.ToInt32(lblMaNguoiDung.Text));
            String taiKhoan = classTaiKhoanDAO.GetTenTaiKhoan(maKH);
            timeExtendForm.loadTaiKhoangKH(taiKhoan);
            maKHofUCMT = Convert.ToInt32(lblMaNguoiDung.Text);
            typeAdd = "mayTinh";
            timeExtendForm.ShowDialog();
        }
        bool checkBaoTri = false;
        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            if (lblTinhTrang.Text == "Trống")
            {
                checkBaoTri = true;
                lblTinhTrang.Text = "Đang bảo trì";
                btnBaoTri.Text = "Đang bảo trì";
                ClassMayTinhDAO classMayTinhDAO = new ClassMayTinhDAO();
                classMayTinhDAO.CapNhatTinhTrangMayTinh(Convert.ToInt32(lblSerial.Text), "DangBaoTri");
            }
            else if (lblTinhTrang.Text == "Đang bảo trì")
            {
                checkBaoTri = false;
                lblTinhTrang.Text = "Trống";
                btnBaoTri.Text = "Bảo trì";
                ClassMayTinhDAO classMayTinhDAO = new ClassMayTinhDAO();
                classMayTinhDAO.CapNhatTinhTrangMayTinh(Convert.ToInt32(lblSerial.Text), "Trong");
            }
        }
        public UCMayTinh UCMayTinhLoad(UCMayTinh ucMayTinh, ClassMayTinh classMayTinh)
        {
            ucMayTinh.lblSerial.Text = classMayTinh.MaMayTinh.ToString();
            ucMayTinh.lblMaNguoiDung.Text = classMayTinh.MaKhachHang.ToString();
            String type = classMayTinh.TinhTrang.ToString();
            ucMayTinh.lblTinhTrang.Text = (type == "DangSuDung") ? "Đang sử dụng" :
                                          (type == "Trong") ? "Trống" :
                                          (type == "DangBaoTri") ? "Đang bảo trì" :
                                          ucMayTinh.lblTinhTrang.Text;

            thoiGianConLai = classMayTinh.ThoiGianConLai;
            thoiGianDaDung = classMayTinh.ThoiGianDaDung;

            if (ucMayTinh.lblTinhTrang.Text == "Đang sử dụng")
            {
                timer.Start();
                ucMayTinh.btnBaoTri.Visible = false;
                ucMayTinh.btnThemThoiGian.Visible = true;
            }
            else
            {
                ucMayTinh.btnBaoTri.Visible = true;
                ucMayTinh.btnThemThoiGian.Visible = false;
                ucMayTinh.lblThoiGianDaDung.Text = "...";
                ucMayTinh.lblThoiGianConLai.Text = "...";
            }

            if (classMayTinh.MaKhachHang == -1)
            {
                ucMayTinh.lblMaNguoiDung.Text = "...";
            }
            if (ucMayTinh.lblTinhTrang.Text == "Đang bảo trì")
            {
                ucMayTinh.btnBaoTri.Text = "Đang bảo trì";
            }
            return ucMayTinh;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (thoiGianConLai.TotalSeconds > 0)
            {
                thoiGianConLai = thoiGianConLai.Subtract(TimeSpan.FromSeconds(1));
                thoiGianDaDung = thoiGianDaDung.Add(TimeSpan.FromSeconds(1));

                lblThoiGianConLai.Text = thoiGianConLai.ToString(@"hh\:mm\:ss");
                lblThoiGianDaDung.Text = thoiGianDaDung.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
