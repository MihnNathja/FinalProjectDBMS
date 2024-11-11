using DBMSProject.Object;
using DBMSProject.DAO;
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
        ClassPhienDangNhap classPhienDangNhap = new ClassPhienDangNhap();
        ClassPhienDangNhapDAO classPhienDangNhapDAO = new ClassPhienDangNhapDAO();

        private Timer timer;
        private int timeLoad;

        int maMayTinh = 1;
        public FKhachHang()
        {
            InitializeComponent();
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLoad++;

            TimeSpan time = TimeSpan.FromSeconds(timeLoad);
            txtThoiGianSuDung.Text = time.ToString(@"hh\:mm\:ss");
            if (classPhienDangNhap.ThoiGianConLai.TotalSeconds > 0)
            {
                classPhienDangNhap.ThoiGianConLai = classPhienDangNhap.ThoiGianConLai.Subtract(TimeSpan.FromSeconds(1));
                txtThoiGianConLai.Text = classPhienDangNhap.ThoiGianConLai.ToString(@"hh\:mm\:ss");
            }
            else
            {
                
                timer.Stop();
                MessageBox.Show("Thời gian còn lại đã hết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public FKhachHang(int maTaiKhoan)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual; 
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            this.maTaiKhoanKhachHang = maTaiKhoan;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timeLoad = 0;
            timer.Start();
            txtThoiGianSuDung.Text = "0:00:00";

            ClassTaiKhoanDAO tkDAO = new ClassTaiKhoanDAO();
            int maKhachHang = tkDAO.ChuyenDoiMaTaiKhoanSangMaKhachHang(maTaiKhoan);

            classPhienDangNhap = classPhienDangNhapDAO.LapPhienDangNhap(maKhachHang);
            string tenTaiKhoan = classPhienDangNhapDAO.getTenTaiKhoan(maTaiKhoan);
            lblUserName.Text = tenTaiKhoan;
            TimeSpan thoiGianBatDau = classPhienDangNhap.ThoiGianBatDau;
            txtThoiGianBatDau.Text = thoiGianBatDau.ToString(@"hh\:mm\:ss");
            TimeSpan thoiGianConLai = classPhienDangNhap.ThoiGianConLai;
            txtThoiGianConLai.Text = thoiGianConLai.ToString(@"hh\:mm\:ss");
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
            ClassTaiKhoanDAO tkDAO = new ClassTaiKhoanDAO();
            int maKhachHang = tkDAO.ChuyenDoiMaTaiKhoanSangMaKhachHang(maTaiKhoanKhachHang);
            MessageBox.Show(classPhienDangNhap.ThoiGianConLai.ToString());
            classPhienDangNhapDAO.XoaPhienDangNhap(maKhachHang, classPhienDangNhap.ThoiGianConLai);
            this.Close();
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            FThanhToanHoaDon fThanhToanHoaDon = new FThanhToanHoaDon(maTaiKhoanKhachHang);
            if (fThanhToanHoaDon.HoaDonTonTai)
            {
                fThanhToanHoaDon.ShowDialog();
            }
        }
    }
}
