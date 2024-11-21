using DBMSProject.Object;
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
using TableDependency.SqlClient;
using System.Data.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace DBMSProject
{
    public partial class FManHinhChinh : Form
    {
        public SqlTableDependency<ClassHoaDon> hoaDon_table_dependency;
        string connection_string_hoaDon = "Data Source=26.221.50.203;Initial Catalog=QuanLyDichVuQuanNet;Persist Security Info=True;User ID=sqlDependency;Password=sqlDependency;";

        /*DBConnection db = new DBConnection();*/
        ClassHoaDonDAO hoaDonDAO;
        ClassUuDaiDAO uuDaiDAO;
        string conn;
        
        int maTaiKhoanNguoiQuanLy;
        public FManHinhChinh(int maNguoiQuanLy, string connStr)
        {
            InitializeComponent();
            conn = connStr;
            hoaDonDAO = new ClassHoaDonDAO(conn);
            uuDaiDAO = new ClassUuDaiDAO(maNguoiQuanLy, conn);

            this.maTaiKhoanNguoiQuanLy = maNguoiQuanLy;
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
        public void loadKhachHang()
        {

        }
        public void addFlowLayoutPanel(List<ClassKhachHang> khachHangs)
        {
            UserFlp.Controls.Clear();
            foreach (var item in khachHangs)
            {
                UCKhachHang uCKhachHang = new UCKhachHang(conn, maTaiKhoanNguoiQuanLy);
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
            if (txtMaUuDai == null) return;
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

        private void FManHinhChinh_Load(object sender, EventArgs e)
        {
            SelectMenuscript.SelectedIndex = 0;
            dgvDaThanhToan.CellClick += dgvDaThanhToan_CellClick;
            dgvChuaThanhToan.CellClick += dgvChuaThanhToan_CellClick;
            refresh_table();
            start_hoaDon_table_dependency();
            LoadUuDai();
        }

        private void FManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                stop_hoaDon_table_dependency();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // start , stop , error, changed 
        private bool start_hoaDon_table_dependency()
        {
            try
            {
                hoaDon_table_dependency = new SqlTableDependency<ClassHoaDon>(connection_string_hoaDon, "HoaDon");
                hoaDon_table_dependency.OnChanged += hoaDon_table_dependency_Changed;
                hoaDon_table_dependency.OnError += hoaDon_table_dependency_OnError;
                hoaDon_table_dependency.Start();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool stop_hoaDon_table_dependency()
        {
            try
            {
                if (hoaDon_table_dependency != null)
                {
                    hoaDon_table_dependency.Stop();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;

        }
        private void hoaDon_table_dependency_OnError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            MessageBox.Show(e.Error.Message.ToString());
        }

        private void hoaDon_table_dependency_Changed(object sender, RecordChangedEventArgs<ClassHoaDon> e)
        {
            try
            {
                if (e.ChangeType != ChangeType.None)
                {
                    refresh_table();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        //common funcion
        private void refresh_table()
        {
            refresh("DichVuChuaThanhToanView", "chuaThanhToan");
            refresh("DichVuDaThanhToanView", "daThanhToan");
            refresh("ViewUuDaiVip", "uuDai");
        }

        private void refresh(String typeTable, String typeDgv)
        {
            try
            {
                string sql = string.Format("SELECT * FROM {0}", typeTable);
                using (SqlConnection connection = new SqlConnection(connection_string_hoaDon))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    if (typeDgv == "chuaThanhToan")
                    {
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() => dgvChuaThanhToan.DataSource = dataTable));
                        }
                        else
                        {
                            dgvChuaThanhToan.DataSource = dataTable;
                        }
                    }
                    else if (typeDgv == "daThanhToan")
                    {
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() => dgvDaThanhToan.DataSource = dataTable));
                        }
                        else
                        {
                            dgvDaThanhToan.DataSource = dataTable;
                        }
                    }
                    else
                    {
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() => dgvQuanLyUuDai.DataSource = dataTable));
                        }
                        else
                        {
                            dgvQuanLyUuDai.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới bảng: {ex.Message}");
            }
        }
        private void ThreadSafe(MethodInvoker method)
        {
            try
            {
                if (InvokeRequired)
                    Invoke(method);
                else
                    method();
            }
            catch (ObjectDisposedException) { }
        }

        // Hàm tải dữ liệu từ thủ tục SQL và hiển thị biểu đồ
        private void LoadDataAndDisplayCharts()
        {
            ClassNguoiQuanLyDAO clNQLDAO = new ClassNguoiQuanLyDAO(conn);
            try
            {
                DataTable data = clNQLDAO.GetThongKeDoanhThu();
                DisplayBarChart(data);
                DisplayPieChart(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        

        // Hàm hiển thị biểu đồ cột
        private void DisplayBarChart(DataTable data)
        {
            chartBDCot.Series.Clear();
            chartBDCot.Titles.Clear();
            chartBDCot.Titles.Add("Doanh Thu Theo Ngày Trong Tuần");

            // Tạo Series cho từng loại doanh thu
            Series seriesDoAn = new Series("Đồ ăn");
            Series seriesThucUong = new Series("Thức uống");
            Series seriesTheCao = new Series("Thẻ cào");
            Series seriesNapTien = new Series("Nạp tiền");

            // Đặt kiểu biểu đồ là cột
            seriesDoAn.ChartType = SeriesChartType.Column;
            seriesThucUong.ChartType = SeriesChartType.Column;
            seriesTheCao.ChartType = SeriesChartType.Column;
            seriesNapTien.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào Series
            foreach (DataRow row in data.Rows)
            {
                string day = row["NgayTrongTuan"].ToString();
                decimal doanhThuDoAn = Convert.ToDecimal(row["DoAn"]);
                decimal doanhThuThucUong = Convert.ToDecimal(row["ThucUong"]);
                decimal doanhThuTheCao = Convert.ToDecimal(row["TheCao"]);
                decimal doanhThuNapTien = Convert.ToDecimal(row["NapTien"]);

                seriesDoAn.Points.AddXY(day, doanhThuDoAn);
                seriesThucUong.Points.AddXY(day, doanhThuThucUong);
                seriesTheCao.Points.AddXY(day, doanhThuTheCao);
                seriesNapTien.Points.AddXY(day, doanhThuNapTien);
            }

            // Thêm Series vào biểu đồ
            chartBDCot.Series.Add(seriesDoAn);
            chartBDCot.Series.Add(seriesThucUong);
            chartBDCot.Series.Add(seriesTheCao);
            chartBDCot.Series.Add(seriesNapTien);

            // Thiết lập trục X và Y
            chartBDCot.ChartAreas[0].AxisX.Title = "Ngày Trong Tuần";
            chartBDCot.ChartAreas[0].AxisY.Title = "Doanh Thu (VND)";
            chartBDCot.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}";
        }

        // Hàm hiển thị biểu đồ tròn
        private void DisplayPieChart(DataTable data)
        {
            chartBDTron.Series.Clear();
            chartBDTron.Titles.Clear();
            chartBDTron.Titles.Add("Tỷ Lệ % Doanh Thu Dịch Vụ và Nạp Tiền");

            Series series = new Series("Doanh Thu");
            series.ChartType = SeriesChartType.Pie;

            decimal totalDoAn = 0, totalThucUong = 0, totalTheCao = 0, totalNapTien = 0;

            // Tính tổng doanh thu từ từng loại dịch vụ
            foreach (DataRow row in data.Rows)
            {
                totalDoAn += Convert.ToDecimal(row["DoAn"]);
                totalThucUong += Convert.ToDecimal(row["ThucUong"]);
                totalTheCao += Convert.ToDecimal(row["TheCao"]);
                totalNapTien += Convert.ToDecimal(row["NapTien"]);
            }
            decimal tong = totalDoAn + totalThucUong + totalTheCao + totalNapTien;
            // Thêm dữ liệu vào biểu đồ tròn
            if (tong == 0)
            {
                // Nếu tổng = 0, gán giá trị mặc định cho tỷ lệ phần trăm (ví dụ: 0)
                series.Points.AddXY("Đồ ăn", 0);
                series.Points.AddXY("Thức uống", 0);
                series.Points.AddXY("Thẻ cào", 0);
                series.Points.AddXY("Nạp tiền", 0);
            }
            else
            {
                // Nếu tổng không bằng 0, tính tỷ lệ phần trăm và thêm vào biểu đồ
                series.Points.AddXY("Đồ ăn", totalDoAn / tong);
                series.Points.AddXY("Thức uống", totalThucUong / tong);
                series.Points.AddXY("Thẻ cào", totalTheCao / tong);
                series.Points.AddXY("Nạp tiền", totalNapTien / tong);
            }

            // Hiển thị nhãn và định dạng phần trăm
            series.IsValueShownAsLabel = true;

            series.LabelFormat = "{0:0%}";

            chartBDTron.Series.Add(series);
        }

        private void SelectMenuscript_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataAndDisplayCharts();
        }

        private void btnDangKyQuanLy_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;
            string rePassword = txtNhapLaiMatKhau.Text;

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
                ClassNguoiQuanLyDAO quanLyDAO = new ClassNguoiQuanLyDAO(conn);
                string result = quanLyDAO.AddQuanLy(username, password);
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoatQLy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChBHienThiMatKhauQly_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của CheckBox
            if (ChBHienThiMatKhauQly.Checked)
            {
                // Hiển thị mật khẩu
                txtMatKhau.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                txtMatKhau.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FPhanTich fPhanTich = new FPhanTich();
            fPhanTich.ShowDialog();
        }
    }
}
