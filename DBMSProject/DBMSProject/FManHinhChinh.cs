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
    public partial class FManHinhChinh : Form
    {   
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
            ChuaThanhToanDtg.Columns.Add("MaHD", "Mã Hóa Đơn");
            ChuaThanhToanDtg.Columns.Add("TrangThai", "Trạng thái");
            ChuaThanhToanDtg.Columns.Add("TriGia", "Trị giá");
            ChuaThanhToanDtg.Columns.Add("ThoiGianTao", "Thời gian tạo");

            DataGridViewButtonColumn btnChiTietCTT = new DataGridViewButtonColumn();
            btnChiTietCTT.HeaderText = "Chi Tiết";
            btnChiTietCTT.Name = "btnChiTiet";
            btnChiTietCTT.Text = "Xem Chi Tiết";
            btnChiTietCTT.UseColumnTextForButtonValue = true;
            ChuaThanhToanDtg.Columns.Add(btnChiTietCTT);
            ChuaThanhToanDtg.CellContentClick += ChuaThanhToanDtg_CellContentClick;

            ChuaThanhToanDtg.Rows.Add("HD001", "Chưa thanh toán", "150.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD002", "Chưa thanh toán", "200.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD003", "Chưa thanh toán", "250.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD004", "Chưa thanh toán", "300.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD005", "Chưa thanh toán", "350.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD006", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD007", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD008", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD009", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD0010", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD0011", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD0012", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD0013", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD0014", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            ChuaThanhToanDtg.Rows.Add("HD0015", "Chưa thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));

            DaThanhToanDtg.Columns.Add("MaHD", "Mã Hóa Đơn");
            DaThanhToanDtg.Columns.Add("TrangThai", "Trạng thái");
            DaThanhToanDtg.Columns.Add("TriGia", "Trị giá");
            DaThanhToanDtg.Columns.Add("ThoiGianTao", "Thời gian tạo");

            DataGridViewButtonColumn btnChiTietDTT = new DataGridViewButtonColumn();
            btnChiTietDTT.HeaderText = "Chi Tiết";
            btnChiTietDTT.Name = "btnChiTiet";
            btnChiTietDTT.Text = "Xem Chi Tiết";
            btnChiTietDTT.UseColumnTextForButtonValue = true;
            DaThanhToanDtg.Columns.Add(btnChiTietDTT);
            DaThanhToanDtg.CellContentClick += DaThanhToanDtg_CellContentClick;


            DaThanhToanDtg.Rows.Add("HD001", "Đã thanh toán", "150.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD002", "Đã thanh toán", "200.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD003", "Đã thanh toán", "250.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD004", "Đã thanh toán", "300.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD005", "Đã thanh toán", "350.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD006", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD007", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD008", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD009", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD0010", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD0011", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD0012", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD0013", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD0014", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
            DaThanhToanDtg.Rows.Add("HD0015", "Đã thanh toán", "400.000vnđ", DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void ChuaThanhToanDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ChuaThanhToanDtg.Columns["btnChiTiet"].Index && e.RowIndex >= 0)
            {
                FChiTietHoaDon invoiceForm = new FChiTietHoaDon();
                invoiceForm.ShowDialog();
            }
        }
        private void DaThanhToanDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DaThanhToanDtg.Columns["btnChiTiet"].Index && e.RowIndex >= 0)
            {
                FChiTietHoaDon fChiTietHoaDon = new FChiTietHoaDon();
                fChiTietHoaDon.HideButton =true;
                fChiTietHoaDon.ShowDialog();
            }
        }

        private void FManHinhChinh_Load(object sender, EventArgs e)
        {
            SelectMenuscript.SelectedIndex = 0;
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
        ClassUuDaiDAO uuDaiDAO = new ClassUuDaiDAO();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkRong())
            {
                ClassUuDai ud = new ClassUuDai(0, txtTenUuDai.Text, 
                    Convert.ToDouble(txtGiaTri.Text), Convert.ToDateTime(dtpThoiGianBatDau.Value),
                    Convert.ToDateTime(dtpThoiGianKetThuc.Value), txtDieuKien.Text,
                    Convert.ToInt32(txtSoLuong.Text), txtTinhTrang.Text); 
                ClassDichVuDAO dichvuDao = new ClassDichVuDAO();
                uuDaiDAO.ThemUuDai(ud);

                LoadUuDai();
                MessageBox.Show("Thêm ưu đãi thành công");
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
                ClassUuDaiDAO dichvuDao = new ClassUuDaiDAO();
                uuDaiDAO.SuaUuDai(ud);

                LoadUuDai();
                MessageBox.Show("Sửa ưu đãi thành công");
                return;
            }
            MessageBox.Show("Điền đầy đủ thông tin ưu đãi cần sửa");
        }
        private void LoadUuDai()
        {
            dgvQuanLyUuDai.DataSource = null;
            dgvQuanLyUuDai.DataSource = uuDaiDAO.TruyXuatDanhSachUuDai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            uuDaiDAO.XoaUuDai(Convert.ToInt32(txtMaUuDai.Text));
            LoadUuDai();
            MessageBox.Show("Xóa dịch vụ thành công");
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
            dgvQuanLyUuDai.DataSource = uuDaiDAO.TimKiemUuDai(txtTimKiem.Text.Trim());
        }
    }
}
