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
    public partial class FDoiMatKhau : Form
    {
        int maTaiKhoanKhachHang;
        string conn;
        ClassTaiKhoanDAO classTaiKhoan;
        ClassTaiKhoanDAO classTaiKhoanDAO;
        /* public FDoiMatKhau()
         {
             InitializeComponent();
         }*/
        public FDoiMatKhau(string connStr)
        {
            InitializeComponent();
            conn = connStr;
            classTaiKhoan = new ClassTaiKhoanDAO(conn);
            classTaiKhoanDAO = new ClassTaiKhoanDAO(conn);
        }
        public FDoiMatKhau(int maTaiKhoanKhachHang)
        {
            InitializeComponent();
            this.maTaiKhoanKhachHang = maTaiKhoanKhachHang;
            txtTenTaiKhoan.Text = classTaiKhoan.GetTenTaiKhoan(maTaiKhoanKhachHang);
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ClassTaiKhoan classTaiKhoan = new ClassTaiKhoan(txtTenTaiKhoan.Text, txtMatKhau.Text);
            classTaiKhoanDAO.DoiMatKhau(classTaiKhoan, txtMatKhauMoi.Text);

            
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChBHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của CheckBox
            if (ChBHienThiMatKhau.Checked)
            {
                // Hiển thị mật khẩu
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
            }
        }
    }
}
