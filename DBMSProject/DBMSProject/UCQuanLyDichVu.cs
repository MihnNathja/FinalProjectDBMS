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
    public partial class UCQuanLyDichVu : UserControl
    {
        int maTaiKhoanNguoiQuanLy;
        public string conn;
        
        public UCQuanLyDichVu()
        {
            InitializeComponent();
            
        }
        
        string LoaiDV;
        public void LoadDuLieu(string loaiDichVu, string conn, int maTaiKhoanNguoiQuanLy)
        {
            this.conn = conn;
            ClassDichVuDAO dichvuDao = new ClassDichVuDAO(conn);
            dgvQuanLyDichVu.DataSource = null;
            if (loaiDichVu == "Đồ ăn")
            {
                dgvQuanLyDichVu.DataSource = dichvuDao.TruyXuatDanhSachDichVu("DichVuDoAnView");
            }
            else if (loaiDichVu == "Thức uống")
            {
                dgvQuanLyDichVu.DataSource = dichvuDao.TruyXuatDanhSachDichVu("DichVuThucUongView");
            }
            else
            {
                dgvQuanLyDichVu.DataSource = dichvuDao.TruyXuatDanhSachDichVu("DichVuTheCaoView");
            }
            LoaiDV = loaiDichVu;
            this.maTaiKhoanNguoiQuanLy = maTaiKhoanNguoiQuanLy;
        }
        private bool checkRong()
        {
            if(txtMaDichVu.Text == "" || txtLoaiDichVu.Text == "" || txtDonGia.Text == "" || txtSoLuong.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClassDichVuDAO dichvuDao = new ClassDichVuDAO(conn);
            if (checkRong())
            {
                ClassDichVu dichvu = new ClassDichVu(0, txtTenDichVu.Text, txtLoaiDichVu.Text, Convert.ToDouble(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text));
                
                dichvuDao.ThemDichVu(dichvu, maTaiKhoanNguoiQuanLy);

                LoadDuLieu(dichvu.LoaiDichVu,conn, maTaiKhoanNguoiQuanLy);
                return;
            }
            MessageBox.Show("Điền đầy đủ thông tin dịch vụ cần thêm");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClassDichVuDAO dichvuDao = new ClassDichVuDAO(conn);
            if (txtMaDichVu.Text != "")
            {
                dichvuDao.XoaDichVu(Convert.ToInt32(txtMaDichVu.Text));
                LoadDuLieu(txtLoaiDichVu.Text, conn, maTaiKhoanNguoiQuanLy);
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Điền mã dịch vụ cần xóa");
            }
        }
        private void ClearTextBox()
        {
            txtMaDichVu.Text = "";
            txtLoaiDichVu.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtTenDichVu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClassDichVuDAO dichvuDao = new ClassDichVuDAO(conn);
            if (checkRong())
            {
                ClassDichVu dichvu = new ClassDichVu(Convert.ToInt32(txtMaDichVu.Text), txtTenDichVu.Text, txtLoaiDichVu.Text, Convert.ToDouble(txtDonGia.Text), Convert.ToInt32(txtSoLuong.Text));
                dichvuDao.SuaDichVu(dichvu);

                LoadDuLieu(dichvu.LoaiDichVu, conn, maTaiKhoanNguoiQuanLy);
                
                return;
            }
            MessageBox.Show("Điền đầy đủ thông tin dịch vụ cần sửa");
        }


        private void UCQuanLyDichVu_Load(object sender, EventArgs e)
        {

        }

        private void dgvQuanLyDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQuanLyDichVu.Rows[e.RowIndex];

                txtMaDichVu.Text = row.Cells["maDichVu"].Value.ToString();
                txtTenDichVu.Text = row.Cells["tenDichVu"].Value.ToString();
                txtLoaiDichVu.Text = row.Cells["loaiDichVu"].Value.ToString();
                txtDonGia.Text = row.Cells["donGia"].Value.ToString();
                txtSoLuong.Text = row.Cells["soLuong"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ClassDichVuDAO dichvuDao = new ClassDichVuDAO(conn);
            dgvQuanLyDichVu.DataSource = dichvuDao.TimKiemDichVu(txtTimKiem.Text.Trim(), LoaiDV);
        }
    }
}
