using DBMSProject.DAO;
using DBMSProject.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class FDangNhap : Form
    {
        public static int maTaiKhoanKhachHang;
        public static int maTaiKhoanNguoiQuanLy;
        public FDangNhap()
        {
            InitializeComponent();
        }
        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            ClassTaiKhoan classTaiKhoan = new ClassTaiKhoan(userNameTxb.Text, passwordTxb.Text);
            ClassTaiKhoanDAO classTaiKhoanDAO = new ClassTaiKhoanDAO();
            

            maTaiKhoanKhachHang = classTaiKhoanDAO.KiemTraKhachHangDangNhap(classTaiKhoan);
            
            maTaiKhoanNguoiQuanLy = classTaiKhoanDAO.KiemTraNguoiQuanLyDangNhap(classTaiKhoan);

            if (maTaiKhoanKhachHang != -1) // -1 tính là không tìm thấy
            {

                ClassTaiKhoanDAO tkDAO = new ClassTaiKhoanDAO();
                int maKhachHang = tkDAO.ChuyenDoiMaTaiKhoanSangMaKhachHang(maTaiKhoanKhachHang);
                // Mặc định tạm thời máy này có id là
                
                ClassPhienDangNhapDAO classPhienDangNhapDAO = new ClassPhienDangNhapDAO();
                classPhienDangNhapDAO.ThemPhienDangNhap(maKhachHang);
                FKhachHang fKhachHang = new FKhachHang(maTaiKhoanKhachHang);
                this.Hide();
                fKhachHang.ShowDialog();
            } 
            else if (maTaiKhoanNguoiQuanLy != -1)
            {
                FQuanLy selectForm = new FQuanLy(maTaiKhoanNguoiQuanLy);
                selectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản");
            }
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FKhachHang kh = new FKhachHang();
            kh.ShowDialog();
        }

        private void ChBHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBHienThiMatKhau.Checked)
            {
                passwordTxb.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxb.UseSystemPasswordChar = true;
            }
        }
    }
}
