using DBMSProject.DAO;
using DBMSProject.Object;
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
        DBConnection db = new DBConnection();
        public FManHinhChinh()
        {
            InitializeComponent();

        }
        public void addUser()
        {
            ClassKhachHangDAO classKhachHangDAO = new ClassKhachHangDAO();
            List<ClassKhachHang> khachHangs = classKhachHangDAO.loadKhachHang();
            addFlowLayoutPanel(khachHangs);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txbSearch.Text;
            ClassKhachHangDAO classKhachHangDAO = new ClassKhachHangDAO();
            List<ClassKhachHang> khachHangs = classKhachHangDAO.searchKhachHang(searchValue);
            addFlowLayoutPanel(khachHangs);
        }
        public void addFlowLayoutPanel(List<ClassKhachHang> khachHangs)
        {
            UserFlp.Controls.Clear();
            foreach (var item in khachHangs)
            {
                UCKhachHang uCKhachHang = new UCKhachHang();
                uCKhachHang.UCKhachHangLoad(uCKhachHang, item);
                UserFlp.Controls.Add(uCKhachHang);
            }
        }
        public void addComputer()
        {
            ClassMayTinhDAO classMayTinhDAO = new ClassMayTinhDAO();
            List<ClassMayTinh> mayTinhs = classMayTinhDAO.loadMayTinh();
            computerFlp.Controls.Clear();
            foreach (var item in mayTinhs)
            {
                UCMayTinh ucMayTinh = new UCMayTinh();
                ucMayTinh.UCMayTinhLoad(ucMayTinh, item);
                computerFlp.Controls.Add(ucMayTinh);
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
                fChiTietHoaDon.HideButton = true;
                fChiTietHoaDon.ShowDialog();
            }
        }

        private void FManHinhChinh_Load(object sender, EventArgs e)
        {
            SelectMenuscript.SelectedIndex = 0;
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
                ClassKhachHangDAO khachHangDAO = new ClassKhachHangDAO();
                string result = khachHangDAO.AddKhachHang(username, password);
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
