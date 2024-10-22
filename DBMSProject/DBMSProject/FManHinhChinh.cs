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

            ChuaThanhToanDtg.CellClick += ChuaThanhToanDtg_CellContentClick;
            // Dùng tạm hàm gọi chi tiết hóa đơn của chưa thanh toán
            DaThanhToanDtg.CellClick += ChuaThanhToanDtg_CellContentClick;
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
