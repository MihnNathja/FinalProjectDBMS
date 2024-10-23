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
    public partial class FManHinhChinh : Form
    {   
        ClassHoaDonDAO hoaDonDAO = new ClassHoaDonDAO();
        public FManHinhChinh()
        {
            InitializeComponent();
            

        }
        
        public void addUser() 
        {
            for (int i = 0; i < 9; i++)
            {
                UCKhachHang ucInfoUser = new UCKhachHang();
                ucInfoUser.MaKHlbl.Text = (i+1).ToString();
                UserFlp.Controls.Add(ucInfoUser);
            }
        }
        public void addComputer()
        {
            for (int i = 0; i < 9; i++)
            {
                UCMayTinh ucInfoComputer = new UCMayTinh();
                ucInfoComputer.Seriallbl.Text = (i + 1).ToString();
                if (i % 2 == 0)
                {
                    ucInfoComputer.lblTinhTrang.Text = "Trống";
                }
                if(ucInfoComputer.lblTinhTrang.Text == "Trống")
                {
                    ucInfoComputer.btnThemThoiGian.Visible = false;
                }
                if (ucInfoComputer.lblTinhTrang.Text == "Đang sử dụng")
                {
                    ucInfoComputer.btnBaoTri.Visible = false;
                }
                computerFlp.Controls.Add(ucInfoComputer);
            }
        }
        public void addBill()
        {
            dgvChuaThanhToan.DataSource = hoaDonDAO.LoadHoaDonChuaThanhToan();
            dgvDaThanhToan.DataSource = hoaDonDAO.LoadHoaDonDaThanhToan();
        }

        private void dgvChuaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FChiTietHoaDon fChiTietHoaDon = new FChiTietHoaDon();
                fChiTietHoaDon.HideButton = true;
                fChiTietHoaDon.ShowDialog();
            }
        }
        private void dgvDaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maHoaDon = (int)dgvDaThanhToan.Rows[e.RowIndex].Cells["MaHoaDon"].Value;
                MessageBox.Show(maHoaDon.ToString());
                FChiTietHoaDon fChiTietHoaDon = new FChiTietHoaDon();
                fChiTietHoaDon.LoadChiTietHoaDon(maHoaDon);
                fChiTietHoaDon.ShowDialog();
            }
        }
      
        private void FManHinhChinh_Load(object sender, EventArgs e)
        {
            SelectMenuscript.SelectedIndex = 0;
            dgvDaThanhToan.CellClick += dgvDaThanhToan_CellClick;
        }

        private void ThoatTab_Enter(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChBHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của CheckBox
            if (ChBHienThiMatKhau.Checked)
            {
                // Hiển thị mật khẩu
                passwordtxb.UseSystemPasswordChar = false;
                re_passwordtxb.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                passwordtxb.UseSystemPasswordChar = true;
                re_passwordtxb.UseSystemPasswordChar = true;
            }
        }
    }
}
