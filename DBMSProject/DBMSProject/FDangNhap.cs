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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            ClassTaiKhoan classTaiKhoan = new ClassTaiKhoan(userNameTxb.Text, passwordTxb.Text);
            ClassTaiKhoanDAO classTaiKhoanDAO = new ClassTaiKhoanDAO();


            int maTaiKhoanKhachHang = classTaiKhoanDAO.KiemTraKhachHangDangNhap(classTaiKhoan);
            int maTaiKhoanNguoiQuanLy = classTaiKhoanDAO.KiemTraNguoiQuanLyDangNhap(classTaiKhoan);
            if (maTaiKhoanKhachHang != -1) // -1 tính là không tìm thấy
            {
                FKhachHang kh = new FKhachHang(maTaiKhoanKhachHang);

                // Mặc định tạm thời máy này có id là 1
/*                ClassKhachHangDAO classKhachHangDAO = new ClassKhachHangDAO();
                ClassKhachHang classKhachHang = classKhachHangDAO.getClassKhachHang(maTaiKhoanKhachHang);

                ClassPhienDangNhapDAO classPhienDangNhapDAO = new ClassPhienDangNhapDAO();
                classPhienDangNhapDAO.ThemPhienDangNhap(maTaiKhoanKhachHang);

                ClassPhienDangNhapDAO classPhienDangNhapDAO = new ClassPhienDangNhapDAO();*/

                

                kh.ShowDialog();
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
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FKhachHang kh = new FKhachHang();
            kh.ShowDialog();
        }
    }
}
