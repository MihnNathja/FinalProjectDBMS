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
        public static int maNguoiQuanLy;
        string conn;
        DBConnection connAdmin;
        /*public FDangNhap()
        {
            InitializeComponent();
        }*/
        public FDangNhap(string connStr)
        {
            InitializeComponent();
            conn = connStr;
            connAdmin = new DBConnection(conn);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            ClassTaiKhoan classTaiKhoan = new ClassTaiKhoan(userNameTxb.Text, passwordTxb.Text);
            ClassTaiKhoanDAO classTaiKhoanDAO = new ClassTaiKhoanDAO(conn);
            
            
            maTaiKhoanKhachHang = classTaiKhoanDAO.KiemTraKhachHangDangNhap(classTaiKhoan);
            
            

            if (maTaiKhoanKhachHang != -1) // -1 tính là không tìm thấy
            {
                ClassTaiKhoanDAO tkDAO = new ClassTaiKhoanDAO(conn);
                int maKhachHang = tkDAO.ChuyenDoiMaTaiKhoanSangMaKhachHang(maTaiKhoanKhachHang);
                bool checkTGCL = tkDAO.KiemTraThoiGianConLai(maKhachHang);
                if (!checkTGCL)
                {
                    MessageBox.Show("Vui lòng nạp tiền vào tài khoản để đăng nhập!");
                }
                else
                {

                    ClassPhienDangNhapDAO classPhienDangNhapDAO = new ClassPhienDangNhapDAO(conn);
                    classPhienDangNhapDAO.ThemPhienDangNhap(maKhachHang);
                    FKhachHang fKhachHang = new FKhachHang(maTaiKhoanKhachHang, conn);
                    this.Hide();
                    fKhachHang.ShowDialog();

                }
                return;
            }
            maNguoiQuanLy = classTaiKhoanDAO.KiemTraNguoiQuanLyDangNhap(classTaiKhoan);
            if (maNguoiQuanLy != -1)
            {
                FQuanLy selectForm = new FQuanLy(maNguoiQuanLy, conn);
                this.Hide();
                selectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản");
            }
            this.Show();

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
