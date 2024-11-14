﻿using DBMSProject.Object;
using DBMSProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class FManHinhChinh : Form
    {
        /*DBConnection db = new DBConnection();*/
        ClassHoaDonDAO hoaDonDAO;
        ClassUuDaiDAO uuDaiDAO;
        string conn;
        
        int maTaiKhoanNguoiQuanLy;
        public FManHinhChinh(int maTaiKhoanNguoiQuanLy, string connStr)
        {
            InitializeComponent();
            conn = connStr;
            hoaDonDAO = new ClassHoaDonDAO(conn);
            uuDaiDAO = new ClassUuDaiDAO(maTaiKhoanNguoiQuanLy, conn);

            this.maTaiKhoanNguoiQuanLy = maTaiKhoanNguoiQuanLy;
        }
        public void addUser()
        {
            ClassKhachHangDAO classKhachHangDAO = new ClassKhachHangDAO(conn);
            List<ClassKhachHang> khachHangs = classKhachHangDAO.loadKhachHang();
            addFlowLayoutPanel(khachHangs);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txbSearch.Text;
            ClassKhachHangDAO classKhachHangDAO = new ClassKhachHangDAO(conn);
            List<ClassKhachHang> khachHangs = classKhachHangDAO.searchKhachHang(searchValue);
            addFlowLayoutPanel(khachHangs);
        }
        public void addFlowLayoutPanel(List<ClassKhachHang> khachHangs)
        {
            UserFlp.Controls.Clear();
            foreach (var item in khachHangs)
            {
                UCKhachHang uCKhachHang = new UCKhachHang(conn);
                uCKhachHang.UCKhachHangLoad(uCKhachHang, item);
                UserFlp.Controls.Add(uCKhachHang);
            }
        }
        public void addComputer()
        {
            ClassMayTinhDAO classMayTinhDAO = new ClassMayTinhDAO(conn);
            List<ClassMayTinh> mayTinhs = classMayTinhDAO.loadMayTinh();
            computerFlp.Controls.Clear();
            foreach (var item in mayTinhs)
            {
                UCMayTinh ucMayTinh = new UCMayTinh(maTaiKhoanNguoiQuanLy,conn);
                ucMayTinh.UCMayTinhLoad(ucMayTinh, item);
                computerFlp.Controls.Add(ucMayTinh);
            }
        }
        public void addBill()
        {
            dgvChuaThanhToan.DataSource = hoaDonDAO.LoadHoaDonChuaThanhToan();
            dgvDaThanhToan.DataSource = hoaDonDAO.LoadHoaDonDaThanhToan();
        }

        private void dgvChuaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object cellValue = dgvChuaThanhToan.Rows[e.RowIndex].Cells["MaHoaDon"].Value;
            if (e.RowIndex >= 0 && cellValue != null && cellValue != DBNull.Value)
            {
                int maHoaDon = (int)cellValue;
                FChiTietHoaDon fChiTietHoaDon = new FChiTietHoaDon(maHoaDon, conn);
                fChiTietHoaDon.HideButton= true;
                if (!fChiTietHoaDon.checkCTHD) return;
                fChiTietHoaDon.ShowDialog();
                addBill();
            }
        }
        private void dgvDaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object cellValue = dgvDaThanhToan.Rows[e.RowIndex].Cells["MaHoaDon"].Value;
            if (e.RowIndex >= 0 && cellValue != null && cellValue != DBNull.Value)
            {
                int maHoaDon = (int)cellValue;
                FChiTietHoaDon fChiTietHoaDon = new FChiTietHoaDon(maHoaDon, conn);
                fChiTietHoaDon.HideButton = false;
                if (!fChiTietHoaDon.checkCTHD) return;
                fChiTietHoaDon.ShowDialog();
                addBill();
            }
        }
      
        private void FManHinhChinh_Load(object sender, EventArgs e)
        {
            SelectMenuscript.SelectedIndex = 0;
            dgvDaThanhToan.CellClick += dgvDaThanhToan_CellClick;
            dgvChuaThanhToan.CellClick += dgvChuaThanhToan_CellClick;
            LoadUuDai();
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
                txbPassword.UseSystemPasswordChar = false;
                txbRe_password.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                txbPassword.UseSystemPasswordChar = true;
                txbRe_password.UseSystemPasswordChar = true; 
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkRong())
            {
                ClassUuDai ud = new ClassUuDai(0, txtTenUuDai.Text, 
                    Convert.ToDouble(txtGiaTri.Text), Convert.ToDateTime(dtpThoiGianBatDau.Value),
                    Convert.ToDateTime(dtpThoiGianKetThuc.Value), txtDieuKien.Text,
                    Convert.ToInt32(txtSoLuong.Text), txtTinhTrang.Text); 
                ClassDichVuDAO dichvuDao = new ClassDichVuDAO(conn);
                uuDaiDAO.ThemUuDai(ud, maTaiKhoanNguoiQuanLy);

                LoadUuDai();
                
                return;
            }
            MessageBox.Show("Điền đầy đủ thông tin ưu đãi cần thêm");
        }
        private bool checkRong()
        {
            if (txtMaUuDai.Text == "" || txtTenUuDai.Text == "" || txtGiaTri.Text == "" || txtSoLuong.Text == "" 
                || txtDieuKien.Text == "" || txtTinhTrang.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkRong())
            {
                ClassUuDai ud = new ClassUuDai(Convert.ToInt32(txtMaUuDai.Text), txtTenUuDai.Text,
                    Convert.ToDouble(txtGiaTri.Text), Convert.ToDateTime(dtpThoiGianBatDau.Value),
                    Convert.ToDateTime(dtpThoiGianKetThuc.Value), txtDieuKien.Text,
                    Convert.ToInt32(txtSoLuong.Text), txtTinhTrang.Text);
                ClassUuDaiDAO dichvuDao = new ClassUuDaiDAO(maTaiKhoanNguoiQuanLy, conn);
                uuDaiDAO.SuaUuDai(ud);

                LoadUuDai();
                
                return;
            }
            MessageBox.Show("Điền đầy đủ thông tin ưu đãi cần sửa");
        }
        private void LoadUuDai()
        {
            dgvQuanLyUuDai.DataSource = null;
            dgvQuanLyUuDai.DataSource = uuDaiDAO.TruyXuatDanhSachUuDaiVip();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            uuDaiDAO.XoaUuDai(Convert.ToInt32(txtMaUuDai.Text));
            LoadUuDai();
            
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txtMaUuDai.Text = "";
            txtTenUuDai.Text = "";
            txtGiaTri.Text = "";
            txtSoLuong.Text = "";
            txtDieuKien.Text = "";
            txtTinhTrang.Text = "";
        }
        private void dgvQuanLyUuDai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQuanLyUuDai.Rows[e.RowIndex];

                txtMaUuDai.Text = row.Cells["maUuDai"].Value.ToString();
                txtTenUuDai.Text = row.Cells["tenUuDai"].Value.ToString();
                txtGiaTri.Text = row.Cells["giaTri"].Value.ToString();
                dtpThoiGianBatDau.Value = Convert.ToDateTime(row.Cells["thoiGianBatDau"].Value.ToString());
                dtpThoiGianKetThuc.Value = Convert.ToDateTime(row.Cells["thoiGianKetThuc"].Value.ToString());
                txtSoLuong.Text = row.Cells["soLuong"].Value.ToString();
                txtDieuKien.Text = row.Cells["dieuKien"].Value.ToString();
                txtTinhTrang.Text = row.Cells["tinhTrang"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvQuanLyUuDai.DataSource = uuDaiDAO.TimKiemUuDaiVip(txtTimKiem.Text.Trim());
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            string rePassword = txbRe_password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rePassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else if (password != rePassword)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ClassKhachHangDAO khachHangDAO = new ClassKhachHangDAO(conn);
                string result = khachHangDAO.AddKhachHang(username, password, maTaiKhoanNguoiQuanLy);
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyThanhVienTab_Enter(object sender, EventArgs e)
        {
            addUser();
        }
    }
}
